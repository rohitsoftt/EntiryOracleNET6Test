using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PlacementTimingReport
    {
        public int? YearMonth { get; set; }
        public string CostCenter { get; set; }
        public string PlacementType { get; set; }
        public string BillingGroupCode { get; set; }
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public int? Issuance { get; set; }
        public int? SubIssuance { get; set; }
        public int? BidNumber { get; set; }
        public string OrderType { get; set; }
        public string PoNumber { get; set; }
        public string BroadcastType { get; set; }
        public string ProductCode { get; set; }
        public string PrimaryDesc { get; set; }
        public string SecondaryDesc { get; set; }
        public string PositionStatus { get; set; }
        public string PositionAdded { get; set; }
        public string RateDeviation { get; set; }
        public string SupplierDeviation { get; set; }
        public byte? GradeLevel { get; set; }
        public DateTime? RecdDate { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? HoldDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? RtbDate { get; set; }
        public DateTime? ObDate { get; set; }
        public DateTime? BroadcastDate { get; set; }
        public DateTime? ReqStartDate { get; set; }
        public DateTime? BidRecdDate { get; set; }
        public DateTime? BidPrescrnDate { get; set; }
        public DateTime? BidRtcDate { get; set; }
        public DateTime? BidCirDate { get; set; }
        public DateTime? BidIvcustDate { get; set; }
        public DateTime? BidIvpnetDate { get; set; }
        public DateTime? BidScDate { get; set; }
        public DateTime? BidCpDate { get; set; }
        public DateTime? BidRebidDate { get; set; }
        public DateTime? SecCheckIniDate { get; set; }
        public DateTime? SecCheckRecdDate { get; set; }
        public decimal? TargetRate { get; set; }
        public decimal? BidRate { get; set; }
        public decimal? BidOriginalRate { get; set; }
        public int? BidTotalCount { get; set; }
        public int? BidRtcCount { get; set; }
        public int? PositionCount { get; set; }
        public DateTime? PosStartDate { get; set; }
        public DateTime? PosEndDate { get; set; }
        public string StaffSpecId { get; set; }
        public string StaffSpecName { get; set; }
        public string SupervisorId { get; set; }
        public string SupervisorName { get; set; }
        public string RequisitionerId { get; set; }
        public string RequisitionerName { get; set; }
        public int? CandidateId { get; set; }
        public string CandName { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string LocationName { get; set; }
        public string RegionCode { get; set; }
        public string CustSuppContact { get; set; }
        public string PreApproved { get; set; }
        public decimal? ApprovalTiming { get; set; }
        public decimal? FirstBrdcastTiming { get; set; }
        public decimal? BrdcastTiming { get; set; }
        public decimal? BidRecdTiming { get; set; }
        public decimal? PnetReviewTiming { get; set; }
        public decimal? CustReviewTiming { get; set; }
        public decimal? InterviewTiming { get; set; }
        public decimal? BidPlacedTiming { get; set; }
        public decimal? OverallTiming { get; set; }
        public decimal? CustStandardTiming { get; set; }
        public decimal? TimingDiff { get; set; }
        public decimal? TimingDiffPercent { get; set; }
        public string ExcessCustTiming { get; set; }
        public decimal? RateDiff { get; set; }
        public decimal? RateDiffPercent { get; set; }
        public string RateRange { get; set; }
        public string AboveTarget { get; set; }
        public string ExcludeFlag { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
