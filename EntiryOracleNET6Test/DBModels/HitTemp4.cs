using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class HitTemp4
    {
        public decimal? UserId { get; set; }
        public decimal? ReportNo { get; set; }
        public DateTime? SubmitDate { get; set; }
        public int? OrderNumber { get; set; }
        public byte? Issuance { get; set; }
        public string SupplierName { get; set; }
        public int SupplierId { get; set; }
        public string RptBegin { get; set; }
        public string RptEnd { get; set; }
        public string CommodityBegin { get; set; }
        public string CommodityEnd { get; set; }
        public decimal? NumSubmitted { get; set; }
        public byte? Year { get; set; }
        public string Month { get; set; }
    }
}
