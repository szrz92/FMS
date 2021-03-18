using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.Enums
{
    public enum MaintenanceStatus
    {
        Done,
        NotInitiated,
        Operational
    }
    public enum PeriodicMaintenanceStatus
    {
        Pending,
        Done
    }
    public enum AccidentalMaintenanceStatus
    {
        Pending,
        Done
    }
    public enum EmergencyMaintenanceStatus
    {
        Pending,
        Done
    }
}