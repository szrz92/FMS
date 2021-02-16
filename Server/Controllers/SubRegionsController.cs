using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubRegionsController : ControllerBase
    {
        AppDbContext dbContext;
        public SubRegionsController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<SubRegionVM> rbSubRegions = await (from r in dbContext.SubRegions
                                                  select SubRegionViewModel(r)).ToListAsync();
                return Ok(rbSubRegions);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet("SelectList")]
        public async Task<IActionResult> GetSelectList()
        {
            try
            {
                List<SelectListItem> items = await (from r in dbContext.SubRegions
                                                    select SelectList(r)).ToListAsync();
                return Ok(items);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        private static SubRegionVM SubRegionViewModel(SubRegion r)
        {
            return new SubRegionVM()
            {
                AddDate = r.AddDate,
                AddId = r.AddId,
                IpAdd = r.IpAdd,
                Code = r.XCode,
                Description = r.XDescription,
                IpMod = r.IpMod,
                ModDate = r.ModDate,
                ModId = r.ModId,
                Remarks = r.XRemarks,
                rowId = r.XrowId,
                Abbrevation = r.XAbbrevation,
                Id = r.Id
            };
        }
        private static SelectListItem SelectList(SubRegion r)
        {
            return new SelectListItem()
            {
                Value = r.XCode,
                Text = r.XDescription
            };
        }
    }
}
