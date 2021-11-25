using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class HitTemp1
    {
        public decimal? UserId { get; set; }
        public decimal? ReportNo { get; set; }
        public DateTime? SubmitDate { get; set; }
        public int? SupplierId { get; set; }
        public int? ProductCode { get; set; }
        public int? OrderNumber { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
        public string PoNumber { get; set; }
        public int? PositionNumber { get; set; }
        public DateTime? PoisedDate { get; set; }
        public string SupplierReplaced { get; set; }
        public int? ContracteeId { get; set; }
        public decimal? TargetRate { get; set; }
        public decimal? StRate { get; set; }
        public string LocationName { get; set; }
        public string RegionCode { get; set; }
        public string DivisionName { get; set; }
        public string OrderType { get; set; }
        public string RptBegin { get; set; }
        public string RptEnd { get; set; }
        public string CommodityBegin { get; set; }
        public string CommodityEnd { get; set; }
        public string CustomerRetiree { get; set; }
        public string CostCenter { get; set; }
        public string DivisionCode { get; set; }
        public string BillingGroupCode { get; set; }
        public string BillingGroupDesc { get; set; }
        public string BroadcastType { get; set; }
        public string PlacementType { get; set; }
        public byte? Year { get; set; }
        public string Month { get; set; }
    }
}
