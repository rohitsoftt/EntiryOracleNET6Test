using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BidHistory
    {
        public int HistoryId { get; set; }
        public int? BidNumber { get; set; }
        public byte? Issuance { get; set; }
        public string BidStatus { get; set; }
        public string StatusChangedFlag { get; set; }
        public decimal? StRate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Bid BidNumberNavigation { get; set; }
    }
}
