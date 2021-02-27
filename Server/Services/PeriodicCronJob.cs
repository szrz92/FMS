using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SOS.FMS.Server.Models;
using SOS.FMS.Shared;
using SOS.FMS.Shared.Enums;
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
        IServiceScopeFactory _serviceScope;

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
                    var configDetails = (from p in dbContext.PeriodicHistories
                                         join c in dbContext.VehicleConfigurations on p.ConfigurationId equals c.Id
                                         select new
                                         {
                                             Id = p.Id,
                                             VehicleNumber = p.VehicleNumber,

                                             CurrentKMS = v.Distance - p.LastCheckDistance,
                                             KMSLimit = c.Distance,

                                             CurrentMonth = GetMonthsBetween(PakistanDateTime.Now, p.LastCheckTime),
                                             MonthLimit = c.Month

                                         }).ToList();

                    List<PeriodicMaintenanceStatus> statusList = new List<PeriodicMaintenanceStatus>();

                    foreach (var c in configDetails)
                    {
                        if (c.CurrentMonth > c.MonthLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }
                        else if (c.CurrentMonth < c.MonthLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Done);
                        }
                        else if (c.CurrentMonth == c.MonthLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }

                        if (c.CurrentKMS > c.KMSLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }
                        else if (c.CurrentKMS < c.KMSLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Done);
                        }
                        else if (c.CurrentKMS == c.KMSLimit)
                        {
                            statusList.Add(PeriodicMaintenanceStatus.Pending);
                        }
                    }

                    if (statusList.Contains(PeriodicMaintenanceStatus.Pending))
                    {
                        v.PeriodicStatus = PeriodicMaintenanceStatus.Pending;
                    }
                    else
                    {
                        v.PeriodicStatus = PeriodicMaintenanceStatus.Done;
                    }
                }
                dbContext.SaveChanges();
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
    }
}
