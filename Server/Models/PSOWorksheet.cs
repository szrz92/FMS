using System;

namespace SOS.FMS.Server.Models
{
    public class PSOWorksheet
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string CardNumber { get; set; }
        public string NameOnCard { get; set; }
        public string TxnAmount { get; set; }
        public string Rate { get; set; }
        public string Qty { get; set; }
        public string TxnTime { get; set; }
        public string Date { get; set; }
        public string MerchantName { get; set; }
        public string MerchantCity { get; set; }
        public string Product { get; set; }
    }
}