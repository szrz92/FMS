using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.GBMSModels;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared.ViewModels.Incident;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        AppDbContext dbContext;
        SOS_VIEWSContext viewsContext;
        public ServicesController(AppDbContext dbContext, SOS_VIEWSContext viewsContext)
        {
            this.dbContext = dbContext;
            this.viewsContext = viewsContext;
        }
        /// <summary>
        /// get all services types and sub service tyoes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetTypes()
        {
            try
            {
                var servicetypes = await (from a in viewsContext.PblServices
                                          select new ServicesList()
                                          {
                                              ServiceType = a.XTypeDescription,
                                              SubServiceType = a.XDescription
                                          }).ToListAsync();

                return Ok(servicetypes);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
