using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PositionHistoryFordedev
    {
        public int HistoryId { get; set; }
        public int? PositionNumber { get; set; }
        public int? BidNumber { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
        public string PositionStatus { get; set; }
        public string StatusChangedFlag { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string HoldCode { get; set; }
        public int? SupplierId { get; set; }
        public string SupplyBaseReductionFlag { get; set; }
        public string SupplierBuyoutFlag { get; set; }
        public string SupplierReplacedFlag { get; set; }
        public int? SupervisorId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
    }
}
