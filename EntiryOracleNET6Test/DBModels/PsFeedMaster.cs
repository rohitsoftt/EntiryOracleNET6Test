using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PsFeedMaster
    {
        public int FeedId { get; set; }
        public string FeedName { get; set; }
        public DateTime? FeedDate { get; set; }
        public string FeedStatus { get; set; }
        public string Comments { get; set; }
    }
}
