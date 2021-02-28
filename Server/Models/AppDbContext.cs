using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SOS.FMS.Shared.ViewModels;
using SOS.FMS.Shared.ViewModels.Accident;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Region> Regions { get; set; }
        public DbSet<RegionalOffice> RegionalOffices { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<SubRegion> SubRegions { get; set; }
        public DbSet<GBMSVehicle> GBMSVehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<VehicleSummary> VehicleSummaries { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleConfiguration> VehicleConfigurations { get; set; }
        public DbSet<FMSVehicleAccident> FMSVehicleAccidents { get; set; }
        public DbSet<FMSVehicleScoreCard> FMSVehicleScoreCards { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<GBMSUser> GBMSUsers { get; set; }
        public DbSet<FMSAccident> FMSAccidents { get; set; }
        public DbSet<FMSAccidentalCheck> FMSAccidentalCheckList { get; set; }
        public DbSet<FMSAccidentalCheckComment> FMSAccidentalCheckComments { get; set; }
        public DbSet<FMSAccidentalCheckImage> FMSAccidentalCheckImages { get; set; }
        public DbSet<FMSEmergency> FMSEmergencies { get; set; }
        public DbSet<FMSEmergencyCheck> FMSEmergencyCheckList { get; set; }
        public DbSet<FMSEmergencyCheckComment> FMSEmergencyCheckComments { get; set; }
        public DbSet<FMSEmergencyCheckImage> FMSEmergencyCheckImages { get; set; }
        public DbSet<FMSDailyMorning> FMSDailyMorningChecks { get; set; }
        public DbSet<FMSDailyEvening> FMSDailyEveningChecks { get; set; }
        public DbSet<PeriodicHistory> PeriodicHistories { get; set; }

        public DbSet<AccidentBill> AccidentBills{ get; set; }
        public DbSet<EmergencyBill> EmergencyBills { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole() { Id = "SA", Name = "SA", NormalizedName = "SA", ConcurrencyStamp = null }, //Super Admin
                new IdentityRole() { Id = "HMT", Name = "HMT", NormalizedName = "HMT", ConcurrencyStamp = null }, //Head Of MT
                new IdentityRole() { Id = "MTAM", Name = "MTAM", NormalizedName = "MTAM", ConcurrencyStamp = null }, //MT Accounts Manager
                new IdentityRole() { Id = "CIM", Name = "CIM", NormalizedName = "CIM", ConcurrencyStamp = null }, //Coordinator Emergency , Routine / Accidental maintenance
                new IdentityRole() { Id = "CPM", Name = "CPM", NormalizedName = "CPM", ConcurrencyStamp = null }, //Coordinator Periodic Maintenance
                new IdentityRole() { Id = "RMTO", Name = "RMTO", NormalizedName = "RMTO", ConcurrencyStamp = null }, //Regional MTO
                new IdentityRole() { Id = "RAO", Name = "RAO", NormalizedName = "RAO", ConcurrencyStamp = null } //Regional Accounts Officer
                );

            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<ApplicationUser>();


            //Seeding the User to AspNetUsers table
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "c58e1a9d-1c28-46db-830a-7b3f0b9663f1", // primary key
                    UserName = "z.raza@batech.com.pk",
                    NormalizedUserName = "z.raza@batech.com.pk".ToUpper(),
                    Email = "z.raza@batech.com.pk",
                    NormalizedEmail = "z.raza@batech.com.pk".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Sa123!@#"),
                    PhoneNumber = null,
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0,
                    Name = "Zain Raza"
                }
            );


            ////Seeding the relation between our user and role to AspNetUserRoles table
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "SA",
                    UserId = "c58e1a9d-1c28-46db-830a-7b3f0b9663f1"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
