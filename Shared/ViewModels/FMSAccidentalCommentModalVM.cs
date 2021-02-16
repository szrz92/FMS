using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.FMS.Shared.ViewModels
{
    public class FMSAccidentalCommentModalVM
    {
        public Guid FMSAccidentalCheckId { get; set; }
        public Guid FMSAccidentId { get; set; }
        public Guid FMSVehicleId { get; set; }
        public string CheckPointName { get; set; }
        public string VehicleNumber { get; set; }
        public CommentModalType CommentModalType { get; set; }
        public List<FMSAccidentalCheckCommentVM> Comments { get; set; }
        public List<FMSAccidentalCheckImageVM> Images { get; set; }
    }
}