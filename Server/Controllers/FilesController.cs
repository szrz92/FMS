using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IWebHostEnvironment env;
        private readonly ILogger<FilesController> logger;
        AppDbContext dbContext;
        public FilesController(IWebHostEnvironment env, ILogger<FilesController> logger, AppDbContext dbContext)
        {
            this.env = env;
            this.logger = logger;
            this.dbContext = dbContext;
        }

        [HttpPost("Files")]
        public IActionResult PostFiles(ApiRequest request)
        {
            try
            {
                List<string> files = (from f in dbContext.Files
                                      where f.CheckPoint == request.FMSAccidentalCheckId || f.CheckPoint == request.FMSEmergencyCheckId
                                      select f.Name).ToList();
                return Ok(files);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("[action]")]
        public void Save(IList<IFormFile> UploadFiles)
        {
            var Files = HttpContext.Request.Form.Files;
            long size = 0;
            try
            {
                foreach (var file in Files)
                {
                    Models.File f = new Models.File()
                    {
                        Id = Guid.NewGuid(),
                        CheckPoint = new Guid(file.Name),
                        Name = file.FileName
                    };

                    dbContext.Add(f);

                    if (dbContext.SaveChanges() > 0)
                    {
                        string subPath = env.ContentRootPath + "\\" + file.Name; // Your code goes here

                        if (!Directory.Exists(subPath))
                            Directory.CreateDirectory(subPath);

                        var filename = ContentDispositionHeaderValue
                                .Parse(file.ContentDisposition)
                                .FileName
                                .Trim('"');
                        filename = subPath + $@"\{filename}";
                        size += (int)file.Length;
                        if (!System.IO.File.Exists(filename))
                        {
                            using (FileStream fs = System.IO.File.Create(filename))
                            {
                                file.CopyTo(fs);
                                fs.Flush();
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Response.Clear();
                Response.StatusCode = 204;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "File failed to upload";
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = e.Message;
            }
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Upload(IFormFile postedFiles)
        {
            var postedFile = HttpContext.Request.Form.Files.FirstOrDefault();
            if (postedFile == null || postedFile.Length == 0)
            {
                return BadRequest("ImportExcel");
            }

            //Get file
            var newfile = new FileInfo(postedFile.FileName);
            var fileExtension = newfile.Extension;

            //Check if file is an Excel File
            if (fileExtension.Contains(".xls"))
            {
                using MemoryStream ms = new();
                await postedFile.CopyToAsync(ms);
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using ExcelPackage package = new(ms);
                ExcelWorksheet workSheet = package.Workbook.Worksheets.FirstOrDefault();
                int totalRows = workSheet.Dimension.Rows;

                List<PSOWorksheet> rows = new();

                for (int i = 2; i <= totalRows; i++)
                {
                    rows.Add(new PSOWorksheet
                    {
                        Id = Guid.NewGuid(),
                        FileName = newfile.Name,
                        CardNumber = workSheet.Cells[i, 1].Value.ToString(),
                        NameOnCard = workSheet.Cells[i, 2].Value.ToString(),
                        TxnAmount = workSheet.Cells[i, 3].Value.ToString(),
                        Rate = workSheet.Cells[i, 4].Value.ToString(),
                        Qty = workSheet.Cells[i, 5].Value.ToString(),
                        TxnTime = workSheet.Cells[i, 6].Value.ToString(),
                        Date = workSheet.Cells[i, 7].Value.ToString(),
                        MerchantName = workSheet.Cells[i, 8].Value.ToString(),
                        MerchantCity = workSheet.Cells[i, 9].Value.ToString(),
                        Product = workSheet.Cells[i, 10].Value.ToString()
                    });
                }
                dbContext.PSOWorksheets.AddRange(rows);
                await dbContext.SaveChangesAsync();
            }
            return Ok();
        }
    }
}
