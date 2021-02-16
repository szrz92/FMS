using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSRoleVM
    {
        public string Id { get; set; }
        public string Role { 
            get
            {
                switch (Id)
                {
                    case "SA":
                        return "Super Admin";
                    case "HMT":
                        return "Head Of MT";
                    case "MTAM":
                        return "MT Accounts Manager";
                    case "CIM":
                        return "Coordinator Emergency/Accident";
                    case "CPM":
                        return "Coordinator Periodic Maintenance";
                    case "RMTO":
                        return "Regional MTO";
                    case "RAO":
                        return "Regional Accounts Officer";
                    default:
                        return "Unknown";
                }
                
            } 
        }
    }
}
