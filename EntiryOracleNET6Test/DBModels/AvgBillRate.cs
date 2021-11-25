using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class AvgBillRate
    {
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public string PositionStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? Trate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string GradeLevel { get; set; }
        public string BillingGroupCode { get; set; }
        public string Commodity { get; set; }
        public string OrderType { get; set; }
        public decimal? PoStrate { get; set; }
        public decimal? CustomerFee { get; set; }
        public decimal? PoBillrate { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
        public string CostCenter { get; set; }
        public string RegionCode { get; set; }
        public int? ProductCode { get; set; }
        public string DivisionCode { get; set; }
        public string CustomerRetiree { get; set; }
        public string BroadcastType { get; set; }
        public string BackfillStatus { get; set; }
    }
}
