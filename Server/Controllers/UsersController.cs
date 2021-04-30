using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
    public class UsersController : ControllerBase
    {
        AppDbContext dbContext;
        public UsersController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        /// <summary>
        /// get all filtered users w.r.t departments
        /// </summary>
        /// <returns></returns>
        [HttpGet("GBMS/All")]
        public async Task<IActionResult> GetFilteredUsers()
        {
            try
            {
                ///111 Accounts, 119 Maintenance, 120 Fuelling, 131 MT & Fueling
                List<string> departments = new List<string>() { "108" /*Audit*/, "111" /*Accounts*/, "119" /*Maintenance*/, "120" /*Fuelling*/, "131" /*MT & Fueling*/ };
                List<GBMSUserVM> users = await (from u in dbContext.GBMSUsers
                                                where departments.Contains(u.XDepartment)
                                                select new GBMSUserVM()
                                                {
                                                    Id = u.Id,
                                                    Name = u.XName,
                                                    Department = u.XDepartmentDescription,
                                                    Designation = u.XDesignationDescription,
                                                    Location = u.XLocationDescription,
                                                    Section = u.XSectionDescription,
                                                    OfficialEmail = u.XOfficialEmail,
                                                    Region = (from r in dbContext.SubRegions 
                                                              where u.XLocationDescription.Contains(r.XDescription)
                                                              select r.XRegionDescription).FirstOrDefault() ?? "Head Office",
                                                    SubRegion = (from r in dbContext.SubRegions
                                                                 where u.XLocationDescription.Contains(r.XDescription)
                                                                 select r.XDescription).FirstOrDefault() ?? "Head Office",
                                                    station = (from r in dbContext.Stations
                                                                 where u.XLocationDescription.Contains(r.XDescription)
                                                                 select r.XDescription).FirstOrDefault() ?? "Head Office"

                                                }).ToListAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        /// <summary>
        /// get all filtered users w.r.t departments
        /// </summary>
        /// <returns></returns>
        [HttpGet("FMS/All")]
        public async Task<IActionResult> GetFMSUsers()
        {
            try
            {
                List<string> departments = new List<string>() { "111", "119", "120", "131" };
                List<GBMSUserVM> users = await (from u in dbContext.Users
                                                select new GBMSUserVM()
                                                {
                                                    Id = new Guid(u.Id),
                                                    Name = u.Name,
                                                    OfficialEmail = u.Email
                                                }).ToListAsync();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
