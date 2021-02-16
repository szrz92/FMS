using SOS.FMS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SOS.FMS.Server.Models
{
    public class Party
    {
        public Guid Id { get; set; }
        public PartyType PartyType { get; set; }
        public string ShortName { get; set; }
        public int ExternalId { get; set; }

        public string FormalName { get; set; }

        public string Abbrevation { get; set; }

        public string ParentCode { get; set; }
        public virtual Organization Orgnization { get; set; }
        public DateTimeOffset LastSync { get; set; }
    }
    public partial class Organization
    {
        public Guid Id { get; set; }
        public OrganizationType OrganizationType { get; set; }

        public virtual Party Party { get; set; }
    }
}
