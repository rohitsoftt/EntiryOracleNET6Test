using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RrsCandidateCdsidFeedDatum
    {
        public int Id { get; set; }
        public int? FeedId { get; set; }
        public string PoNumber { get; set; }
        public int ContracteeId { get; set; }
        public string ContracteeCdsid { get; set; }
        public string CandidateLastName { get; set; }
        public string CandidateFirstName { get; set; }
        public string SupervisorCdsid { get; set; }
        public string SupervisorLastName { get; set; }
        public string SupervisorFirstName { get; set; }
        public string ProcessedFlag { get; set; }
        public string FeedComments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
    }
}
