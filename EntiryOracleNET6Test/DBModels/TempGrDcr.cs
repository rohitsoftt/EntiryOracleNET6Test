using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempGrDcr
    {
        public decimal? SeqNo { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string CostCenter { get; set; }
        public string PoNum { get; set; }
        public int? CandFileId { get; set; }
        public string CanLastname { get; set; }
        public string CanFirstname { get; set; }
        public string JobTitle { get; set; }
        public DateTime? ContractSdate { get; set; }
        public DateTime? ContractEdate { get; set; }
        public decimal? MaxStRate { get; set; }
        public decimal? MaxOtRate { get; set; }
        public decimal? MaxPrRate { get; set; }
        public DateTime? LastTsReceivedDate { get; set; }
        public int? SupId { get; set; }
        public string SupLastname { get; set; }
        public string SupFirstname { get; set; }
        public DateTime? WeekEndingDate { get; set; }
        public string EarningsCode { get; set; }
        public decimal? Hours { get; set; }
        public decimal? RgHours { get; set; }
        public decimal? OtHours { get; set; }
        public decimal? PrHours { get; set; }
        public decimal? RateAr { get; set; }
        public decimal? RateAp { get; set; }
        public decimal? AmountBilled { get; set; }
        public decimal? AmountBilledActual { get; set; }
        public decimal? ExpensesBilled { get; set; }
        public decimal? AmountPaid { get; set; }
        public string MiscRef { get; set; }
        public string WorkTask { get; set; }
        public decimal? CycleProcessed { get; set; }
        public decimal? StRate { get; set; }
        public decimal? OtRate { get; set; }
        public decimal? Fee { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public decimal? InvoiceNumber { get; set; }
    }
}
