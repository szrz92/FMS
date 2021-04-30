using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        private readonly AppDbContext dbContext;
        public StationsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        /// <summary>
        /// get stations select list
        /// </summary>
        /// <returns></returns>
        [HttpGet("SelectList")]
        public async Task<IActionResult> GetSelectList()
        {
            try
            {
                List<SelectListItem> items = await (from s in dbContext.Stations
                                                    select new SelectListItem()
                                                    {
                                                        Text = s.XDescription,
                                                        Value = s.XCode
                                                    }).ToListAsync();
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
