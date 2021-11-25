using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TalentEiStaging
    {
        public decimal Id { get; set; }
        public string MatchId { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string JobOrderNumber { get; set; }
        public int? Positions { get; set; }
        public string OrderStatus { get; set; }
        public string DateOfOrderStatusChange { get; set; }
        public string OpportunityPostedDate { get; set; }
        public string CustomField1 { get; set; }
        public string CustomField2 { get; set; }
        public string CustomField3 { get; set; }
        public string CustomField4 { get; set; }
        public string CustomField5 { get; set; }
        public string CandidateEmail { get; set; }
        public string CandidateId { get; set; }
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public string DateOfMatch { get; set; }
        public string Status { get; set; }
        public string MsxStatus { get; set; }
        public string DateOfChange { get; set; }
        public int? DispositionCode { get; set; }
        public string UnacceptableDecline { get; set; }
        public string Submission { get; set; }
        public int? BidNumber { get; set; }
        public decimal? SubmissionRate { get; set; }
        public decimal? TargetRate { get; set; }
        public decimal? PraportionBidOfTarget { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
