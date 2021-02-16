using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SOS.FMS.Server.GBMSModels;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public class GbmsSyncService
    {
        private readonly IServiceScopeFactory serviceScopeFactory;

        public GbmsSyncService(IServiceScopeFactory serviceScopeFactory)
        {
            this.serviceScopeFactory = serviceScopeFactory;
        }

        public void StartSyncing()
        {
            DateTime? lastTimeStamp = null;
            //Task.Run(async () =>
            //{
            //    //await Task.Delay(TimeSpan.FromMinutes(100));
            //    while (true)
            //    {
            //        try
            //        {

            //            using (var scope = serviceScopeFactory.CreateScope())
            //            {

            //                var assetService = scope.ServiceProvider.GetRequiredService<AssetsService>();
            //                var gbms = scope.ServiceProvider.GetRequiredService<SOS_VIEWSContext>();
            //                var serviceCharges = gbms.RbServiceCharges.ToList();
            //                DateTime startTime = MyDateTime.Now;

            //                //var cache = scope.ServiceProvider.GetRequiredService<IDistributedCache>();
            //                //cache.SetString("__", "abc");
            //                #region Locations

            //                var pdwEmployeeData = await gbms.PdwEmployeeMaster.Where(x => lastTimeStamp == null || (x.AddDate >= lastTimeStamp || x.ModDate >= lastTimeStamp)).ToArrayAsync();
            //                //logger.Information($"PDWEMPLOYEEMASTER => {pdwEmployeeData.Length}");
            //                await UpdatePdwEmployees(pdwEmployeeData, scope, EmploymentType.Gaurd);
            //                //logger.Information("PDWEMPLOYEEMASTER completed");

            //                var regions = await gbms.RbRegion
            //                .Where(x => lastTimeStamp == null || (x.AddDate >= lastTimeStamp || x.ModDate >= lastTimeStamp)).ToArrayAsync();
            //                await UpdateRegions(regions, scope, OrganizationType.RegionalControlCenter);
            //                //logger.Information("RBREGION");

            //                var subRegions = await gbms.RbSubRegions.Where(x => lastTimeStamp == null || (x.AddDate >= lastTimeStamp || x.ModDate >= lastTimeStamp)).ToArrayAsync();
            //                await UpdateSubRegions(subRegions, scope, OrganizationType.SubRegionalControlStation);
            //                //logger.Information("RBSUBREGIONS");

            //                var stations = await gbms.RbStations.Where(x => lastTimeStamp == null || (x.AddDate >= lastTimeStamp || x.ModDate >= lastTimeStamp)).ToArrayAsync();
            //                await UpdateStations(stations, scope, OrganizationType.Station);
            //                //logger.Information("RBSTATIONS");

            //                var subRegionStationsData = await gbms.RbSubRegionsStations.Where(x => lastTimeStamp == null || (x.AddDate >= lastTimeStamp || x.ModDate >= lastTimeStamp)).ToArrayAsync();
            //                await BuildRelationships(subRegionStationsData, scope);
            //                //logger.Information("RBSUBREGIONSSTATIONS");


            //                #endregion

            //                var vehicles = await gbms.RbVehicles.Where(x => lastTimeStamp == null || (x.AddDate >= lastTimeStamp || x.ModDate >= lastTimeStamp)).ToArrayAsync();
            //                await UpdateVehicles(vehicles, assetService);
            //                //logger.Information("RBVEHICLES");
            //                lastTimeStamp = startTime;
            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            //  telemetry.TrackException(ex);
            //            //logger.Error(ex.ToString());
            //        }
            //        //logger.Information("Waiting...");
            //        await Task.Delay(TimeSpan.FromMinutes(5));
            //    }
            //});
        }

    }
}
