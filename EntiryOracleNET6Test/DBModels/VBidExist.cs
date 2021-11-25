using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VBidExist
    {
        public int BroadcastId { get; set; }
        public int SupplierId { get; set; }
        public int BidNumber { get; set; }
        public string BidStatus { get; set; }
    }
}
