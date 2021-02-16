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
        [HttpGet("GBMS/All")]
        public async Task<IActionResult> GetFilteredUsers()
        {
            try
            {
                ///111 Accounts, 119 Maintenance, 120 Fuelling, 131 MT & Fueling
                List<string> departments = new List<string>() { "111", "119", "120", "131" };
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
                                                    OfficialEmail = u.XOfficialEmail
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
