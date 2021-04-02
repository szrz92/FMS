using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSDailyCheckListVM
    {
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string Region { get; set; }
        public string Subregion { get; set; }
        public string Station { get; set; }
        public string Category { get; set; }
        public string SubCategeory { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public int OdometerIn { get; set; }
        public int OdometerOut { get; set; }
        public List<Check> Checklist { get; set; }
        public DateTime LastUpdated { get; set; }
    }
    public class Check 
    {
        public string Description { get; set; }
        public string Code { get; set; }
        public DailyCheckStatus Value { get; set; }
        public bool IsChecked { get; set; }
        public bool IsNotOk { get; set; }
    }
}
