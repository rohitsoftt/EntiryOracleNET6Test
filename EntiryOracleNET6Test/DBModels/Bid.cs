using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Bid
    {
        public Bid()
        {
            BackgroundVerifications = new HashSet<BackgroundVerification>();
            BidHistories = new HashSet<BidHistory>();
        }

        public int BidNumber { get; set; }
        public int? CandidateId { get; set; }
        public int? OrderNumber { get; set; }
        public byte? Issuance { get; set; }
        public int? SupplierId { get; set; }
        public decimal? StRate { get; set; }
        public decimal? OriginalRate { get; set; }
        public string DeclinedCode { get; set; }
        public string OtPremiumRequiredFlag { get; set; }
        public string RateOverTargetFlag { get; set; }
        public string PrescreenFlag { get; set; }
        public string PreapprovedFlag { get; set; }
        public string ResumeReviewedFlag { get; set; }
        public string InterviewWantedFlag { get; set; }
        public string EligibleUsWorkerFlag { get; set; }
        public string CustomerRetiree { get; set; }
        public string PrevCustomerPosFlag { get; set; }
        public string TransferViolationFlag { get; set; }
        public string PrevCustWorkNoViolation { get; set; }
        public string PrevCustomerManagers { get; set; }
        public string EmpReleaseReqFlag { get; set; }
        public decimal? RelocationExpense { get; set; }
        public decimal? InterviewExpense { get; set; }
        public DateTime? BidReceivedDate { get; set; }
        public string RecruiterName { get; set; }
        public string RecruiterPhone { get; set; }
        public string Availability { get; set; }
        public string ResumePath { get; set; }
        public string DeclinedComments { get; set; }
        public DateTime? BidFaxedDate { get; set; }
        public string BidStatus { get; set; }
        public byte? DaysToEligibility { get; set; }
        public DateTime? InterviewCompletedDate { get; set; }
        public string PhoneInterviewOnlyFlag { get; set; }
        public DateTime? InterviewAvailabilityDate { get; set; }
        public string EduRequired { get; set; }
        public string EduPreferred { get; set; }
        public string ExpRequired { get; set; }
        public string ExpPreferred { get; set; }
        public string SkillsRequired { get; set; }
        public string SkillsPreferred { get; set; }
        public string AdditionalInfo { get; set; }
        public string NoSsnReason { get; set; }
        public string ResumeComments { get; set; }
        public DateTime? PrevCustomerPosEndDate { get; set; }
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
        public string Udf7 { get; set; }
        public string Udf8 { get; set; }
        public string Udf9 { get; set; }
        public string Udf10 { get; set; }
        public string Udf11 { get; set; }

        public virtual BidStatus BidStatusNavigation { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual ICollection<BackgroundVerification> BackgroundVerifications { get; set; }
        public virtual ICollection<BidHistory> BidHistories { get; set; }
    }
}
