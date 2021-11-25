using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class DmcRepBackup
    {
        public int? SeqNo { get; set; }
        public byte Year { get; set; }
        public string Month { get; set; }
        public string CostCenter { get; set; }
        public string PoNum { get; set; }
        public int? CandFileId { get; set; }
        public string CandLastName { get; set; }
        public string CandFirstName { get; set; }
        public string JobTitle { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public decimal? MaxStRate { get; set; }
        public decimal? MaxOtRate { get; set; }
        public decimal? MaxPrRate { get; set; }
        public DateTime? LastTsReceivedDate { get; set; }
        public string SupervisorLogin { get; set; }
        public string SupervisorLastName { get; set; }
        public string SupervisorFirstName { get; set; }
        public DateTime? TsEndDate { get; set; }
        public string EarningsCode { get; set; }
        public decimal? Hours { get; set; }
        public decimal? RgHours { get; set; }
        public decimal? OtHours { get; set; }
        public decimal? PrHours { get; set; }
        public decimal? RateAr { get; set; }
        public decimal? RateAp { get; set; }
        public decimal? AmountBilled { get; set; }
        public decimal? AmountBilledActual { get; set; }
        public decimal? AmountBilledExpense { get; set; }
        public decimal? AmountPaid { get; set; }
        public string SubLedger { get; set; }
        public string SubDivision { get; set; }
        public int? CycleProcessed { get; set; }
        public decimal? StRate { get; set; }
        public decimal? OtRate { get; set; }
        public decimal? Fee { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public decimal? InvoiceNumber { get; set; }
    }
}
