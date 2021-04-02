using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class AssignedWorkshop
    {
        public Guid Id { get; set; }
        public string SupplierType { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public Guid IncidentId { get; set; }
        public string Remarks { get; set; }

    }
}