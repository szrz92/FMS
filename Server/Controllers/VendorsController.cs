using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Server.GBMSModels;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.ViewModels;
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
        AppDbContext dbContext;
        public VendorsController(SOS_VIEWSContext viewsContext, AppDbContext dbContext)
        {
            this.viewsContext = viewsContext;
            this.dbContext = dbContext;
        }

        [HttpGet("Fueling")]
        public async Task<IActionResult> GetFuelingVendors()
        {
            try
            {
                var vendors = await (from a in viewsContext.PblVendorManagements
                                     where a.XClearingAcDescription.Contains("Fuel")
                                     select new Shared.SelectListItem()
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
        [HttpGet("All")]
        public async Task<IActionResult> GetVendors()
        {
            try
            {
                var vendors = await (from a in viewsContext.PblVendorManagements
                                     select new Shared.SelectListItem()
                                     {
                                         Text = a.XName,
                                         Value = a.XCode
                                     }).ToListAsync();

                return Ok(vendors);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("Assign")]
        public async Task<IActionResult> AssignVendors(WorkshopVM workshopVM)
        {
            try
            {
                string code = "", name = "";
                if (workshopVM.Type == "Approved")
                {
                    var vendor = await (from a in viewsContext.PblVendorManagements
                                        where a.XCode == workshopVM.Code
                                         select a).FirstOrDefaultAsync();
                    code = vendor.XCode;
                    name = vendor.XName;
                }
                else if (workshopVM.Type == "Un Approved")
                {
                    var driver = await (from d in dbContext.Drivers
                                        where d.Code == workshopVM.Code
                                        select d).FirstOrDefaultAsync();
                    code = driver.Code;
                    name = driver.Name;
                }

                AssignedWorkshop workshop = new AssignedWorkshop()
                {
                    Id = Guid.NewGuid(),
                    IncidentId = workshopVM.IncidentId,
                    SupplierType = workshopVM.Type,
                    SupplierCode = code,
                    SupplierName = name
                };
                await dbContext.AssignedWorkshops.AddAsync(workshop);
                if (await dbContext.SaveChangesAsync() > 0)
                {
                    if (workshopVM.IncidentType == "Emergency")
                    {
                        FMSEmergencyCheck check = await (from c in dbContext.FMSEmergencyCheckList
                                                         where c.Id == workshopVM.CheckId
                                                         select c).FirstOrDefaultAsync();
                        check.LastUpdated = PakistanDateTime.Now;
                        check.MaintenanceStatus = Shared.Enums.CheckMaintenanceStatus.InProgress;

                        Emergency emergency = await (from c in dbContext.Emergencies
                                                     where c.Id == workshopVM.IncidentId
                                                     select c).FirstOrDefaultAsync();
                        emergency.LastUpdated = PakistanDateTime.Now;

                        if (await dbContext.SaveChangesAsync() > 0)
                        {
                            return Ok();
                        }
                        else
                        {
                            return BadRequest();
                        }
                    }
                    else if (workshopVM.IncidentType == "Accident")
                    {
                        FMSAccidentalCheck check = await (from c in dbContext.FMSAccidentalCheckList
                                                         where c.Id == workshopVM.CheckId
                                                         select c).FirstOrDefaultAsync();
                        check.LastUpdated = PakistanDateTime.Now;
                        check.MaintenanceStatus = Shared.Enums.CheckMaintenanceStatus.InProgress;

                        Accident accident = await (from c in dbContext.Accidents
                                                     where c.Id == workshopVM.IncidentId
                                                     select c).FirstOrDefaultAsync();
                        accident.LastUpdated = PakistanDateTime.Now;

                        if (await dbContext.SaveChangesAsync() > 0)
                        {
                            return Ok();
                        }
                        else
                        {
                            return BadRequest();
                        }
                    }
                    return NotFound();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpPost("CheckAssigned")]
        public async Task<IActionResult> CheckAssignedVendor(WorkshopVM workshopVM)
        {
            try
            {
                WorkshopVM workshop = await (from a in dbContext.AssignedWorkshops
                                             where a.IncidentId == workshopVM.IncidentId
                                             select new WorkshopVM()
                                             {
                                                 CheckId = workshopVM.CheckId,
                                                 Code = a.SupplierCode,
                                                 IncidentId = workshopVM.IncidentId,
                                                 IncidentType = workshopVM.IncidentType,
                                                 Type = a.SupplierType
                                             }).FirstOrDefaultAsync();
                if (workshop != null)
                    return Ok(workshop);
                else
                    return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
