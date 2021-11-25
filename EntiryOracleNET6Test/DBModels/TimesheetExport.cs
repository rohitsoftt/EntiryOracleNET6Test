using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TimesheetExport
    {
        public string PoNumberEarningsCode { get; set; }
        public string WeekEndingDate { get; set; }
        public byte? RunNumber { get; set; }
        public decimal? HoursWorked { get; set; }
        public string HoursOrExpenses { get; set; }
        public string Century { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public int? InvoiceNumber { get; set; }
        public string CostCenter { get; set; }
        public string PrmuSign { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal? LineAmount { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedTime { get; set; }
        public int? TimesheetNumber { get; set; }
        public byte? TimesheetRevision { get; set; }
        public string WorkTask { get; set; }
        public string SupplierJdeId { get; set; }
        public decimal? SupplierFee { get; set; }
        public string PoEarningsCodeSuffix { get; set; }
    }
}
