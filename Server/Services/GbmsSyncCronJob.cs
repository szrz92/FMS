using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SOS.FMS.Server.GBMSModels;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Traccar;
using SOS.FMS.Shared.Traccar.DeviceResponse;

namespace SOS.FMS.Server.Services
{
    public class GbmsSyncCronJob : CronJobService
    {
        private readonly ILogger<GbmsSyncCronJob> _logger;
        IServiceScopeFactory _serviceScope;

        public GbmsSyncCronJob(IScheduleConfig<GbmsSyncCronJob> config, ILogger<GbmsSyncCronJob> logger, IServiceScopeFactory serviceScope)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _serviceScope = serviceScope;
            _logger = logger;

        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            string log = "GBMS Sync Started";
            Console.WriteLine($"{DateTime.Now:hh:mm:ss} {log}");
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} {log}");
            return base.StartAsync(cancellationToken);
        }
        public override Task DoWork(CancellationToken cancellationToken)
        {
            string log = "GBMS Sync Working from cron job";
            Console.WriteLine($"{DateTime.Now:hh:mm:ss} {log}");
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} {log}");

            using (var scope = _serviceScope.CreateScope()) // this will use `IServiceScopeFactory` internally
            {
                var context = scope.ServiceProvider.GetService<SOS_VIEWSContext>();

                var users = (from u in context.PayEmployeeMasters select u).ToList();
                SyncUsers(users, scope);

                var regions = (from r in context.RbRegions select r).ToList();
                SyncRegions(regions, scope);

                var subregions = (from s in context.RbSubRegions select s).ToList();
                SyncSubRegions(subregions, scope);

                var vehicles = (from v in context.RbVehicles select v).ToList();
                SyncVehicles(vehicles, scope);

                var vehicletypes = (from t in context.RbVehicleTypes select t).ToList();
                SyncVehicleTypes(vehicletypes, scope);

                var zones = (from z in context.RbZones select z).ToList();
                SyncZones(zones, scope);

                var stations = (from s in context.RbStations select s).ToList();
                SyncStations(stations, scope);

                var drivers = (from d in context.PdwEmployeeMasters
                               where d.XDesignationDescription.Contains("river")
                               select d).ToList();

                SyncDrivers(drivers, scope);

                //PrepareDailyCheckLists(scope).Wait();
            }

            return Task.CompletedTask;
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            string log = "GBMS Sync Stopping";
            Console.WriteLine($"{DateTime.Now:hh:mm:ss} {log}");
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} {log}");
            return base.StopAsync(cancellationToken);
        }
        public Task SyncUsers(List<PayEmployeeMaster> users, IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            foreach (var item in users)
            {
                var user = (from u in context.GBMSUsers where u.XCode == item.XCode select u).FirstOrDefault();
                if (user == null)
                {
                    user = new GBMSUser()
                    {
                        AddDate = item.AddDate,
                        AddId = item.AddId,
                        IpAdd = item.IpAdd,
                        XAccountNumber = item.XAccountNumber,
                        XAddress = item.XAddress,
                        XAdvLimit = item.XAdvLimit,
                        Id = Guid.NewGuid(),
                        IpMod = item.IpMod,
                        LastSync = DateTime.UtcNow,
                        ModDate = item.ModDate,
                        ModId = item.ModId,
                        XBankName = item.XBankName,
                        XBankNameDescription = item.XBankNameDescription,
                        XBasicPay = item.XBasicPay,
                        XBloodGroup = item.XBloodGroup,
                        XCadre = item.XCadre,
                        XCadreDescription = item.XCadreDescription,
                        XCard = item.XCard,
                        XCategory = item.XCategory,
                        XCategoryDescription = item.XCategoryDescription,
                        XCity = item.XCity,
                        XCnic = item.XCnic,
                        XCode = item.XCode,
                        XContractDate = item.XContractDate,
                        XDateOfBirth = item.XDateOfBirth,
                        XDepartment = item.XDepartment,
                        XDepartmentDescription = item.XDepartmentDescription,
                        XDesignation = item.XDesignation,
                        XDesignationDescription = item.XDesignationDescription,
                        XEobi = item.XEobi,
                        XExpiryDate = item.XExpiryDate,
                        XFatherName = item.XFatherName,
                        XGender = item.XGender,
                        XGrade = item.XGrade,
                        XGradeDescription = item.XGradeDescription,
                        XGrossPay = item.XGrossPay,
                        XHusbandName = item.XHusbandName,
                        XJoiningDate = item.XJoiningDate,
                        XLocation = item.XLocation,
                        XLocationDescription = item.XLocationDescription,
                        XNa1 = item.XNa1,
                        XNa2 = item.XNa2,
                        XNa3 = item.XNa3,
                        XName = item.XName,
                        XNtn = item.XNtn,
                        XOfficialEmail = item.XOfficialEmail,
                        XOfficialMobile = item.XOfficialMobile,
                        XPayMode = item.XPayMode,
                        XPersonalEmail = item.XPersonalEmail,
                        XPersonalMobile = item.XPersonalMobile,
                        XProject = item.XProject,
                        XProjectDescription = item.XProjectDescription,
                        XReference1 = item.XReference1,
                        XReference2 = item.XReference2,
                        XReligion = item.XReligion,
                        XReligionDescription = item.XReligionDescription,
                        XRemarks = item.XRemarks,
                        XrowId = item.XrowId,
                        XSection = item.XSection,
                        XSectionDescription = item.XSectionDescription,
                        XShift = item.XShift,
                        XShiftDescription = item.XShiftDescription,
                        XSocialSecurity = item.XSocialSecurity,
                        XStatus = item.XStatus
                    };
                    context.GBMSUsers.Add(user);
                }
                else
                {
                    user.AddDate = item.AddDate;
                    user.AddId = item.AddId;
                    user.IpAdd = item.IpAdd;
                    user.XAccountNumber = item.XAccountNumber;
                    user.XAddress = item.XAddress;
                    user.XAdvLimit = item.XAdvLimit;
                    user.IpMod = item.IpMod;
                    user.LastSync = DateTime.UtcNow;
                    user.ModDate = item.ModDate;
                    user.ModId = item.ModId;
                    user.XBankName = item.XBankName;
                    user.XBankNameDescription = item.XBankNameDescription;
                    user.XBasicPay = item.XBasicPay;
                    user.XBloodGroup = item.XBloodGroup;
                    user.XCadre = item.XCadre;
                    user.XCadreDescription = item.XCadreDescription;
                    user.XCard = item.XCard;
                    user.XCategory = item.XCategory;
                    user.XCategoryDescription = item.XCategoryDescription;
                    user.XCity = item.XCity;
                    user.XCnic = item.XCnic;
                    user.XContractDate = item.XContractDate;
                    user.XDateOfBirth = item.XDateOfBirth;
                    user.XDepartment = item.XDepartment;
                    user.XDepartmentDescription = item.XDepartmentDescription;
                    user.XDesignation = item.XDesignation;
                    user.XDesignationDescription = item.XDesignationDescription;
                    user.XEobi = item.XEobi;
                    user.XExpiryDate = item.XExpiryDate;
                    user.XFatherName = item.XFatherName;
                    user.XGender = item.XGender;
                    user.XGrade = item.XGrade;
                    user.XGradeDescription = item.XGradeDescription;
                    user.XGrossPay = item.XGrossPay;
                    user.XHusbandName = item.XHusbandName;
                    user.XJoiningDate = item.XJoiningDate;
                    user.XLocation = item.XLocation;
                    user.XLocationDescription = item.XLocationDescription;
                    user.XNa1 = item.XNa1;
                    user.XNa2 = item.XNa2;
                    user.XNa3 = item.XNa3;
                    user.XName = item.XName;
                    user.XNtn = item.XNtn;
                    user.XOfficialEmail = item.XOfficialEmail;
                    user.XOfficialMobile = item.XOfficialMobile;
                    user.XPayMode = item.XPayMode;
                    user.XPersonalEmail = item.XPersonalEmail;
                    user.XPersonalMobile = item.XPersonalMobile;
                    user.XProject = item.XProject;
                    user.XProjectDescription = item.XProjectDescription;
                    user.XReference1 = item.XReference1;
                    user.XReference2 = item.XReference2;
                    user.XReligion = item.XReligion;
                    user.XReligionDescription = item.XReligionDescription;
                    user.XRemarks = item.XRemarks;
                    user.XrowId = item.XrowId;
                    user.XSection = item.XSection;
                    user.XSectionDescription = item.XSectionDescription;
                    user.XShift = item.XShift;
                    user.XShiftDescription = item.XShiftDescription;
                    user.XSocialSecurity = item.XSocialSecurity;
                    user.XStatus = item.XStatus;
                }
            }
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task SyncRegions(List<RbRegion> regions, IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            foreach (var item in regions)
            {
                var region = (from r in context.Regions where r.XAbbrevation == item.XAbbrevation select r).FirstOrDefault();
                if (region == null)
                {
                    region = new Region()
                    {
                        AddDate = item.AddDate,
                        AddId = item.AddId,
                        IpAdd = item.IpAdd,
                        XAbbrevation = item.XAbbrevation,
                        Id = Guid.NewGuid(),
                        IpMod = item.IpMod,
                        ModDate = item.ModDate,
                        ModId = item.ModId,
                        XCode = item.XCode,
                        XDescription = item.XDescription,
                        XRemarks = item.XRemarks,
                        XrowId = item.XrowId,
                        LastSync = DateTime.UtcNow
                    };
                    context.Regions.Add(region);
                }
                else
                {
                    region.AddDate = item.AddDate;
                    region.AddId = item.AddId;
                    region.IpAdd = item.IpAdd;
                    region.XAbbrevation = item.XAbbrevation;
                    region.IpMod = item.IpMod;
                    region.ModDate = item.ModDate;
                    region.ModId = item.ModId;
                    region.XDescription = item.XDescription;
                    region.XRemarks = item.XRemarks;
                    region.XrowId = item.XrowId;
                    region.LastSync = DateTime.UtcNow;
                }
            }
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task SyncSubRegions(List<RbSubRegion> subregions, IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            foreach (var item in subregions)
            {
                var subregion = (from s in context.SubRegions where s.XCode == item.XCode select s).FirstOrDefault();
                if (subregion == null)
                {
                    subregion = new SubRegion()
                    {
                        AddDate = item.AddDate,
                        AddId = item.AddId,
                        IpAdd = item.IpAdd,
                        XAbbrevation = item.XAbbrevation,
                        Id = Guid.NewGuid(),
                        IpMod = item.IpMod,
                        ModDate = item.ModDate,
                        ModId = item.ModId,
                        XCode = item.XCode,
                        XDescription = item.XDescription,
                        XRemarks = item.XRemarks,
                        XrowId = item.XrowId,
                        XRevenueAuthroity = item.XRevenueAuthroity,
                        XRevenueAuthroityDescription = item.XRevenueAuthroityDescription,
                        XRegion = item.XRegion,
                        XRegionDescription = item.XRegionDescription,
                        LastSync = DateTime.UtcNow
                    };
                    context.SubRegions.Add(subregion);
                }
                else
                {
                    subregion.AddDate = item.AddDate;
                    subregion.AddId = item.AddId;
                    subregion.IpAdd = item.IpAdd;
                    subregion.XAbbrevation = item.XAbbrevation;
                    subregion.IpMod = item.IpMod;
                    subregion.ModDate = item.ModDate;
                    subregion.ModId = item.ModId;
                    subregion.XDescription = item.XDescription;
                    subregion.XRemarks = item.XRemarks;
                    subregion.XrowId = item.XrowId;
                    subregion.XRevenueAuthroity = item.XRevenueAuthroity;
                    subregion.XRevenueAuthroityDescription = item.XRevenueAuthroityDescription;
                    subregion.XRegion = item.XRegion;
                    subregion.XRegionDescription = item.XRegionDescription;
                    subregion.LastSync = DateTime.UtcNow;
                }
            }
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task SyncVehicles(List<RbVehicle> vehicles, IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            foreach (var item in vehicles)
            {
                var vehicle = (from r in context.GBMSVehicles where r.Code == item.XCode select r).FirstOrDefault();
                if (vehicle == null)
                {
                    vehicle = new GBMSVehicle()
                    {
                        Id = Guid.NewGuid(),
                        Code = item.XCode,
                        Description = item.XDescription,
                        ChasisNo = item.XChasisNo,
                        EngineNo = item.XEngineNo,
                        GasolineType = item.XGasolineTypeDescription,
                        Location = item.XLocationDescription,
                        Make = item.XMake,
                        Model = item.XModel,
                        PurchaseDate = item.XPurchaseDate,
                        Station = item.XStationDescription,
                        VehicleType = item.XVehicleTypeDescription,
                        LastSync = DateTime.UtcNow
                    };
                    context.GBMSVehicles.Add(vehicle);
                }
                else
                {
                    vehicle.Description = item.XDescription;
                    vehicle.ChasisNo = item.XChasisNo;
                    vehicle.EngineNo = item.XEngineNo;
                    vehicle.GasolineType = item.XGasolineTypeDescription;
                    vehicle.Location = item.XLocationDescription;
                    vehicle.Make = item.XMake;
                    vehicle.Model = item.XModel;
                    vehicle.PurchaseDate = item.XPurchaseDate;
                    vehicle.Station = item.XStationDescription;
                    vehicle.VehicleType = item.XVehicleTypeDescription;
                }
            }
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task SyncVehicleTypes(List<RbVehicleType> vehicletypes, IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            foreach (var item in vehicletypes)
            {
                var vehicletype = (from r in context.VehicleTypes where r.XCode == item.XCode select r).FirstOrDefault();
                if (vehicletype == null)
                {
                    vehicletype = new VehicleType()
                    {
                        AddDate = item.AddDate,
                        AddId = item.AddId,
                        IpAdd = item.IpAdd,
                        Id = Guid.NewGuid(),
                        IpMod = item.IpMod,
                        ModDate = item.ModDate,
                        ModId = item.ModId,
                        XCode = item.XCode,
                        XDescription = item.XDescription,
                        XRemarks = item.XRemarks,
                        XrowId = item.XrowId,
                        XAbbreviation = item.XAbbreviation,
                        LastSync = DateTime.UtcNow
                    };
                    context.VehicleTypes.Add(vehicletype);
                }
                else
                {
                    vehicletype.AddDate = item.AddDate;
                    vehicletype.AddId = item.AddId;
                    vehicletype.IpAdd = item.IpAdd;
                    vehicletype.IpMod = item.IpMod;
                    vehicletype.ModDate = item.ModDate;
                    vehicletype.ModId = item.ModId;
                    vehicletype.XDescription = item.XDescription;
                    vehicletype.XRemarks = item.XRemarks;
                    vehicletype.XrowId = item.XrowId;
                    vehicletype.XAbbreviation = item.XAbbreviation;
                    vehicletype.LastSync = DateTime.UtcNow;
                }
            }
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task SyncZones(List<RbZone> zones, IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            foreach (var item in zones)
            {
                var zone = (from z in context.Zones where z.XCode == item.XCode select z).FirstOrDefault();
                if (zone == null)
                {
                    zone = new Zone()
                    {
                        AddDate = item.AddDate,
                        AddId = item.AddId,
                        IpAdd = item.IpAdd,
                        XAbbrevation = item.XAbbrevation,
                        Id = Guid.NewGuid(),
                        IpMod = item.IpMod,
                        ModDate = item.ModDate,
                        ModId = item.ModId,
                        XCode = item.XCode,
                        XDescription = item.XDescription,
                        XRemarks = item.XRemarks,
                        XrowId = item.XrowId,
                        XRegion = item.XRegion,
                        XRegionDescription = item.XRegionDescription,
                        LastSync = DateTime.UtcNow
                    };
                    context.Zones.Add(zone);
                }
                else
                {
                    zone.AddDate = item.AddDate;
                    zone.AddId = item.AddId;
                    zone.IpAdd = item.IpAdd;
                    zone.XAbbrevation = item.XAbbrevation;
                    zone.IpMod = item.IpMod;
                    zone.ModDate = item.ModDate;
                    zone.ModId = item.ModId;
                    zone.XDescription = item.XDescription;
                    zone.XRemarks = item.XRemarks;
                    zone.XrowId = item.XrowId;
                    zone.XRegion = item.XRegion;
                    zone.XRegionDescription = item.XRegionDescription;
                    zone.LastSync = DateTime.UtcNow;
                }
            }
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task SyncStations(List<RbStation> stations, IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            foreach (var item in stations)
            {
                var station = (from s in context.Stations where s.XCode == item.XCode select s).FirstOrDefault();
                if (station == null)
                {
                    station = new Station()
                    {
                        AddDate = item.AddDate,
                        AddId = item.AddId,
                        IpAdd = item.IpAdd,
                        XAbbrevation = item.XAbbrevation,
                        Id = Guid.NewGuid(),
                        IpMod = item.IpMod,
                        ModDate = item.ModDate,
                        ModId = item.ModId,
                        XCode = item.XCode,
                        XDescription = item.XDescription,
                        XRemarks = item.XRemarks,
                        XrowId = item.XrowId,
                        XVaultStatus = item.XVaultStatus,
                        LastSync = DateTime.UtcNow
                    };
                    context.Stations.Add(station);
                }
                else
                {
                    station.AddDate = item.AddDate;
                    station.AddId = item.AddId;
                    station.IpAdd = item.IpAdd;
                    station.XAbbrevation = item.XAbbrevation;
                    station.IpMod = item.IpMod;
                    station.ModDate = item.ModDate;
                    station.ModId = item.ModId;
                    station.XDescription = item.XDescription;
                    station.XRemarks = item.XRemarks;
                    station.XrowId = item.XrowId;
                    station.XVaultStatus = item.XVaultStatus;
                    station.LastSync = DateTime.UtcNow;
                }
            }
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task SyncDrivers(List<PdwEmployeeMaster> drivers, IServiceScope scope)
        {
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            foreach (var item in drivers)
            {
                var region = (from s in context.SubRegions where item.XLocationDescription.Contains(s.XDescription) select s.XRegionDescription).FirstOrDefault();
                var subregion = (from s in context.SubRegions where item.XLocationDescription.Contains(s.XDescription) select s.XDescription).FirstOrDefault();

                var driver = (from s in context.Drivers where s.Code == item.XCode select s).FirstOrDefault();

                if (driver == null)
                {
                    driver = new Driver()
                    {
                        Id = Guid.NewGuid(),
                        Name = item.XName,
                        Code = item.XCode,
                        Absents = 0,
                        Accidents = 0,
                        Emergencies = 0,
                        Points = 0,
                        Trips = 0,
                        VehicleNumber = "",
                        Region = region,
                        SubRegion = subregion,
                        Ranking = 0,
                        Violations = 0,
                        LastSync = PakistanDateTime.Now,
                        Score = 100
                    };
                    context.Drivers.Add(driver);
                }
                else
                {
                    driver.Name = item.XName;
                    driver.Region = region;
                    driver.SubRegion = subregion;
                    driver.LastSync = PakistanDateTime.Now;
                }
            }
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public async Task PrepareDailyCheckLists(IServiceScope scope)
        {
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            List<string> vehicleNumbers = (from v in dbContext.Vehicles
                                           join gv in dbContext.GBMSVehicles on v.VehicleNumber equals gv.Description
                                           select gv.Description).ToList();
            foreach (var vehicleNumber in vehicleNumbers)
            {
                Vehicle vehicle = (from f in dbContext.Vehicles
                                         join v in dbContext.GBMSVehicles on f.VehicleNumber equals v.Description
                                         where v.Description == vehicleNumber
                                         select f).SingleOrDefault();
                Region region = (from r in dbContext.Regions
                                 where r.XDescription == vehicle.Region
                                 select r).SingleOrDefault();
                SubRegion subRegion = (from s in dbContext.SubRegions
                                       where s.XDescription == vehicle.SubRegion
                                       select s).SingleOrDefault();
                string DriverName = (from d in dbContext.Drivers 
                                     where d.VehicleNumber == vehicleNumber
                                     select d.Name).SingleOrDefault();
                IEnumerable<DailyMorning> fMSDailyMornings = from m in dbContext.DailyMorningChecks where m.VehicleNumber == vehicleNumber && m.LastUpdated.Date == (PakistanDateTime.Today) select m;
                if (!fMSDailyMornings.Any())
                {
                    DailyMorning dailyMorning = new();
                    dailyMorning.Id = Guid.NewGuid();
                    dailyMorning.LastUpdated = PakistanDateTime.Now;
                    dailyMorning.VehicleNumber = vehicleNumber;
                    dailyMorning.DriverName = DriverName;
                    dailyMorning.Region = region.XDescription;
                    dailyMorning.Subregion = subRegion.XDescription;
                    await dbContext.DailyMorningChecks.AddAsync(dailyMorning);
                    await dbContext.SaveChangesAsync();
                }
                IEnumerable<DailyEvening> fMSDailyEvenings = from e in dbContext.DailyEveningChecks where e.VehicleNumber == vehicleNumber && e.LastUpdated.Date == (PakistanDateTime.Today) select e;
                if (!fMSDailyEvenings.Any())
                {
                    DailyEvening dailyEvening = new();
                    dailyEvening.Id = Guid.NewGuid();
                    dailyEvening.LastUpdated = PakistanDateTime.Now;
                    dailyEvening.VehicleNumber = vehicleNumber;
                    dailyEvening.DriverName = DriverName;
                    dailyEvening.Region = region.XDescription;
                    dailyEvening.Subregion = subRegion.XDescription;
                    await dbContext.DailyEveningChecks.AddAsync(dailyEvening);
                    await dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
