using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OrderHistoryForddev
    {
        public int HistoryId { get; set; }
        public int? OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public byte? Issuance { get; set; }
        public string HoldCode { get; set; }
        public string StatusChangedFlag { get; set; }
        public string CostCenter { get; set; }
        public byte? GradeLevel { get; set; }
        public string OrderType { get; set; }
        public int? ProductCode { get; set; }
        public int? RequisitionerId { get; set; }
        public string WorkTask { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string OvertimePremiumFlag { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string DivisionCode { get; set; }
    }
}
