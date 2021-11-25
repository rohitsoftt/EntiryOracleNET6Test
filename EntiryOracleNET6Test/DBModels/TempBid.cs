using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempBid
    {
        public int? BidNumber { get; set; }
        public DateTime? BidReceivedDate { get; set; }
        public decimal? StRate { get; set; }
        public DateTime? ScDate { get; set; }
        public DateTime? CpDate { get; set; }
        public DateTime? RtcDate { get; set; }
        public DateTime? PrescrDate { get; set; }
        public DateTime? CirDate { get; set; }
        public DateTime? IvinternDate { get; set; }
        public DateTime? IvcustDate { get; set; }
        public DateTime? RebidDate { get; set; }
    }
}
