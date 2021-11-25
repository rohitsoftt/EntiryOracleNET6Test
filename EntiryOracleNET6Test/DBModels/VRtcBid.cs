using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VRtcBid
    {
        public int? OrderNumber { get; set; }
        public byte? Issuance { get; set; }
        public decimal? RtcCount { get; set; }
        public DateTime? RtcDate { get; set; }
    }
}
