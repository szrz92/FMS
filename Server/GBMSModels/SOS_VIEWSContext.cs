﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class SOS_VIEWSContext : DbContext
    {
        public SOS_VIEWSContext()
        {
        }

        public SOS_VIEWSContext(DbContextOptions<SOS_VIEWSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dbview> Dbviews { get; set; }
        public virtual DbSet<PayBankCode> PayBankCodes { get; set; }
        public virtual DbSet<PayCadre> PayCadres { get; set; }
        public virtual DbSet<PayCategory> PayCategories { get; set; }
        public virtual DbSet<PayDepartment> PayDepartments { get; set; }
        public virtual DbSet<PayDesignation> PayDesignations { get; set; }
        public virtual DbSet<PayEmployeeMaster> PayEmployeeMasters { get; set; }
        public virtual DbSet<PayEmployeePic> PayEmployeePics { get; set; }
        public virtual DbSet<PayGrade> PayGrades { get; set; }
        public virtual DbSet<PayLeaveCode> PayLeaveCodes { get; set; }
        public virtual DbSet<PayReligion> PayReligions { get; set; }
        public virtual DbSet<PayShift> PayShifts { get; set; }
        public virtual DbSet<PdwAllowance> PdwAllowances { get; set; }
        public virtual DbSet<PdwAllowancesToggle> PdwAllowancesToggles { get; set; }
        public virtual DbSet<PdwBankCode> PdwBankCodes { get; set; }
        public virtual DbSet<PdwCadre> PdwCadres { get; set; }
        public virtual DbSet<PdwCategory> PdwCategories { get; set; }
        public virtual DbSet<PdwCommentType> PdwCommentTypes { get; set; }
        public virtual DbSet<PdwDeduction> PdwDeductions { get; set; }
        public virtual DbSet<PdwDeductionsToggle> PdwDeductionsToggles { get; set; }
        public virtual DbSet<PdwDepartment> PdwDepartments { get; set; }
        public virtual DbSet<PdwDesignation> PdwDesignations { get; set; }
        public virtual DbSet<PdwEmployeeMaster> PdwEmployeeMasters { get; set; }
        public virtual DbSet<PdwEmployeeMasterAllowance> PdwEmployeeMasterAllowances { get; set; }
        public virtual DbSet<PdwEmployeeMasterComment> PdwEmployeeMasterComments { get; set; }
        public virtual DbSet<PdwEmployeeMasterDeduction> PdwEmployeeMasterDeductions { get; set; }
        public virtual DbSet<PdwEmployeeMasterLoan> PdwEmployeeMasterLoans { get; set; }
        public virtual DbSet<PdwEmployeeMasterSubProject> PdwEmployeeMasterSubProjects { get; set; }
        public virtual DbSet<PdwEmployeePic> PdwEmployeePics { get; set; }
        public virtual DbSet<PdwGrade> PdwGrades { get; set; }
        public virtual DbSet<PdwGradesAllowance> PdwGradesAllowances { get; set; }
        public virtual DbSet<PdwGradesDeduction> PdwGradesDeductions { get; set; }
        public virtual DbSet<PdwLeaveCode> PdwLeaveCodes { get; set; }
        public virtual DbSet<PdwLoan> PdwLoans { get; set; }
        public virtual DbSet<PdwLocation> PdwLocations { get; set; }
        public virtual DbSet<PdwOutlet> PdwOutlets { get; set; }
        public virtual DbSet<PdwProject> PdwProjects { get; set; }
        public virtual DbSet<PdwReligion> PdwReligions { get; set; }
        public virtual DbSet<PdwShift> PdwShifts { get; set; }
        public virtual DbSet<PdwSubProject> PdwSubProjects { get; set; }
        public virtual DbSet<RbArea> RbAreas { get; set; }
        public virtual DbSet<RbAtmServiceCharge> RbAtmServiceCharges { get; set; }
        public virtual DbSet<RbAtmServiceChargesCalculationRule> RbAtmServiceChargesCalculationRules { get; set; }
        public virtual DbSet<RbAtmServiceChargesChargesRule> RbAtmServiceChargesChargesRules { get; set; }
        public virtual DbSet<RbAtmServiceType> RbAtmServiceTypes { get; set; }
        public virtual DbSet<RbAtmServiceTypesContactPerson> RbAtmServiceTypesContactPeople { get; set; }
        public virtual DbSet<RbBranchManagement> RbBranchManagements { get; set; }
        public virtual DbSet<RbCitShipment> RbCitShipments { get; set; }
        public virtual DbSet<RbCitShipmentForeignCurrency> RbCitShipmentForeignCurrencies { get; set; }
        public virtual DbSet<RbCitShipmentSealsDetail> RbCitShipmentSealsDetails { get; set; }
        public virtual DbSet<RbCity> RbCities { get; set; }
        public virtual DbSet<RbCreditNoteReason> RbCreditNoteReasons { get; set; }
        public virtual DbSet<RbCustomerManagement> RbCustomerManagements { get; set; }
        public virtual DbSet<RbCustomerManagementContactPerson> RbCustomerManagementContactPeople { get; set; }
        public virtual DbSet<RbCustomerType> RbCustomerTypes { get; set; }
        public virtual DbSet<RbDebitNoteReason> RbDebitNoteReasons { get; set; }
        public virtual DbSet<RbDoubleRateTiming> RbDoubleRateTimings { get; set; }
        public virtual DbSet<RbDoubleRateTimingsCitRule> RbDoubleRateTimingsCitRules { get; set; }
        public virtual DbSet<RbDoubleRateTimingsTimingException> RbDoubleRateTimingsTimingExceptions { get; set; }
        public virtual DbSet<RbFeature> RbFeatures { get; set; }
        public virtual DbSet<RbGuardingContract> RbGuardingContracts { get; set; }
        public virtual DbSet<RbGuardingContractGuardCostRate> RbGuardingContractGuardCostRates { get; set; }
        public virtual DbSet<RbGuardingContractGuardingInvoiceRate> RbGuardingContractGuardingInvoiceRates { get; set; }
        public virtual DbSet<RbGuardingContractWeapon> RbGuardingContractWeapons { get; set; }
        public virtual DbSet<RbIndustryType> RbIndustryTypes { get; set; }
        public virtual DbSet<RbIntegrationDocumentsManagement> RbIntegrationDocumentsManagements { get; set; }
        public virtual DbSet<RbIntegrationDocumentsManagementGlAccountCode> RbIntegrationDocumentsManagementGlAccountCodes { get; set; }
        public virtual DbSet<RbMainCustomerManagement> RbMainCustomerManagements { get; set; }
        public virtual DbSet<RbMainCustomerManagementAtmTripRatesMapping> RbMainCustomerManagementAtmTripRatesMappings { get; set; }
        public virtual DbSet<RbMainCustomerManagementBranch> RbMainCustomerManagementBranches { get; set; }
        public virtual DbSet<RbMainCustomerManagementBranchFeature> RbMainCustomerManagementBranchFeatures { get; set; }
        public virtual DbSet<RbMainCustomerManagementCitBranchRate> RbMainCustomerManagementCitBranchRates { get; set; }
        public virtual DbSet<RbMainCustomerManagementCitDedicatedVehicle> RbMainCustomerManagementCitDedicatedVehicles { get; set; }
        public virtual DbSet<RbMainCustomerManagementCitRatesMapping> RbMainCustomerManagementCitRatesMappings { get; set; }
        public virtual DbSet<RbMainCustomerManagementContactPerson> RbMainCustomerManagementContactPeople { get; set; }
        public virtual DbSet<RbMainCustomerManagementFeatureCode> RbMainCustomerManagementFeatureCodes { get; set; }
        public virtual DbSet<RbMainCustomerManagementFeatureDetail> RbMainCustomerManagementFeatureDetails { get; set; }
        public virtual DbSet<RbMainCustomerManagementVehcileDetail> RbMainCustomerManagementVehcileDetails { get; set; }
        public virtual DbSet<RbMainCustomerManagementVehicleDetail> RbMainCustomerManagementVehicleDetails { get; set; }
        public virtual DbSet<RbOrderStatus> RbOrderStatuses { get; set; }
        public virtual DbSet<RbOrderType> RbOrderTypes { get; set; }
        public virtual DbSet<RbPaymentTermTemplate> RbPaymentTermTemplates { get; set; }
        public virtual DbSet<RbPaymentTermTemplatesPaymentTerm> RbPaymentTermTemplatesPaymentTerms { get; set; }
        public virtual DbSet<RbProductClassification> RbProductClassifications { get; set; }
        public virtual DbSet<RbProductClassificationCostLink> RbProductClassificationCostLinks { get; set; }
        public virtual DbSet<RbProjectNature> RbProjectNatures { get; set; }
        public virtual DbSet<RbRegion> RbRegions { get; set; }
        public virtual DbSet<RbRegionalOffice> RbRegionalOffices { get; set; }
        public virtual DbSet<RbRevenueAuthority> RbRevenueAuthorities { get; set; }
        public virtual DbSet<RbRevenueAuthorityTaxCode> RbRevenueAuthorityTaxCodes { get; set; }
        public virtual DbSet<RbRevenueNature> RbRevenueNatures { get; set; }
        public virtual DbSet<RbService> RbServices { get; set; }
        public virtual DbSet<RbServiceCharge> RbServiceCharges { get; set; }
        public virtual DbSet<RbServiceChargesBaseChargesRule> RbServiceChargesBaseChargesRules { get; set; }
        public virtual DbSet<RbServiceChargesCalculationRule> RbServiceChargesCalculationRules { get; set; }
        public virtual DbSet<RbServiceChargesChargesRule> RbServiceChargesChargesRules { get; set; }
        public virtual DbSet<RbServicesAccountCode> RbServicesAccountCodes { get; set; }
        public virtual DbSet<RbShipmentType> RbShipmentTypes { get; set; }
        public virtual DbSet<RbShipmentTypesContactPerson> RbShipmentTypesContactPeople { get; set; }
        public virtual DbSet<RbStation> RbStations { get; set; }
        public virtual DbSet<RbSubRegion> RbSubRegions { get; set; }
        public virtual DbSet<RbSubRegionsStation> RbSubRegionsStations { get; set; }
        public virtual DbSet<RbSupplierManagementContactPerson> RbSupplierManagementContactPeople { get; set; }
        public virtual DbSet<RbUnitOfMeasurement> RbUnitOfMeasurements { get; set; }
        public virtual DbSet<RbVehicle> RbVehicles { get; set; }
        public virtual DbSet<RbVehicleType> RbVehicleTypes { get; set; }
        public virtual DbSet<RbWarehouse> RbWarehouses { get; set; }
        public virtual DbSet<RbWeaponType> RbWeaponTypes { get; set; }
        public virtual DbSet<RbZone> RbZones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=104.215.144.226,1433;Initial Catalog=SOS_VIEWS;User Id=cit; password=ijnIJN999(((; MultipleActiveResultSets=true;Connection Timeout=3200;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dbview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("dbviews");

                entity.Property(e => e.Collation)
                    .HasMaxLength(128)
                    .HasColumnName("collation");

                entity.Property(e => e.Colm)
                    .HasMaxLength(128)
                    .HasColumnName("colm");

                entity.Property(e => e.Colorder).HasColumnName("colorder");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isnullable).HasColumnName("isnullable");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Prec).HasColumnName("prec");

                entity.Property(e => e.Scale).HasColumnName("scale");

                entity.Property(e => e.Tbl)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("tbl");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<PayBankCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_BANK_CODES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XAccountNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_NUMBER");

                entity.Property(e => e.XBankName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BANK_NAME");

                entity.Property(e => e.XBranchName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_NAME");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PayCadre>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_CADRE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PayCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_CATEGORY");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PayDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_DEPARTMENTS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XExpenseType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_EXPENSE_TYPE");

                entity.Property(e => e.XExpenseTypeDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_EXPENSE_TYPE_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PayDesignation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_DESIGNATIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PayEmployeeMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_EMPLOYEE_MASTER");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAccountNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_NUMBER");

                entity.Property(e => e.XAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS");

                entity.Property(e => e.XAdvLimit)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_ADV_LIMIT");

                entity.Property(e => e.XBankName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_BANK_NAME");

                entity.Property(e => e.XBankNameDescription)
                    .HasMaxLength(503)
                    .IsUnicode(false)
                    .HasColumnName("X_BANK_NAME_DESCRIPTION");

                entity.Property(e => e.XBasicPay)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("X_BASIC_PAY");

                entity.Property(e => e.XBloodGroup)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BLOOD_GROUP");

                entity.Property(e => e.XCadre)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CADRE");

                entity.Property(e => e.XCadreDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CADRE_DESCRIPTION");

                entity.Property(e => e.XCard)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CARD");

                entity.Property(e => e.XCategory)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CATEGORY");

                entity.Property(e => e.XCategoryDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CATEGORY_DESCRIPTION");

                entity.Property(e => e.XCity)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CITY");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XContractDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_CONTRACT_DATE");

                entity.Property(e => e.XDateOfBirth)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_DATE_OF_BIRTH");

                entity.Property(e => e.XDepartment)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DEPARTMENT");

                entity.Property(e => e.XDepartmentDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DEPARTMENT_DESCRIPTION");

                entity.Property(e => e.XDesignation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DESIGNATION");

                entity.Property(e => e.XDesignationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESIGNATION_DESCRIPTION");

                entity.Property(e => e.XEobi)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EOBI");

                entity.Property(e => e.XExpiryDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_EXPIRY_DATE");

                entity.Property(e => e.XFatherName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FATHER_NAME");

                entity.Property(e => e.XGender)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_GENDER");

                entity.Property(e => e.XGrade)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_GRADE");

                entity.Property(e => e.XGradeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_GRADE_DESCRIPTION");

                entity.Property(e => e.XGrossPay)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("X_GROSS_PAY");

                entity.Property(e => e.XHusbandName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_HUSBAND_NAME");

                entity.Property(e => e.XJoiningDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_JOINING_DATE");

                entity.Property(e => e.XLocation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_LOCATION");

                entity.Property(e => e.XLocationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LOCATION_DESCRIPTION");

                entity.Property(e => e.XNa1)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_NA_1");

                entity.Property(e => e.XNa2)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_NA_2");

                entity.Property(e => e.XNa3)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_NA_3");

                entity.Property(e => e.XName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XNtn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NTN");

                entity.Property(e => e.XOfficialEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_OFFICIAL_EMAIL");

                entity.Property(e => e.XOfficialMobile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_OFFICIAL_MOBILE");

                entity.Property(e => e.XPayMode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_PAY_MODE");

                entity.Property(e => e.XPersonalEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PERSONAL_EMAIL");

                entity.Property(e => e.XPersonalMobile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PERSONAL_MOBILE");

                entity.Property(e => e.XProject)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_PROJECT");

                entity.Property(e => e.XProjectDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PROJECT_DESCRIPTION");

                entity.Property(e => e.XReference1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REFERENCE___1");

                entity.Property(e => e.XReference2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REFERENCE___2");

                entity.Property(e => e.XReligion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_RELIGION");

                entity.Property(e => e.XReligionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_RELIGION_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSection)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SECTION");

                entity.Property(e => e.XSectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SECTION_DESCRIPTION");

                entity.Property(e => e.XShift)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIFT");

                entity.Property(e => e.XShiftDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIFT_DESCRIPTION");

                entity.Property(e => e.XSocialSecurity)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SOCIAL_SECURITY");

                entity.Property(e => e.XStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PayEmployeePic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_EMPLOYEE_PIC");

                entity.Property(e => e.XEmployee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("X_EMPLOYEE");

                entity.Property(e => e.XPicLink)
                    .HasMaxLength(1352)
                    .HasColumnName("X_PIC_LINK");
            });

            modelBuilder.Entity<PayGrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_GRADES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XIncrement)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_INCREMENT");

                entity.Property(e => e.XMaximum)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MAXIMUM");

                entity.Property(e => e.XMinimum)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MINIMUM");

                entity.Property(e => e.XPayScale)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PAY_SCALE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStages)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_STAGES");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PayLeaveCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_LEAVE_CODES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XLeaveType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_LEAVE_TYPE");

                entity.Property(e => e.XLeaveTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_LEAVE_TYPE_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PayReligion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_RELIGION");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PayShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PAY_SHIFTS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_ALLOWANCES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XHeading1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_HEADING___1");

                entity.Property(e => e.XHeading2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_HEADING___2");

                entity.Property(e => e.XHeading3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_HEADING___3");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XTaxable)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TAXABLE");

                entity.Property(e => e.XTaxableDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_TAXABLE_DESCRIPTION");

                entity.Property(e => e.XType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TYPE");

                entity.Property(e => e.XTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_TYPE_DESCRIPTION");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwAllowancesToggle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_ALLOWANCES_TOGGLES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT");

                entity.Property(e => e.XAttendanceFactor)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ATTENDANCE_FACTOR");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XExpiryDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_EXPIRY_DATE");

                entity.Property(e => e.XFormula)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_FORMULA");

                entity.Property(e => e.XMaximum)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MAXIMUM");

                entity.Property(e => e.XMinimum)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MINIMUM");

                entity.Property(e => e.XPercent)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_PERCENT");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XShortHeading)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SHORT_HEADING");

                entity.Property(e => e.XTaxable)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TAXABLE");

                entity.Property(e => e.XToggleCode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_CODE");

                entity.Property(e => e.XType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TYPE");
            });

            modelBuilder.Entity<PdwBankCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_BANK_CODES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XAccountNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_NUMBER");

                entity.Property(e => e.XBankName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BANK_NAME");

                entity.Property(e => e.XBranchName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_NAME");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwCadre>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_CADRE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_CATEGORY");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwCommentType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_COMMENT_TYPES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_DEDUCTIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XHeading1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_HEADING___1");

                entity.Property(e => e.XHeading2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_HEADING___2");

                entity.Property(e => e.XHeading3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_HEADING___3");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XTaxable)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TAXABLE");

                entity.Property(e => e.XTaxableDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_TAXABLE_DESCRIPTION");

                entity.Property(e => e.XType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TYPE");

                entity.Property(e => e.XTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_TYPE_DESCRIPTION");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwDeductionsToggle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_DEDUCTIONS_TOGGLES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT");

                entity.Property(e => e.XAttendanceFactor)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ATTENDANCE_FACTOR");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XExpiryDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_EXPIRY_DATE");

                entity.Property(e => e.XFormula)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_FORMULA");

                entity.Property(e => e.XMaximum)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MAXIMUM");

                entity.Property(e => e.XMinimum)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MINIMUM");

                entity.Property(e => e.XPercent)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_PERCENT");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XShortHeading)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SHORT_HEADING");

                entity.Property(e => e.XTaxable)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TAXABLE");

                entity.Property(e => e.XToggleCode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_CODE");

                entity.Property(e => e.XType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TYPE");
            });

            modelBuilder.Entity<PdwDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_DEPARTMENTS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XExpenseType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_EXPENSE_TYPE");

                entity.Property(e => e.XExpenseTypeDescription)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_EXPENSE_TYPE_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwDesignation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_DESIGNATIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwEmployeeMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_EMPLOYEE_MASTER");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAccountNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_NUMBER");

                entity.Property(e => e.XAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS");

                entity.Property(e => e.XAdvLimit)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_ADV_LIMIT");

                entity.Property(e => e.XBankName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_BANK_NAME");

                entity.Property(e => e.XBankNameDescription)
                    .HasMaxLength(503)
                    .IsUnicode(false)
                    .HasColumnName("X_BANK_NAME_DESCRIPTION");

                entity.Property(e => e.XBloodGroup)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BLOOD_GROUP");

                entity.Property(e => e.XCadre)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CADRE");

                entity.Property(e => e.XCadreDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CADRE_DESCRIPTION");

                entity.Property(e => e.XCalculationMode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CALCULATION_MODE");

                entity.Property(e => e.XCalculationModeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_CALCULATION_MODE_DESCRIPTION");

                entity.Property(e => e.XCard)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CARD");

                entity.Property(e => e.XCategory)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CATEGORY");

                entity.Property(e => e.XCategoryDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CATEGORY_DESCRIPTION");

                entity.Property(e => e.XCity)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CITY");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XContractDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_CONTRACT_DATE");

                entity.Property(e => e.XDateOfBirth)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_DATE_OF_BIRTH");

                entity.Property(e => e.XDepartment)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DEPARTMENT");

                entity.Property(e => e.XDepartmentDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DEPARTMENT_DESCRIPTION");

                entity.Property(e => e.XDesignation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DESIGNATION");

                entity.Property(e => e.XDesignationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESIGNATION_DESCRIPTION");

                entity.Property(e => e.XEobi)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EOBI");

                entity.Property(e => e.XExpiryDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_EXPIRY_DATE");

                entity.Property(e => e.XFatherName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FATHER_NAME");

                entity.Property(e => e.XGender)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_GENDER");

                entity.Property(e => e.XGrade)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_GRADE");

                entity.Property(e => e.XGradeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_GRADE_DESCRIPTION");

                entity.Property(e => e.XHusbandName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_HUSBAND_NAME");

                entity.Property(e => e.XJoiningDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_JOINING_DATE");

                entity.Property(e => e.XLocation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_LOCATION");

                entity.Property(e => e.XLocationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LOCATION_DESCRIPTION");

                entity.Property(e => e.XNa1)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_NA_1");

                entity.Property(e => e.XNa2)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_NA_2");

                entity.Property(e => e.XNa3)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_NA_3");

                entity.Property(e => e.XName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XNtn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NTN");

                entity.Property(e => e.XOfficialEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_OFFICIAL_EMAIL");

                entity.Property(e => e.XOfficialMobile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_OFFICIAL_MOBILE");

                entity.Property(e => e.XPayMode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_PAY_MODE");

                entity.Property(e => e.XPayRate)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("X_PAY_RATE");

                entity.Property(e => e.XPersonalEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PERSONAL_EMAIL");

                entity.Property(e => e.XPersonalMobile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PERSONAL_MOBILE");

                entity.Property(e => e.XProject)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_PROJECT");

                entity.Property(e => e.XProjectDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PROJECT_DESCRIPTION");

                entity.Property(e => e.XReference1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REFERENCE___1");

                entity.Property(e => e.XReference2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REFERENCE___2");

                entity.Property(e => e.XReligion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_RELIGION");

                entity.Property(e => e.XReligionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_RELIGION_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSection)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SECTION");

                entity.Property(e => e.XSectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SECTION_DESCRIPTION");

                entity.Property(e => e.XShift)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIFT");

                entity.Property(e => e.XShiftDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIFT_DESCRIPTION");

                entity.Property(e => e.XSocialSecurity)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SOCIAL_SECURITY");

                entity.Property(e => e.XStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwEmployeeMasterAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_EMPLOYEE_MASTER_ALLOWANCES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAllowanceSelection)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ALLOWANCE_SELECTION");

                entity.Property(e => e.XAllowanceSelectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ALLOWANCE_SELECTION_DESCRIPTION");

                entity.Property(e => e.XAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT");

                entity.Property(e => e.XApplyDates)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_APPLY_DATES");

                entity.Property(e => e.XApplyToggle)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_APPLY_TOGGLE");

                entity.Property(e => e.XAttfactor)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ATTFACTOR");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XEndingDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_ENDING_DATE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStartingDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_STARTING_DATE");

                entity.Property(e => e.XToggleSelection)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_SELECTION");

                entity.Property(e => e.XToggleSelectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_SELECTION_DESCRIPTION");
            });

            modelBuilder.Entity<PdwEmployeeMasterComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_EMPLOYEE_MASTER_COMMENTS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XCommentType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_COMMENT_TYPE");

                entity.Property(e => e.XCommentTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_COMMENT_TYPE_DESCRIPTION");

                entity.Property(e => e.XDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_DATE");

                entity.Property(e => e.XOccasionForComment)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_OCCASION_FOR_COMMENT");

                entity.Property(e => e.XRemarks1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS___1");

                entity.Property(e => e.XRemarks2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS___2");

                entity.Property(e => e.XRemarks3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS___3");
            });

            modelBuilder.Entity<PdwEmployeeMasterDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_EMPLOYEE_MASTER_DEDUCTIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAmount)
                    .HasColumnType("numeric(13, 0)")
                    .HasColumnName("X_AMOUNT");

                entity.Property(e => e.XApplyDates)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_APPLY_DATES");

                entity.Property(e => e.XApplyToggle)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_APPLY_TOGGLE");

                entity.Property(e => e.XAttfactor)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ATTFACTOR");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDeductionSelection)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DEDUCTION_SELECTION");

                entity.Property(e => e.XDeductionSelectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DEDUCTION_SELECTION_DESCRIPTION");

                entity.Property(e => e.XEndingDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_ENDING_DATE");

                entity.Property(e => e.XNA)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_N_A");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStaringDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_STARING_DATE");

                entity.Property(e => e.XToggleSelection)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_SELECTION");

                entity.Property(e => e.XToggleSelectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_SELECTION_DESCRIPTION");
            });

            modelBuilder.Entity<PdwEmployeeMasterLoan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_EMPLOYEE_MASTER_LOANS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XApprovalNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_APPROVAL_NUMBER");

                entity.Property(e => e.XBalance)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_BALANCE");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_DATE");

                entity.Property(e => e.XDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XEffectiveDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_EFFECTIVE_DATE");

                entity.Property(e => e.XInstallment)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_INSTALLMENT");

                entity.Property(e => e.XInterest)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_INTEREST");

                entity.Property(e => e.XLoanSelection)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_LOAN_SELECTION");

                entity.Property(e => e.XLoanSelectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LOAN_SELECTION_DESCRIPTION");

                entity.Property(e => e.XLumpSum)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_LUMP_SUM");

                entity.Property(e => e.XPaidBack)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_PAID_BACK");

                entity.Property(e => e.XPrincipal)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_PRINCIPAL");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStatus)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS");
            });

            modelBuilder.Entity<PdwEmployeeMasterSubProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_EMPLOYEE_MASTER_SUB_PROJECTS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XEndingDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_ENDING_DATE");

                entity.Property(e => e.XPercentage)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_PERCENTAGE");

                entity.Property(e => e.XProjectCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_PROJECT_CODE");

                entity.Property(e => e.XProjectCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PROJECT_CODE_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStartingDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_STARTING_DATE");

                entity.Property(e => e.XStatus)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS");
            });

            modelBuilder.Entity<PdwEmployeePic>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_EMPLOYEE_PIC");

                entity.Property(e => e.XEmployee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("X_EMPLOYEE");

                entity.Property(e => e.XPicLink)
                    .HasMaxLength(1352)
                    .HasColumnName("X_PIC_LINK");
            });

            modelBuilder.Entity<PdwGrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_GRADES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XIncrement)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_INCREMENT");

                entity.Property(e => e.XMaximum)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MAXIMUM");

                entity.Property(e => e.XMinimum)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MINIMUM");

                entity.Property(e => e.XPayScale)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PAY_SCALE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStages)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_STAGES");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwGradesAllowance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_GRADES_ALLOWANCES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAllowanceSelection)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ALLOWANCE_SELECTION");

                entity.Property(e => e.XAllowanceSelectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ALLOWANCE_SELECTION_DESCRIPTION");

                entity.Property(e => e.XAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT");

                entity.Property(e => e.XApplyDates)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_APPLY_DATES");

                entity.Property(e => e.XApplyToggle)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_APPLY_TOGGLE");

                entity.Property(e => e.XAttFactor)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ATT_FACTOR");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XEndingDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_ENDING_DATE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStartingDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_STARTING_DATE");

                entity.Property(e => e.XToggleSelection)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_SELECTION");

                entity.Property(e => e.XToggleSelectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_SELECTION_DESCRIPTION");
            });

            modelBuilder.Entity<PdwGradesDeduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_GRADES_DEDUCTIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT");

                entity.Property(e => e.XApplyDates)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_APPLY_DATES");

                entity.Property(e => e.XApplyToggle)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_APPLY_TOGGLE");

                entity.Property(e => e.XAttFactor)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ATT_FACTOR");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDeductionSelection)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DEDUCTION_SELECTION");

                entity.Property(e => e.XDeductionSelectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DEDUCTION_SELECTION_DESCRIPTION");

                entity.Property(e => e.XEndingDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_ENDING_DATE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStartingDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_STARTING_DATE");

                entity.Property(e => e.XToggleSelection)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_SELECTION");

                entity.Property(e => e.XToggleSelectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_TOGGLE_SELECTION_DESCRIPTION");
            });

            modelBuilder.Entity<PdwLeaveCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_LEAVE_CODES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XLeaveType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_LEAVE_TYPE");

                entity.Property(e => e.XLeaveTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_LEAVE_TYPE_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwLoan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_LOANS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XCreditCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CREDIT_CODE");

                entity.Property(e => e.XCreditCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CREDIT_CODE_DESCRIPTION");

                entity.Property(e => e.XDebitCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DEBIT_CODE");

                entity.Property(e => e.XDebitCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DEBIT_CODE_DESCRIPTION");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XGlVoucherParticulars)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_GL_VOUCHER_PARTICULARS");

                entity.Property(e => e.XLoanType)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LOAN_TYPE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_LOCATIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XAccountNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_NUMBER");

                entity.Property(e => e.XBankAndBranchName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BANK_AND_BRANCH_NAME");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XManagerTitle)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MANAGER_TITLE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSignatoryDesignation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SIGNATORY_DESIGNATION");

                entity.Property(e => e.XSignatoryName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SIGNATORY_NAME");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwOutlet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_OUTLETS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_PROJECTS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwReligion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_RELIGION");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_SHIFTS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<PdwSubProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PDW_SUB_PROJECTS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XProject)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_PROJECT");

                entity.Property(e => e.XProjectDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PROJECT_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_AREA");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCity)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CITY");

                entity.Property(e => e.XCityDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CITY_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbAtmServiceCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_ATM_SERVICE_CHARGES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XBaseDistance)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_BASE_DISTANCE");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XFromKms)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_FROM_KMS");

                entity.Property(e => e.XMeasureDistance)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_MEASURE_DISTANCE");

                entity.Property(e => e.XMeasureDistanceDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_MEASURE_DISTANCE_DESCRIPTION");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRatePerKm)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_RATE_PER_KM");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_START_DATE");

                entity.Property(e => e.XSubCode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SUB_CODE");

                entity.Property(e => e.XToKms)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_TO_KMS");

                entity.Property(e => e.XTripCharges)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_TRIP_CHARGES");

                entity.Property(e => e.XTripType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TRIP_TYPE");

                entity.Property(e => e.XTripTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_TRIP_TYPE_DESCRIPTION");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbAtmServiceChargesCalculationRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_ATM_SERVICE_CHARGES_CALCULATION_RULES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAtmElement)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ATM_ELEMENT");

                entity.Property(e => e.XAtmElementDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_ATM_ELEMENT_DESCRIPTION");

                entity.Property(e => e.XCalculationRule)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CALCULATION_RULE");

                entity.Property(e => e.XCalculationRuleDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_CALCULATION_RULE_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbAtmServiceChargesChargesRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_ATM_SERVICE_CHARGES_CHARGES_RULES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAtmElement)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ATM_ELEMENT");

                entity.Property(e => e.XAtmElementDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_ATM_ELEMENT_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XEndingKm)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_ENDING_KM");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStartingKm)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_STARTING_KM");

                entity.Property(e => e.XValue)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_VALUE");
            });

            modelBuilder.Entity<RbAtmServiceType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_ATM_SERVICE_TYPES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XAddress1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_1");

                entity.Property(e => e.XAddress2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_2");

                entity.Property(e => e.XAddress3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_3");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL");

                entity.Property(e => e.XFaxNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FAX_NO");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XMobile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MOBILE");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XNtn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NTN");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSalesTaxNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SALES_TAX_NO");

                entity.Property(e => e.XUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_URL");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbAtmServiceTypesContactPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_ATM_SERVICE_TYPES_CONTACT_PERSON");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS");

                entity.Property(e => e.XCellNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CELL_NO");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDesignation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESIGNATION");

                entity.Property(e => e.XEmailId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL_ID");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbBranchManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_BRANCH_MANAGEMENT");

                entity.Property(e => e.BrCode)
                    .HasMaxLength(276)
                    .IsUnicode(false)
                    .HasColumnName("BR_CODE");

                entity.Property(e => e.BrName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("BR_NAME");

                entity.Property(e => e.BrType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BR_TYPE");

                entity.Property(e => e.BrTypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BR_TYPE_NAME");

                entity.Property(e => e.CpcCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CPC_CODE");

                entity.Property(e => e.CpcDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CPC_DESC");

                entity.Property(e => e.CpcYn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CPC_YN");

                entity.Property(e => e.McmCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MCM_CODE");

                entity.Property(e => e.McmName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("MCM_NAME");

                entity.Property(e => e.SregCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SREG_CODE");

                entity.Property(e => e.SregDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("SREG_DESC");

                entity.Property(e => e.StatCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("STAT_CODE");

                entity.Property(e => e.StatDesc)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("STAT_DESC");
            });

            modelBuilder.Entity<RbCitShipment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_CIT_SHIPMENT");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DBillDate)
                    .HasColumnType("datetime")
                    .HasColumnName("D_BILL_DATE");

                entity.Property(e => e.DDate)
                    .HasColumnType("datetime")
                    .HasColumnName("D_DATE");

                entity.Property(e => e.DDeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("D_DELIVERY_DATE");

                entity.Property(e => e.DDeliveryTime)
                    .HasColumnType("datetime")
                    .HasColumnName("D_DELIVERY_TIME");

                entity.Property(e => e.DPickDate)
                    .HasColumnType("datetime")
                    .HasColumnName("D_PICK_DATE");

                entity.Property(e => e.DPickTime)
                    .HasColumnType("datetime")
                    .HasColumnName("D_PICK_TIME");

                entity.Property(e => e.DocumentStatus)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DOCUMENT_STATUS");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_CODE");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_NAME");

                entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.PeriodCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD_CODE");

                entity.Property(e => e.PeriodName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD_NAME");

                entity.Property(e => e.WorkflowStatus)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("WORKFLOW_STATUS");

                entity.Property(e => e.XAdditional)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_ADDITIONAL");

                entity.Property(e => e.XAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT");

                entity.Property(e => e.XAmountCarried)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT_CARRIED");

                entity.Property(e => e.XAutoBilling)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_AUTO_BILLING");

                entity.Property(e => e.XBaseCharges)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_BASE_CHARGES");

                entity.Property(e => e.XBillBranch)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_BILL_BRANCH");

                entity.Property(e => e.XBillBranchDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BILL_BRANCH_DESCRIPTION");

                entity.Property(e => e.XBillDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_BILL_DATE");

                entity.Property(e => e.XBillingCustomerName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BILLING_CUSTOMER_NAME");

                entity.Property(e => e.XCollection)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_COLLECTION");

                entity.Property(e => e.XCollectionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_COLLECTION_DESCRIPTION");

                entity.Property(e => e.XCredits)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_CREDITS");

                entity.Property(e => e.XCustomer)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CUSTOMER");

                entity.Property(e => e.XDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_DATE");

                entity.Property(e => e.XDebits)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_DEBITS");

                entity.Property(e => e.XDelivery)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DELIVERY");

                entity.Property(e => e.XDeliveryDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_DELIVERY_DATE");

                entity.Property(e => e.XDeliveryDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DELIVERY_DESCRIPTION");

                entity.Property(e => e.XDeliveryTime)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_DELIVERY_TIME");

                entity.Property(e => e.XDistance)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_DISTANCE");

                entity.Property(e => e.XDistanceKms)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_DISTANCE_KMS");

                entity.Property(e => e.XFcValue)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FC_VALUE");

                entity.Property(e => e.XFixedAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_FIXED_AMOUNT");

                entity.Property(e => e.XMainCustomer)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_MAIN_CUSTOMER");

                entity.Property(e => e.XMainCustomerDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MAIN_CUSTOMER_DESCRIPTION");

                entity.Property(e => e.XNetAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_NET_AMOUNT");

                entity.Property(e => e.XNoOfBags)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_NO_OF_BAGS");

                entity.Property(e => e.XNoOfSeals)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_NO_OF_SEALS");

                entity.Property(e => e.XNumber)
                    .HasColumnType("numeric(20, 0)")
                    .HasColumnName("X_NUMBER");

                entity.Property(e => e.XPickDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_PICK_DATE");

                entity.Property(e => e.XPickTime)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_PICK_TIME");

                entity.Property(e => e.XPortalReference)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PORTAL_REFERENCE");

                entity.Property(e => e.XRateId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_RATE_ID");

                entity.Property(e => e.XRateIdDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_RATE_ID_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XRevenueRegion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_REVENUE_REGION");

                entity.Property(e => e.XRevenueRegionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REVENUE_REGION_DESCRIPTION");

                entity.Property(e => e.XSealCharges)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_SEAL_CHARGES");

                entity.Property(e => e.XShipmentNo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIPMENT_NO");

                entity.Property(e => e.XShipmentType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIPMENT_TYPE");

                entity.Property(e => e.XShipmentTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIPMENT_TYPE_DESCRIPTION");

                entity.Property(e => e.XSurCharge)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_SUR_CHARGE");

                entity.Property(e => e.XTollTax)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_TOLL_TAX");

                entity.Property(e => e.XVaultCharges)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_VAULT_CHARGES");

                entity.Property(e => e.XVaultNights)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_VAULT_NIGHTS");

                entity.Property(e => e.XVehicle)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_VEHICLE");

                entity.Property(e => e.XVehicleDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_VEHICLE_DESCRIPTION");

                entity.Property(e => e.XWaiting)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_WAITING");

                entity.Property(e => e.XWaitingMins)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_WAITING_MINS");

                entity.Property(e => e.YearCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_CODE");

                entity.Property(e => e.YearName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("YEAR_NAME");
            });

            modelBuilder.Entity<RbCitShipmentForeignCurrency>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_CIT_SHIPMENT_FOREIGN_CURRENCY");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAmountInFc)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT_IN_FC");

                entity.Property(e => e.XAmountInPkr)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT_IN_PKR");

                entity.Property(e => e.XConversionRate)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_CONVERSION_RATE");

                entity.Property(e => e.XCurrency)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CURRENCY");

                entity.Property(e => e.XCurrencyDescription)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("X_CURRENCY_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbCitShipmentSealsDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_CIT_SHIPMENT_SEALS_DETAILS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.MasterId).HasColumnName("MASTER_ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSealCode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SEAL_CODE");
            });

            modelBuilder.Entity<RbCity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_CITY");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XZone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ZONE");

                entity.Property(e => e.XZoneDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ZONE_DESCRIPTION");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbCreditNoteReason>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_CREDIT_NOTE_REASONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbCustomerManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_CUSTOMER_MANAGEMENT");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XAddress1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_1");

                entity.Property(e => e.XAddress2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_2");

                entity.Property(e => e.XAddress3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_3");

                entity.Property(e => e.XArea)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_AREA");

                entity.Property(e => e.XAreaDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_AREA_DESCRIPTION");

                entity.Property(e => e.XCellNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CELL_NO");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XCustomerType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CUSTOMER_TYPE");

                entity.Property(e => e.XCustomerTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CUSTOMER_TYPE_DESCRIPTION");

                entity.Property(e => e.XEmailId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL_ID");

                entity.Property(e => e.XFaxNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FAX_NO");

                entity.Property(e => e.XIndustryType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_INDUSTRY_TYPE");

                entity.Property(e => e.XIndustryTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_INDUSTRY_TYPE_DESCRIPTION");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XMainCustomer)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_MAIN_CUSTOMER");

                entity.Property(e => e.XMainCustomerDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MAIN_CUSTOMER_DESCRIPTION");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XNtn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NTN");

                entity.Property(e => e.XRegistrationDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_REGISTRATION_DATE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XRevenueAuthority)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_REVENUE_AUTHORITY");

                entity.Property(e => e.XRevenueAuthorityDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REVENUE_AUTHORITY_DESCRIPTION");

                entity.Property(e => e.XSalesTaxNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SALES_TAX_NO");

                entity.Property(e => e.XSalesTaxReg)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SALES_TAX_REG");

                entity.Property(e => e.XSalesTaxRegDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_SALES_TAX_REG_DESCRIPTION");

                entity.Property(e => e.XStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS");

                entity.Property(e => e.XStatusDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS_DESCRIPTION");

                entity.Property(e => e.XUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_URL");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbCustomerManagementContactPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_CUSTOMER_MANAGEMENT_CONTACT_PERSON");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS");

                entity.Property(e => e.XCellNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CELL_NO");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDesignation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESIGNATION");

                entity.Property(e => e.XEmailId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL_ID");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbCustomerType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_CUSTOMER_TYPE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XAccountCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_CODE");

                entity.Property(e => e.XAccountCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_CODE_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSalesCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SALES_CODE");

                entity.Property(e => e.XSalesCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SALES_CODE_DESCRIPTION");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbDebitNoteReason>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_DEBIT_NOTE_REASONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbDoubleRateTiming>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_DOUBLE_RATE_TIMINGS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XFriday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_FRIDAY");

                entity.Property(e => e.XMonday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_MONDAY");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSaturday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_SATURDAY");

                entity.Property(e => e.XSunday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_SUNDAY");

                entity.Property(e => e.XThursday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_THURSDAY");

                entity.Property(e => e.XTuesday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_TUESDAY");

                entity.Property(e => e.XWednesday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_WEDNESDAY");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbDoubleRateTimingsCitRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_DOUBLE_RATE_TIMINGS_CIT_RULES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAmountFrom)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT_FROM");

                entity.Property(e => e.XAmountTo)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT_TO");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XElement)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ELEMENT");

                entity.Property(e => e.XElementDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_ELEMENT_DESCRIPTION");

                entity.Property(e => e.XIncreasePercentage)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_INCREASE_PERCENTAGE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XWeekday)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_WEEKDAY");

                entity.Property(e => e.XWeekdayDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_WEEKDAY_DESCRIPTION");
            });

            modelBuilder.Entity<RbDoubleRateTimingsTimingException>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_DOUBLE_RATE_TIMINGS_TIMING_EXCEPTIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XFriday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_FRIDAY");

                entity.Property(e => e.XMonday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_MONDAY");

                entity.Property(e => e.XNature)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_NATURE");

                entity.Property(e => e.XNatureDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_NATURE_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSaturday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_SATURDAY");

                entity.Property(e => e.XSunday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_SUNDAY");

                entity.Property(e => e.XThursday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_THURSDAY");

                entity.Property(e => e.XTuesday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_TUESDAY");

                entity.Property(e => e.XWednesday)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_WEDNESDAY");
            });

            modelBuilder.Entity<RbFeature>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_FEATURES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbGuardingContract>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_GUARDING_CONTRACT");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XBranchCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_CODE");

                entity.Property(e => e.XBranchCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_CODE_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XCustomer)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CUSTOMER");

                entity.Property(e => e.XCustomerDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CUSTOMER_DESCRIPTION");

                entity.Property(e => e.XEveningShift)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_EVENING_SHIFT");

                entity.Property(e => e.XMorningShift)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MORNING_SHIFT");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_START_DATE");

                entity.Property(e => e.XSubCode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SUB_CODE");

                entity.Property(e => e.XTotalGuards)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_TOTAL_GUARDS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbGuardingContractGuardCostRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_GUARDING_CONTRACT_GUARD_COST_RATES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XMonthlyRate)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_MONTHLY_RATE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XServiceType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SERVICE_TYPE");

                entity.Property(e => e.XServiceTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SERVICE_TYPE_DESCRIPTION");
            });

            modelBuilder.Entity<RbGuardingContractGuardingInvoiceRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_GUARDING_CONTRACT_GUARDING_INVOICE_RATES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XQuantity)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_QUANTITY");

                entity.Property(e => e.XRate)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_RATE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XServiceCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SERVICE_CODE");

                entity.Property(e => e.XServiceCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SERVICE_CODE_DESCRIPTION");
            });

            modelBuilder.Entity<RbGuardingContractWeapon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_GUARDING_CONTRACT_WEAPONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_AMOUNT");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XQuantity)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_QUANTITY");

                entity.Property(e => e.XRate)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_RATE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XWeaponCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_WEAPON_CODE");

                entity.Property(e => e.XWeaponCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_WEAPON_CODE_DESCRIPTION");
            });

            modelBuilder.Entity<RbIndustryType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_INDUSTRY_TYPE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbIntegrationDocumentsManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_INTEGRATION_DOCUMENTS_MANAGEMENT");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbIntegrationDocumentsManagementGlAccountCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_INTEGRATION_DOCUMENTS_MANAGEMENT_GL_ACCOUNT_CODES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XCreditAccount)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CREDIT_ACCOUNT");

                entity.Property(e => e.XCreditAccountDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CREDIT_ACCOUNT_DESCRIPTION");

                entity.Property(e => e.XDebitAccount)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DEBIT_ACCOUNT");

                entity.Property(e => e.XDebitAccountDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DEBIT_ACCOUNT_DESCRIPTION");

                entity.Property(e => e.XGeneralRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_GENERAL_REMARKS");

                entity.Property(e => e.XNatureOfAmount)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_NATURE_OF_AMOUNT");

                entity.Property(e => e.XNatureOfAmountDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_NATURE_OF_AMOUNT_DESCRIPTION");

                entity.Property(e => e.XParticularsForCreditEntry)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PARTICULARS_FOR_CREDIT_ENTRY");

                entity.Property(e => e.XParticularsForDebitEntry)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_PARTICULARS_FOR_DEBIT_ENTRY");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbMainCustomerManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XAccountNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_NUMBER");

                entity.Property(e => e.XAccountTitle)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_TITLE");

                entity.Property(e => e.XAddress1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_1");

                entity.Property(e => e.XAddress2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_2");

                entity.Property(e => e.XAddress3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_3");

                entity.Property(e => e.XBankName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BANK_NAME");

                entity.Property(e => e.XCitCentralized)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CIT_CENTRALIZED");

                entity.Property(e => e.XCitInvoicing)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CIT_INVOICING");

                entity.Property(e => e.XCitInvoicingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_CIT_INVOICING_DESCRIPTION");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL");

                entity.Property(e => e.XFaxNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FAX_NO");

                entity.Property(e => e.XGuardingCentralized)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_GUARDING_CENTRALIZED");

                entity.Property(e => e.XIbanNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_IBAN_NUMBER");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XLocalRangeInKms)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_LOCAL_RANGE_IN_KMS");

                entity.Property(e => e.XMobile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MOBILE");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XNtn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NTN");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSalesTaxNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SALES_TAX_NO");

                entity.Property(e => e.XShipmentDate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIPMENT_DATE");

                entity.Property(e => e.XShipmentDateDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIPMENT_DATE_DESCRIPTION");

                entity.Property(e => e.XUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_URL");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbMainCustomerManagementAtmTripRatesMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_ATM_TRIP_RATES_MAPPING");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XBranch)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH");

                entity.Property(e => e.XBranchDescription)
                    .HasMaxLength(353)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDoubleRate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DOUBLE_RATE");

                entity.Property(e => e.XDoubleRateDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DOUBLE_RATE_DESCRIPTION");

                entity.Property(e => e.XRegionalOffice)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_REGIONAL_OFFICE");

                entity.Property(e => e.XRegionalOfficeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REGIONAL_OFFICE_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XServiceId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SERVICE_ID");

                entity.Property(e => e.XServiceIdDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SERVICE_ID_DESCRIPTION");

                entity.Property(e => e.XStation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION");

                entity.Property(e => e.XStationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION_DESCRIPTION");

                entity.Property(e => e.XStatus)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS");

                entity.Property(e => e.XStatusDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS_DESCRIPTION");

                entity.Property(e => e.XValidFrom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_VALID_FROM");

                entity.Property(e => e.XValidTo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_VALID_TO");
            });

            modelBuilder.Entity<RbMainCustomerManagementBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_BRANCHES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAddress1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_1");

                entity.Property(e => e.XAddress2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_2");

                entity.Property(e => e.XAlramSystem)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ALRAM_SYSTEM");

                entity.Property(e => e.XAlramSystemDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_ALRAM_SYSTEM_DESCRIPTION");

                entity.Property(e => e.XAtmBranch)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ATM_BRANCH");

                entity.Property(e => e.XAtmBranchDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ATM_BRANCH_DESCRIPTION");

                entity.Property(e => e.XBranchCode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_CODE");

                entity.Property(e => e.XBranchDetailFeatures)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_DETAIL_FEATURES");

                entity.Property(e => e.XBranchName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_NAME");

                entity.Property(e => e.XBranchStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_STATUS");

                entity.Property(e => e.XBranchStatusDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_STATUS_DESCRIPTION");

                entity.Property(e => e.XBranchType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_TYPE");

                entity.Property(e => e.XBranchTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_TYPE_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XContactPersonDetails)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CONTACT_PERSON_DETAILS");

                entity.Property(e => e.XCpc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CPC");

                entity.Property(e => e.XCpcBranch)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CPC_BRANCH");

                entity.Property(e => e.XCpcDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CPC_DESCRIPTION");

                entity.Property(e => e.XEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL");

                entity.Property(e => e.XEndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_END_DATE");

                entity.Property(e => e.XFaxNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FAX_NUMBER");

                entity.Property(e => e.XGeoStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_GEO_STATUS");

                entity.Property(e => e.XGeoStatusDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_GEO_STATUS_DESCRIPTION");

                entity.Property(e => e.XGuardingRegion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_GUARDING_REGION");

                entity.Property(e => e.XGuardingRegionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_GUARDING_REGION_DESCRIPTION");

                entity.Property(e => e.XGuardingStation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_GUARDING_STATION");

                entity.Property(e => e.XGuardingStationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_GUARDING_STATION_DESCRIPTION");

                entity.Property(e => e.XGuardingStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_GUARDING_STATUS");

                entity.Property(e => e.XGuardingStatusDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_GUARDING_STATUS_DESCRIPTION");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XLatitude)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LATITUDE");

                entity.Property(e => e.XLongitude)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LONGITUDE");

                entity.Property(e => e.XMobile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MOBILE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION");

                entity.Property(e => e.XStationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION_DESCRIPTION");

                entity.Property(e => e.XSubRegion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SUB_REGION");

                entity.Property(e => e.XSubRegionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SUB_REGION_DESCRIPTION");
            });

            modelBuilder.Entity<RbMainCustomerManagementBranchFeature>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_BRANCH_FEATURES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.MDetailId).HasColumnName("M_DETAIL_ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDetailCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DETAIL_CODE");

                entity.Property(e => e.XDetailCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DETAIL_CODE_DESCRIPTION");

                entity.Property(e => e.XFeatureName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_FEATURE_NAME");

                entity.Property(e => e.XFeatureNameDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_FEATURE_NAME_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbMainCustomerManagementCitBranchRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_CIT_BRANCH_RATES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDestination)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DESTINATION");

                entity.Property(e => e.XDestinationDescription)
                    .HasMaxLength(353)
                    .IsUnicode(false)
                    .HasColumnName("X_DESTINATION_DESCRIPTION");

                entity.Property(e => e.XFrom)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_FROM");

                entity.Property(e => e.XFromDescription)
                    .HasMaxLength(353)
                    .IsUnicode(false)
                    .HasColumnName("X_FROM_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XShipmentRate)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_SHIPMENT_RATE");

                entity.Property(e => e.XStatus)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS");

                entity.Property(e => e.XStatusDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS_DESCRIPTION");

                entity.Property(e => e.XValidFrom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_VALID_FROM");

                entity.Property(e => e.XValidTo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_VALID_TO");
            });

            modelBuilder.Entity<RbMainCustomerManagementCitDedicatedVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_CIT_DEDICATED_VEHICLES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XBranch)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH");

                entity.Property(e => e.XBranchDescription)
                    .HasMaxLength(353)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRadiusKm)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_RADIUS_KM");

                entity.Property(e => e.XRate)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_RATE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XTrips)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_TRIPS");

                entity.Property(e => e.XVehicles)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_VEHICLES");
            });

            modelBuilder.Entity<RbMainCustomerManagementCitRatesMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_CIT_RATES_MAPPING");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XBranch)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH");

                entity.Property(e => e.XBranchDescription)
                    .HasMaxLength(353)
                    .IsUnicode(false)
                    .HasColumnName("X_BRANCH_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDoubleRate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_DOUBLE_RATE");

                entity.Property(e => e.XDoubleRateDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DOUBLE_RATE_DESCRIPTION");

                entity.Property(e => e.XRegionalOffice)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_REGIONAL_OFFICE");

                entity.Property(e => e.XRegionalOfficeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REGIONAL_OFFICE_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XServiceId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SERVICE_ID");

                entity.Property(e => e.XServiceIdDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SERVICE_ID_DESCRIPTION");

                entity.Property(e => e.XStation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION");

                entity.Property(e => e.XStationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION_DESCRIPTION");

                entity.Property(e => e.XStatus)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS");

                entity.Property(e => e.XStatusDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_STATUS_DESCRIPTION");

                entity.Property(e => e.XValidFrom)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_VALID_FROM");

                entity.Property(e => e.XValidTo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_VALID_TO");
            });

            modelBuilder.Entity<RbMainCustomerManagementContactPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_CONTACT_PERSON");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS");

                entity.Property(e => e.XCellNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CELL_NO");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDesignation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESIGNATION");

                entity.Property(e => e.XEmailId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL_ID");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbMainCustomerManagementFeatureCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_FEATURE_CODES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XFeatureDetailCodes)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FEATURE_DETAIL_CODES");

                entity.Property(e => e.XFeatureName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_FEATURE_NAME");

                entity.Property(e => e.XFeatureNameDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_FEATURE_NAME_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbMainCustomerManagementFeatureDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_FEATURE_DETAILS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.MDetailId).HasColumnName("M_DETAIL_ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XFeatureCode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FEATURE_CODE");

                entity.Property(e => e.XFestureDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FESTURE_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbMainCustomerManagementVehcileDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_VEHCILE_DETAILS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.MDetailId).HasColumnName("M_DETAIL_ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XVehicleCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_VEHICLE_CODE");

                entity.Property(e => e.XVehicleCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_VEHICLE_CODE_DESCRIPTION");
            });

            modelBuilder.Entity<RbMainCustomerManagementVehicleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_MAIN_CUSTOMER_MANAGEMENT_VEHICLE_DETAILS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.MDetailId).HasColumnName("M_DETAIL_ID");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XVehicleCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_VEHICLE_CODE");

                entity.Property(e => e.XVehicleCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_VEHICLE_CODE_DESCRIPTION");
            });

            modelBuilder.Entity<RbOrderStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_ORDER_STATUS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbOrderType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_ORDER_TYPE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbPaymentTermTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_PAYMENT_TERM_TEMPLATES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbPaymentTermTemplatesPaymentTerm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_PAYMENT_TERM_TEMPLATES_PAYMENT_TERMS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSerial)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_SERIAL_");

                entity.Property(e => e.XSubSerial)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_SUB_SERIAL");

                entity.Property(e => e.XText)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_TEXT");
            });

            modelBuilder.Entity<RbProductClassification>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_PRODUCT_CLASSIFICATION");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XClassification)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CLASSIFICATION");

                entity.Property(e => e.XClassificationDescription)
                    .HasMaxLength(276)
                    .IsUnicode(false)
                    .HasColumnName("X_CLASSIFICATION_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSellingRateChangeableOnCustomerEnquiry)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SELLING_RATE_CHANGEABLE_ON_CUSTOMER_ENQUIRY");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbProductClassificationCostLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_PRODUCT_CLASSIFICATION_COST_LINKS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XCostOfStock)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_COST_OF_STOCK");

                entity.Property(e => e.XCostOfStockDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_COST_OF_STOCK_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStockControlCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STOCK_CONTROL_CODE");

                entity.Property(e => e.XStockControlCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_STOCK_CONTROL_CODE_DESCRIPTION");
            });

            modelBuilder.Entity<RbProjectNature>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_PROJECT_NATURE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_REGION");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbRegionalOffice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_REGIONAL_OFFICES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRegion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_REGION");

                entity.Property(e => e.XRegionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REGION_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbRevenueAuthority>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_REVENUE_AUTHORITY");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XInvoiceNote1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_INVOICE_NOTE_1");

                entity.Property(e => e.XInvoiceNote2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_INVOICE_NOTE_2");

                entity.Property(e => e.XInvoiceNote3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_INVOICE_NOTE_3");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSTaxPercent)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_S_TAX_PERCENT");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbRevenueAuthorityTaxCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_REVENUE_AUTHORITY_TAX_CODES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAccount)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT");

                entity.Property(e => e.XAccountDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XTaxTypes)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TAX_TYPES");

                entity.Property(e => e.XTaxTypesDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_TAX_TYPES_DESCRIPTION");
            });

            modelBuilder.Entity<RbRevenueNature>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_REVENUE_NATURE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbService>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SERVICES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_TYPE");

                entity.Property(e => e.XTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_TYPE_DESCRIPTION");

                entity.Property(e => e.XUom)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_UOM");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbServiceCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SERVICE_CHARGES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XBaseCharges)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_BASE_CHARGES");

                entity.Property(e => e.XBaseDistance)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_BASE_DISTANCE");

                entity.Property(e => e.XBaseLimit)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_BASE_LIMIT");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XFromKms)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_FROM_KMS");

                entity.Property(e => e.XMeasureDistance)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_MEASURE_DISTANCE");

                entity.Property(e => e.XMeasureDistanceDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_MEASURE_DISTANCE_DESCRIPTION");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRatePerKm)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_RATE_PER_KM");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSealCharges)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_SEAL_CHARGES");

                entity.Property(e => e.XShipmentType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIPMENT_TYPE");

                entity.Property(e => e.XShipmentTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SHIPMENT_TYPE_DESCRIPTION");

                entity.Property(e => e.XStartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_START_DATE");

                entity.Property(e => e.XSubCode)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SUB_CODE");

                entity.Property(e => e.XSurCharges)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_SUR_CHARGES");

                entity.Property(e => e.XToKms)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_TO_KMS");

                entity.Property(e => e.XVaultCharges)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_VAULT_CHARGES");

                entity.Property(e => e.XVaultRules)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_VAULT_RULES");

                entity.Property(e => e.XVaultRulesDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_VAULT_RULES_DESCRIPTION");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbServiceChargesBaseChargesRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SERVICE_CHARGES_BASE_CHARGES_RULES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XBaseCharges)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_BASE_CHARGES");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XEndingAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_ENDING_AMOUNT");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStartingAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_STARTING_AMOUNT");
            });

            modelBuilder.Entity<RbServiceChargesCalculationRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SERVICE_CHARGES_CALCULATION_RULES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCalculationRule)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CALCULATION_RULE");

                entity.Property(e => e.XCalculationRuleDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_CALCULATION_RULE_DESCRIPTION");

                entity.Property(e => e.XCitElement)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CIT_ELEMENT");

                entity.Property(e => e.XCitElementDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_CIT_ELEMENT_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbServiceChargesChargesRule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SERVICE_CHARGES_CHARGES_RULES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCitElement)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CIT_ELEMENT");

                entity.Property(e => e.XCitElementDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_CIT_ELEMENT_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XEndingAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_ENDING_AMOUNT");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStartingAmount)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_STARTING_AMOUNT");

                entity.Property(e => e.XValue)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_VALUE");
            });

            modelBuilder.Entity<RbServicesAccountCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SERVICES_ACCOUNT_CODES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAccountCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_CODE");

                entity.Property(e => e.XAccountCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_CODE_DESCRIPTION");

                entity.Property(e => e.XAccountNature)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_NATURE");

                entity.Property(e => e.XAccountNatureDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_ACCOUNT_NATURE_DESCRIPTION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStandardParticulars)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_STANDARD_PARTICULARS");
            });

            modelBuilder.Entity<RbShipmentType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SHIPMENT_TYPES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XAddress1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_1");

                entity.Property(e => e.XAddress2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_2");

                entity.Property(e => e.XAddress3)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS_3");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL");

                entity.Property(e => e.XFaxNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_FAX_NO");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XMobile)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MOBILE");

                entity.Property(e => e.XName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XNtn)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NTN");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XSalesTaxNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_SALES_TAX_NO");

                entity.Property(e => e.XUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_URL");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbShipmentTypesContactPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SHIPMENT_TYPES_CONTACT_PERSON");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS");

                entity.Property(e => e.XCellNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CELL_NO");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDesignation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESIGNATION");

                entity.Property(e => e.XEmailId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL_ID");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbStation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_STATIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XVaultStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_VAULT_STATUS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbSubRegion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SUB_REGIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRegion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_REGION");

                entity.Property(e => e.XRegionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REGION_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XRevenueAuthroity)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_REVENUE_AUTHROITY");

                entity.Property(e => e.XRevenueAuthroityDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REVENUE_AUTHROITY_DESCRIPTION");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbSubRegionsStation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SUB_REGIONS_STATIONS");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStationCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION_CODE");

                entity.Property(e => e.XStationCodeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION_CODE_DESCRIPTION");
            });

            modelBuilder.Entity<RbSupplierManagementContactPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_SUPPLIER_MANAGEMENT_CONTACT_PERSON");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.DetailId).HasColumnName("DETAIL_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ADDRESS");

                entity.Property(e => e.XCellNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CELL_NO");

                entity.Property(e => e.XCnic)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CNIC");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDesignation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESIGNATION");

                entity.Property(e => e.XEmailId)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_EMAIL_ID");

                entity.Property(e => e.XLandline)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LANDLINE");

                entity.Property(e => e.XName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_NAME");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");
            });

            modelBuilder.Entity<RbUnitOfMeasurement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_UNIT_OF_MEASUREMENT");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_VEHICLES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XCapacity)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CAPACITY");

                entity.Property(e => e.XChasisNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_CHASIS_NO");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XEngineNo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ENGINE_NO");

                entity.Property(e => e.XGasolineType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_GASOLINE_TYPE");

                entity.Property(e => e.XGasolineTypeDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("X_GASOLINE_TYPE_DESCRIPTION");

                entity.Property(e => e.XLeasingCompany)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LEASING_COMPANY");

                entity.Property(e => e.XLocation)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_LOCATION");

                entity.Property(e => e.XLocationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_LOCATION_DESCRIPTION");

                entity.Property(e => e.XMake)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MAKE");

                entity.Property(e => e.XModel)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MODEL");

                entity.Property(e => e.XOrigin)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ORIGIN");

                entity.Property(e => e.XOtherCosts)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_OTHER_COSTS");

                entity.Property(e => e.XPurchaseDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("X_PURCHASE_DATE");

                entity.Property(e => e.XPurchasePrice)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_PURCHASE_PRICE");

                entity.Property(e => e.XRegistration)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REGISTRATION");

                entity.Property(e => e.XRegistrationCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_REGISTRATION_COST");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XStation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION");

                entity.Property(e => e.XStationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_STATION_DESCRIPTION");

                entity.Property(e => e.XTagNumber)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_TAG_NUMBER");

                entity.Property(e => e.XTotalCost)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("X_TOTAL_COST");

                entity.Property(e => e.XVehicleType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_VEHICLE_TYPE");

                entity.Property(e => e.XVehicleTypeDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_VEHICLE_TYPE_DESCRIPTION");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbVehicleType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_VEHICLE_TYPE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbreviation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVIATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbWarehouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_WAREHOUSE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XMasterLocation)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_MASTER_LOCATION");

                entity.Property(e => e.XMasterLocationDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_MASTER_LOCATION_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XWhCode)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_WH_CODE");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbWeaponType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_WEAPON_TYPES");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            modelBuilder.Entity<RbZone>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RB_ZONE");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ADD_DATE");

                entity.Property(e => e.AddId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADD_ID");

                entity.Property(e => e.IpAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ADD");

                entity.Property(e => e.IpMod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_MOD");

                entity.Property(e => e.ModDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MOD_DATE");

                entity.Property(e => e.ModId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MOD_ID");

                entity.Property(e => e.XAbbrevation)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_ABBREVATION");

                entity.Property(e => e.XCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_CODE");

                entity.Property(e => e.XDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_DESCRIPTION");

                entity.Property(e => e.XRegion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("X_REGION");

                entity.Property(e => e.XRegionDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REGION_DESCRIPTION");

                entity.Property(e => e.XRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("X_REMARKS");

                entity.Property(e => e.XrowId).HasColumnName("XROW_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
