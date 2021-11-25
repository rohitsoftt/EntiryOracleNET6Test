using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class InterviewDetailsHistory
    {
        public int InterviewDetailsHistoryId { get; set; }
        public int InterviewDetailsId { get; set; }
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public int? BidNumber { get; set; }
        public int? Issuance { get; set; }
        public int? InterviewRound { get; set; }
        public int? StaffingSpecialistId { get; set; }
        public int? RequisitionerId { get; set; }
        public int? SupervisorId { get; set; }
        public DateTime? InterviewInitiatedDate { get; set; }
        public int? InterviewRequestedBy { get; set; }
        public DateTime? InterviewProposedDate { get; set; }
        public DateTime? ActualInterviewDate { get; set; }
        public int? InterviewTakenBy { get; set; }
        public string InterviewMode { get; set; }
        public string InterveiwStatus { get; set; }
        public string InterviewPlace { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? TaskId { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
    }
}
