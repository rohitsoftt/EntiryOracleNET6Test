using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Edi
    {
        public string EdiId { get; set; }
        public long? InvoiceNumber { get; set; }
        public string PoNumber { get; set; }
        public string PayItem { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal? GrossAmount { get; set; }
        public DateTime? ImportDate { get; set; }
    }
}
