using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TimesheetExportException
    {
        public int? TimesheetNumber { get; set; }
        public byte? TimesheetRevision { get; set; }
        public int? PoLineNumber { get; set; }
        public string PoNumber { get; set; }
        public string CostCenter { get; set; }
        public string OrderNumber { get; set; }
        public int? SupplierId { get; set; }
        public decimal? SupplierFee { get; set; }
        public string WorkTask { get; set; }
        public decimal? RateAr { get; set; }
        public string GroupCode { get; set; }
        public string WeekEndingDate { get; set; }
        public string EarningsCode { get; set; }
        public decimal? Hours { get; set; }
        public int? InvoiceNumber { get; set; }
        public string SupplierJdeId { get; set; }
        public int? ContracteeId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal? AmountBilled { get; set; }
        public string PoEarningsCodeSuffix { get; set; }
    }
}
