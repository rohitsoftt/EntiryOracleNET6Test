using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class HitTempTable
    {
        public decimal? UserId { get; set; }
        public int? ReportNo { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string SupplierId { get; set; }
        public string AlgorithmName { get; set; }
        public string BillingGroup { get; set; }
        public int? OrderNum { get; set; }
        public int? Issuance { get; set; }
        public int? SubIssuance { get; set; }
        public string PoNum { get; set; }
        public int? PositionNum { get; set; }
        public DateTime? FilledDate { get; set; }
        public string SupplierReplaced { get; set; }
        public int? FileId { get; set; }
        public string OrderType { get; set; }
        public DateTime? RptBegin { get; set; }
        public DateTime? RptEnd { get; set; }
        public string CommodityBegin { get; set; }
        public string CommodityEnd { get; set; }
    }
}
