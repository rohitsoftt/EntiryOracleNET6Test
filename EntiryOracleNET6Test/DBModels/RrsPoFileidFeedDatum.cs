using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RrsPoFileidFeedDatum
    {
        public int Id { get; set; }
        public int FeedId { get; set; }
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public int? ContracteeId { get; set; }
        public int? BidNumber { get; set; }
        public int? SupplierId { get; set; }
        public string RrsPositionNumber { get; set; }
        public string SendFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
    }
}
