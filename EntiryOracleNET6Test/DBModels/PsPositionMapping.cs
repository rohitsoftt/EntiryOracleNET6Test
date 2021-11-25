using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PsPositionMapping
    {
        public int Id { get; set; }
        public int? PsFeedSeq { get; set; }
        public int? PsLastFeedSeq { get; set; }
        public string CandidateCdsid { get; set; }
        public int? CandidatePsPosNumber { get; set; }
        public string SupervisorCdsid { get; set; }
        public int? SupervisorPsPosNumber { get; set; }
        public DateTime? FeedDate { get; set; }
        public string ActiveFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
    }
}
