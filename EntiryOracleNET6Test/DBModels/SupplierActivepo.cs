using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierActivepo
    {
        public string PoNum { get; set; }
        public decimal? PoRevision { get; set; }
        public string OrderOrdertype { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string LocName { get; set; }
        public string Requisitioner { get; set; }
        public string Opnsloc { get; set; }
        public string Dept { get; set; }
        public string Ais { get; set; }
        public string MiscRef { get; set; }
        public string ProductCode { get; set; }
        public string BillClass { get; set; }
        public decimal? Fee { get; set; }
        public decimal? PoNte { get; set; }
        public DateTime? PoCreateDate { get; set; }
        public string PoApprover { get; set; }
        public string ItemStatus { get; set; }
        public DateTime? ModDate { get; set; }
        public decimal? FileId { get; set; }
        public string Contractee { get; set; }
        public string Title { get; set; }
        public string ReportsToProfs { get; set; }
        public string Supervisor { get; set; }
        public string LineStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? StRate { get; set; }
        public decimal? OtRate { get; set; }
        public decimal? PremRate { get; set; }
        public DateTime? BeginRange { get; set; }
        public DateTime? EndRange { get; set; }
        public string BudgetNum { get; set; }
    }
}
