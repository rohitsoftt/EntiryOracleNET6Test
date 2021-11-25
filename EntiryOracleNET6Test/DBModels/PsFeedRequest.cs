using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PsFeedRequest
    {
        public int? PsRequestNumber { get; set; }
        public int? Id { get; set; }
        public int? FeedId { get; set; }
        public string RequestedBy { get; set; }
        public string InitiatedBy { get; set; }
        public string PoNumber { get; set; }
        public string ContracteeCdsid { get; set; }
        public string CandidateLastName { get; set; }
        public string CandidateFirstName { get; set; }
        public string SupervisorCdsid { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? LocationCode { get; set; }
        public string PsComment { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
    }
}
