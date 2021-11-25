using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BidsBidHistoryMv
    {
        public int BidNumber { get; set; }
        public DateTime? BidDate { get; set; }
        public DateTime? ScDate { get; set; }
        public DateTime? CpDate { get; set; }
        public DateTime? RtcDate { get; set; }
        public DateTime? PrescrDate { get; set; }
        public DateTime? IvRequestedDate { get; set; }
        public DateTime? IvCustDate { get; set; }
        public DateTime? IvRebidDate { get; set; }
        public decimal? BidRate { get; set; }
    }
}
