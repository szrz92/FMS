using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.Enums
{
    [Flags]
    public enum RoleType
    {

        ParentOrganization = 1,
        ChildOrganization = 2,

        Employer = 4 | ParentOrganization,
        Crew = 8 | ParentOrganization,
        Vault = 16 | ParentOrganization,
        ServiceProvider = 32 | ParentOrganization,
        RegionalOrg = 36 | ParentOrganization,
        SubRegionalOrg = 38 | ParentOrganization,
        StationOrg = 40 | ParentOrganization,

        Employee = 64,

        [Display(Name = "Cheif Crew")]
        CheifCrewAgent = 128 | Employee,

        [Display(Name = "Assistant Crew")]
        AssistantCrewAgent = 256 | Employee,

        [Display(Name = "Driver")]
        CrewDriver = 512 | Employee,

        [Display(Name = "Gaurd")]
        CrewGuard = 1024 | Employee,

        Gaurd = 2048 | Employee,

        RegionalHead = 4096 | Employee,
        SubRegionalHead = 8192 | Employee,

        /// <summary>
        /// ATM Roles
        /// </summary>
        ATMCashier = 16384 | Employee,
        ATMTechnician = 32768 | Employee,
        VaultManager = 65536 | Employee,
        VaultMember = 131072 | Employee,



        Customer = 262144,
        BankCPC = 524288,
        ATM = 1048576,
        ATMBranch = 2097152

    }
}
