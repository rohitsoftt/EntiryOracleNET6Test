using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TimesheetAdjust
    {
        public int? TimesheetNumber { get; set; }
        public byte? TimesheetRevision { get; set; }
        public string CostCenter { get; set; }
        public string WorkTask { get; set; }
        public string PoNumberEarningsCode { get; set; }
        public string PoEarningsCodeSuffix { get; set; }
        public DateTime? WeekEndingDate { get; set; }
        public decimal? HoursWorked { get; set; }
        public decimal? HourlyRate { get; set; }
        public decimal? AmountBilled { get; set; }
        public string HoursOrExpenses { get; set; }
        public int? NewInvoiceNumber { get; set; }
        public int? OldInvoiceNumber { get; set; }
        public string SupplierJdeId { get; set; }
        public decimal? SupplierFee { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedTime { get; set; }
    }
}
