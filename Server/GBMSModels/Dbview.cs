using System;
using System.Collections.Generic;

#nullable disable

namespace SOS.FMS.Server.GBMSModels
{
    public partial class Dbview
    {
        public int Id { get; set; }
        public string Tbl { get; set; }
        public string Colm { get; set; }
        public string Type { get; set; }
        public short Length { get; set; }
        public short? Prec { get; set; }
        public int? Scale { get; set; }
        public short? Colorder { get; set; }
        public string Collation { get; set; }
        public int? Isnullable { get; set; }
    }
}
