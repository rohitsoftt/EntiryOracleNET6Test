using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class InterviewFeedback
    {
        public int InterviewDetailsId { get; set; }
        public int? InterviewerId { get; set; }
        public int? InterviewRound { get; set; }
        public int? TaskId { get; set; }
        public string Comments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }

        public virtual InterviewDetail InterviewDetails { get; set; }
    }
}
