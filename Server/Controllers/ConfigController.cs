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
    public class ConfigController : ControllerBase
    {
        AppDbContext dbContext;
        public ConfigController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<VehicleConfigurationVM> configs =
                await dbContext.VehicleConfigurations
                .Select(x => new VehicleConfigurationVM()
                {
                    Id = x.Id,
                    Description = x.Description,
                    Month = x.Month,
                    Distance = x.Distance,
                    PenalityPoints = x.PenalityPoints
                }).ToListAsync();

                return Ok(configs);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Post(VehicleConfigurationVM configuration)
        {
            try
            {
                VehicleConfiguration newConfiguration = new VehicleConfiguration() 
                {
                    Id = Guid.NewGuid(),
                    Description = configuration.Description,
                    Distance = configuration.Distance,
                    Month = configuration.Month,
                    PenalityPoints = configuration.PenalityPoints
                };

                await dbContext.VehicleConfigurations.AddAsync(newConfiguration);
                if (await dbContext.SaveChangesAsync() > 0)
                {
                    return Ok("Configuration saved.");
                }
                else
                {
                    return BadRequest("Configuration not saved.");
                }

            }
            catch (Exception ex)
            {
                return BadRequest("Internal error.");
            }
        }
    }
}
