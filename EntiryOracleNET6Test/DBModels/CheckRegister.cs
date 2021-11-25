using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class CheckRegister
    {
        public string RegisterId { get; set; }
        public string JdeSupplierId { get; set; }
        public DateTime? WeekEndingDate { get; set; }
        public string CheckNumber { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? GrossAmount { get; set; }
        public long? InvoiceNumber { get; set; }
        public string PoNumber { get; set; }
        public string PayItem { get; set; }
        public decimal? TimesheetCount { get; set; }
        public DateTime? ImportDate { get; set; }
        public string Suffix { get; set; }
        public string WorkOrderNumber { get; set; }
        public int? GroupId { get; set; }
        public int? CycleNumber { get; set; }
    }
}
