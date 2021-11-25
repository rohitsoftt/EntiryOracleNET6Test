using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BidBucket
    {
        public int BidBucketNumber { get; set; }
        public string Ssn { get; set; }
        public int? OrderNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public byte? Issuance { get; set; }
        public int? SupplierId { get; set; }
        public decimal? StRate { get; set; }
        public decimal? OriginalRate { get; set; }
        public string OtPremiumRequiredFlag { get; set; }
        public string RateOverTargetFlag { get; set; }
        public decimal? RelocationExpense { get; set; }
        public decimal? InterviewExpense { get; set; }
        public DateTime? BidReceivedDate { get; set; }
        public string RecruiterName { get; set; }
        public string RecruiterPhone { get; set; }
        public string Availability { get; set; }
        public string ResumePath { get; set; }
        public DateTime? BidFaxedDate { get; set; }
        public string PreapprovedFlag { get; set; }
        public string ResumeReviewedFlag { get; set; }
        public string EligibleUsWorkerFlag { get; set; }
        public string CustomerRetiree { get; set; }
        public string EmpReleaseReqFlag { get; set; }
        public string PrevCustPositionFlag { get; set; }
        public string PrevCustomerManagers { get; set; }
        public string TransferViolationFlag { get; set; }
        public byte? DaysToEligibility { get; set; }
        public DateTime? InterviewCompletedDate { get; set; }
        public string PhoneInterviewOnlyFlag { get; set; }
        public string InterviewAvailabilityDate { get; set; }
        public string EduRequired { get; set; }
        public string EduPreferred { get; set; }
        public string ExpRequired { get; set; }
        public string ExpPreferred { get; set; }
        public string SkillsRequired { get; set; }
        public string SkillsPreferred { get; set; }
        public string AdditionalInfo { get; set; }
        public string NoSsnReason { get; set; }
        public string ResumeComments { get; set; }
        public DateTime? PrevCustPositionEndDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public DateTime? CandRetiredDate { get; set; }
        public string CandRetiredGrade { get; set; }
        public string InterviewNotes { get; set; }
        public string PrevCustPositionType { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string Udf6 { get; set; }
        public string WorkPermitFlag { get; set; }
        public string Nationality { get; set; }
    }
}
