using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.GBMSModels;
using SOS.FMS.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        SOS_VIEWSContext viewsContext;
        public VendorsController(SOS_VIEWSContext viewsContext)
        {
            this.viewsContext = viewsContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetFuelingVendors()
        {
            try
            {
                var vendors = await (from a in viewsContext.PblVendorManagements
                                     where a.XClearingAcDescription.Contains("Fuel")
                                     select new SelectListItem()
                                     {
                                         Text = a.XName,
                                         Value = a.XName
                                     }).ToListAsync();

                return Ok(vendors);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
