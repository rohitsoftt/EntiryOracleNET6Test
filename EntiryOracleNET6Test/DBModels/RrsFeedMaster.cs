using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RrsFeedMaster
    {
        public string FeedId { get; set; }
        public int? TotalRecords { get; set; }
        public int? TotalRecordsProcessed { get; set; }
        public int? TotalRecordsFail { get; set; }
        public string FeedStatus { get; set; }
        public string Recordsuploaded { get; set; }
        public string Recordsnotuploaded { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
