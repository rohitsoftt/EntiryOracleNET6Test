using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VPostPoDev
    {
        public string PoNumber { get; set; }
        public int PoRevision { get; set; }
        public int PoLineNumber { get; set; }
        public int? OrderNumber { get; set; }
        public string OrderType { get; set; }
        public int? PositionNumber { get; set; }
        public decimal? StRate { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
        public string WorkTask { get; set; }
        public string PoStatus { get; set; }
        public int? ContracteeId { get; set; }
        public int? BidNumber { get; set; }
        public string CandName { get; set; }
        public string SupplierName { get; set; }
        public string SsName { get; set; }
        public DateTime? BidReceivedDate { get; set; }
        public int? DeviationNumber { get; set; }
        public string BidStatus { get; set; }
    }
}
