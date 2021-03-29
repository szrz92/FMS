using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Enums;
using SOS.FMS.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Services
{
    public class PeriodicCronJob: CronJobService
    {
        private readonly ILogger<PeriodicCronJob> _logger;
        readonly IServiceScopeFactory _serviceScope;

        public PeriodicCronJob(IScheduleConfig<PeriodicCronJob> config, ILogger<PeriodicCronJob> logger, IServiceScopeFactory serviceScope)
            : base(config.CronExpression, config.TimeZoneInfo)
        {
            _serviceScope = serviceScope;
            _logger = logger;

        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            string log = "Periodic Check Started";
            Console.WriteLine($"{DateTime.Now:hh:mm:ss} {log}");
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} {log}");
            return base.StartAsync(cancellationToken);
        }
        public override Task DoWork(CancellationToken cancellationToken)
        {
            string log = "Periodic Check from cron job";
            Console.WriteLine($"{DateTime.Now:hh:mm:ss} {log}");
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} {log}");

            using (var scope = _serviceScope.CreateScope()) // this will use `IServiceScopeFactory` internally
            {
                var dbContext = scope.ServiceProvider.GetService<AppDbContext>();

                var vehicles = from v in dbContext.Vehicles select v;

                foreach (var v in vehicles)
                {
                    GetLastStatus(new ApiRequest() { VehicleNumber = v.VehicleNumber }, scope);
                }
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
        public static int GetMonthsBetween(DateTime from, DateTime to)
        {
            if (from > to) return GetMonthsBetween(to, from);

            var monthDiff = Math.Abs((to.Year * 12 + (to.Month - 1)) - (from.Year * 12 + (from.Month - 1)));

            if (from.AddMonths(monthDiff) > to || to.Day < from.Day)
            {
                return monthDiff - 1;
            }
            else
            {
                return monthDiff;
            }
        }

        public void GetLastStatus(ApiRequest request, IServiceScope scope)
        {
            List<PeriodicHistory> histories;
            List<PeriodicVM> periodicHistory = new();
            try
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                Vehicle vehicle = (from v in dbContext.Vehicles where v.VehicleNumber == request.VehicleNumber select v).SingleOrDefault();
                Driver driver = (from v in dbContext.Drivers where v.VehicleNumber == request.VehicleNumber select v).SingleOrDefault();
                List<VehicleConfiguration> configurations = (from v in dbContext.VehicleConfigurations select v).ToList();

                histories = (from p in dbContext.PeriodicHistories
                             where p.VehicleNumber == request.VehicleNumber
                             select p).ToList();

                if (histories.Any())
                {
                    foreach (var c in configurations)
                    {
                        var history = histories.Where(x => x.Description == c.Description).OrderByDescending(x => x.Timestamp)
                            .Select(h => new PeriodicVM()
                            {
                                Id = h.Id,
                                ConfigurationId = h.ConfigurationId,
                                Description = h.Description,
                                CurrentDistance = vehicle.Distance,
                                CurrentMonth = PakistanDateTime.GetMonthsBetween(DateTime.Now, h.LastCheckTime),
                                DistanceLimit = c.Distance,
                                DriverCode = driver.Code,
                                DriverName = driver.Name,
                                LastCheckDistance = h.LastCheckDistance,
                                LastCheckTime = h.LastCheckTime,
                                MonthLimit = c.Month,
                                VehicleNumber = vehicle.VehicleNumber,
                                Region = driver.Region,
                                SubRegion = driver.SubRegion
                            }).FirstOrDefault();
                        periodicHistory.Add(history);
                    }
                    foreach (var p in periodicHistory)
                    {
                        double CurrentKMS = vehicle.Distance - p.LastCheckDistance;
                        int CurrentMonths = PakistanDateTime.GetMonthsBetween(PakistanDateTime.Now, p.LastCheckTime);

                        List<PeriodicMaintenanceStatus> statusList = new();

                        if (CurrentMonths > p.MonthLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }
                        else if (CurrentMonths < p.MonthLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Done);
                        }
                        else if (CurrentMonths == p.MonthLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }

                        if (CurrentKMS > p.DistanceLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }
                        else if (CurrentKMS < p.DistanceLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Done);
                        }
                        else if (CurrentKMS == p.DistanceLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }

                        if (statusList.Contains(PeriodicMaintenanceStatus.Pending))
                        {
                            vehicle.PeriodicStatus = PeriodicMaintenanceStatus.Pending;
                        }
                        else
                        {
                            vehicle.PeriodicStatus = PeriodicMaintenanceStatus.Done;
                            if (vehicle.AccidentalStatus == AccidentalMaintenanceStatus.Pending)
                            {
                                vehicle.Status = "accidental";
                            }
                            else
                                if (vehicle.EmergencyStatus == EmergencyMaintenanceStatus.Pending)
                            {
                                vehicle.Status = "emergency";
                            }
                            else
                            {
                                vehicle.Status = "maintained";
                            }
                        }

                        dbContext.SaveChanges();
                    }
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
             
            }
        }
    }
}
