using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RrsFeedError
    {
        public string FeedId { get; set; }
        public int? BidNumber { get; set; }
        public string Status { get; set; }
        public string Error { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
