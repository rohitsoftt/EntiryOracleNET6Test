using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class FeedJob
    {
        public int CycleNumber { get; set; }
        public int GroupId { get; set; }
        public string JobName { get; set; }
        public string JobStatus { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string JobComments { get; set; }
    }
}
