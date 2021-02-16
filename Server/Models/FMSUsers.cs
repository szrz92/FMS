using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class FMSUsers
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool AccountLock { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public string DesignationDescription { get; set; }
        public string Location { get; set; }
        public string LocationDescription { get; set; }
        public string Department { get; set; }
        public string DepartmentDescription { get; set; }
        public string Section { get; set; }
        public string SectionDescription { get; set; }
        public string PersonalMobile { get; set; }
        public string OfficialMobile { get; set; }
        public string PersonalEmail { get; set; }
        public string OfficialEmail { get; set; }
        public DateTime LastSync { get; set; }
    }
}
