using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PlacementTimingBfOld
    {
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string BillingGroupCode { get; set; }
        public int? OrderNumber { get; set; }
        public string OrderType { get; set; }
        public int? PositionNumber { get; set; }
        public string PositionStatus { get; set; }
        public byte? PositionIssuance { get; set; }
        public string CandFirstName { get; set; }
        public string CandLastName { get; set; }
        public string PrimaryDesc { get; set; }
        public string SecondaryDesc { get; set; }
        public string DivisionCode { get; set; }
        public int? ProductCode { get; set; }
        public byte? GradeLevel { get; set; }
        public string CostCenter { get; set; }
        public string LocationName { get; set; }
        public string RegionCode { get; set; }
        public int? SupervisorId { get; set; }
        public string BroadcastType { get; set; }
        public DateTime? BroadcastDate { get; set; }
        public DateTime? RequestedStartDate { get; set; }
        public DateTime? RecdDt { get; set; }
        public DateTime? HoldDt { get; set; }
        public DateTime? OrderApprovedDate { get; set; }
        public DateTime? BidDate { get; set; }
        public DateTime? ScDate { get; set; }
        public DateTime? CpDate { get; set; }
        public DateTime? RtcDate { get; set; }
        public DateTime? PrescrDate { get; set; }
        public DateTime? IvRequestedDate { get; set; }
        public DateTime? IvDelphiDate { get; set; }
        public decimal? BidRate { get; set; }
        public string PreapprovedFlag { get; set; }
        public decimal? TargetRate { get; set; }
        public string LoginId { get; set; }
        public decimal? RtcCount { get; set; }
        public DateTime? PosHistoryCreatedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? NoOfPositions { get; set; }
        public int? NoOfBids { get; set; }
        public DateTime? SecurityCheckIniDate { get; set; }
        public DateTime? SecurityCheckRecdDate { get; set; }
        public DateTime? IvRebidDate { get; set; }
        public DateTime? IvCustDate { get; set; }
        public int? RequisitionerId { get; set; }
        public string RequisitionerFirstName { get; set; }
        public string RequisitionerLastName { get; set; }
        public string InterviewRequiredFlag { get; set; }
        public string AdditionalInfo { get; set; }
        public string RateDeviations { get; set; }
        public string SupplierDeviations { get; set; }
        public string SupervisorFirstName { get; set; }
        public string SupervisorLastName { get; set; }
        public string RequestedSupplierContact { get; set; }
        public DateTime? PositionCreatedDate { get; set; }
        public int? CandidateId { get; set; }
        public byte? PositionSubIssuance { get; set; }
        public int? BidNumber { get; set; }
    }
}
