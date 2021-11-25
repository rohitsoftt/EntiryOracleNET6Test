using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Deviation
    {
        public Deviation()
        {
            CostManagements = new HashSet<CostManagement>();
        }

        public int DeviationNumber { get; set; }
        public int? OrderNumber { get; set; }
        public int? BidNumber { get; set; }
        public int? PositionNumber { get; set; }
        public byte? Issuance { get; set; }
        public int? CandidateId { get; set; }
        public int? StaffingsPecialistId { get; set; }
        public string DeviationType { get; set; }
        public string DeviationStatus { get; set; }
        public DateTime? StatusChangedDate { get; set; }
        public string DeviationPriority { get; set; }
        public int RequisitionerId { get; set; }
        public DateTime? TargetStartDate { get; set; }
        public DateTime? TargetEndDate { get; set; }
        public string BroadcastType { get; set; }
        public string OrderType { get; set; }
        public int? ProductCode { get; set; }
        public string CostCenter { get; set; }
        public int? LocationCode { get; set; }
        public int? SupplierId { get; set; }
        public string RecruiterName { get; set; }
        public decimal? SupplierStRate { get; set; }
        public decimal? CustomerStRate { get; set; }
        public decimal? SupplierStRateMax { get; set; }
        public decimal? CustomerFee { get; set; }
        public decimal? SupplierFee { get; set; }
        public int? IncumbentSupplierId { get; set; }
        public decimal? IncumbentSupplierRate { get; set; }
        public decimal? IncumbentCustomerRate { get; set; }
        public DateTime? RaIssuedDate { get; set; }
        public string RebidReceivedFlag { get; set; }
        public decimal? RebidStraightRate { get; set; }
        public string QualityRating { get; set; }
        public DateTime? PrecommitDate { get; set; }
        public int? RebidAcknowledgedBy { get; set; }
        public string ApprovedDeniedComments { get; set; }
        public string QualityComments { get; set; }
        public string BackgroundInfo { get; set; }
        public int SupervisorId { get; set; }
        public DateTime? BidBreakdownReceivedDate { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string RecentPoNumber { get; set; }
        public byte? GradeLevel { get; set; }
        public decimal? RecentRate { get; set; }
        public int? RecentCustomerRate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string AppDenCode { get; set; }
        public string CandidateName { get; set; }
        public DateTime? OrderRecdDate { get; set; }
        public DateTime? OrderBroadcastedDate { get; set; }
        public DateTime? BidReceivedDate { get; set; }
        public string BackgroundCheckReceivedFlag { get; set; }

        public virtual Person ApprovedByNavigation { get; set; }
        public virtual BroadcastType BroadcastTypeNavigation { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual DeviationStatus DeviationStatusNavigation { get; set; }
        public virtual DeviationType DeviationTypeNavigation { get; set; }
        public virtual GradeLevel GradeLevelNavigation { get; set; }
        public virtual Supplier IncumbentSupplier { get; set; }
        public virtual Location LocationCodeNavigation { get; set; }
        public virtual OrderType OrderTypeNavigation { get; set; }
        public virtual Position PositionNumberNavigation { get; set; }
        public virtual ProductCode ProductCodeNavigation { get; set; }
        public virtual QualityRating QualityRatingNavigation { get; set; }
        public virtual Person RebidAcknowledgedByNavigation { get; set; }
        public virtual Person Requisitioner { get; set; }
        public virtual Person StaffingsPecialist { get; set; }
        public virtual Person Supervisor { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<CostManagement> CostManagements { get; set; }
    }
}
