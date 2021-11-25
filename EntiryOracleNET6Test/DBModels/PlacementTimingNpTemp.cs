using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PlacementTimingNpTemp
    {
        public DateTime? PositionStartDate { get; set; }
        public DateTime? PositionEndDate { get; set; }
        public string CustomerSupplierContactFlag { get; set; }
        public int? PositionNumber { get; set; }
        public string PositionStatus { get; set; }
        public int? PositionIssuance { get; set; }
        public DateTime? PositionOpenedDate { get; set; }
        public DateTime? PositionCreatedDate { get; set; }
        public string InterviewRequiredFlag { get; set; }
        public DateTime? PoshCreatedDate { get; set; }
        public DateTime? BidDate { get; set; }
        public decimal? BidRate { get; set; }
        public string PreapprovedFlag { get; set; }
        public DateTime? ScDate { get; set; }
        public DateTime? CpDate { get; set; }
        public DateTime? RtcDate { get; set; }
        public DateTime? PrescrDate { get; set; }
        public DateTime? IvRequestedDate { get; set; }
        public DateTime? IvRebidDate { get; set; }
        public DateTime? IvCustDate { get; set; }
        public int? OrderNumber { get; set; }
        public string OrderType { get; set; }
        public string DivisionCode { get; set; }
        public int? ProductCode { get; set; }
        public byte? GradeLevel { get; set; }
        public string CostCenter { get; set; }
        public DateTime? RequestedStartDate { get; set; }
        public int? RequisitionerId { get; set; }
        public string AdditionalInfo { get; set; }
        public int? RtcCount { get; set; }
        public string PoNumber { get; set; }
        public int? PoRevision { get; set; }
        public int? PoLineNumber { get; set; }
        public decimal? StRate { get; set; }
        public DateTime? PoStartDate { get; set; }
        public DateTime? PoEndDate { get; set; }
        public int? ContracteeId { get; set; }
        public string BillingGroupCode { get; set; }
        public string PrimaryDesc { get; set; }
        public string SecondaryDesc { get; set; }
        public string Location { get; set; }
        public string Region { get; set; }
        public decimal? TargetRate { get; set; }
        public int? SupervisorId { get; set; }
        public string LoginId { get; set; }
        public string RequisitionerFirstName { get; set; }
        public string RequisitionerLastName { get; set; }
        public string RateDeviations { get; set; }
        public string SupplierDeviation { get; set; }
        public DateTime? SecurityCheckIniDate { get; set; }
        public DateTime? SecurityCheckRecdDate { get; set; }
        public string SupplierName { get; set; }
        public int? SupplierId { get; set; }
        public string CandFirstName { get; set; }
        public string CandLastName { get; set; }
        public int? PosCount { get; set; }
        public int? BidCount { get; set; }
    }
}
