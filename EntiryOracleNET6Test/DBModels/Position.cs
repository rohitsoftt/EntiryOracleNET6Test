using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Position
    {
        public Position()
        {
            Amendments = new HashSet<Amendment>();
            Deviations = new HashSet<Deviation>();
            PositionHistories = new HashSet<PositionHistory>();
            PositionMultiplierOptions = new HashSet<PositionMultiplierOption>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            TempPurchaseOrders = new HashSet<TempPurchaseOrder>();
        }

        public int PositionNumber { get; set; }
        public int? OrderNumber { get; set; }
        public int? SupervisorId { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
        public int? BidNumber { get; set; }
        public decimal? EccAmount { get; set; }
        public string InterviewRequiredFlag { get; set; }
        public string CustomerSupplierContactFlag { get; set; }
        public string NegativeExitReasonFlag { get; set; }
        public DateTime? OriginalStartDate { get; set; }
        public DateTime? LastDayWorked { get; set; }
        public int? CustomerContactId { get; set; }
        public byte? GradeLevel { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PositionStatus { get; set; }
        public string HoldCode { get; set; }
        public int? SupplierId { get; set; }
        public string SupplyBaseReductionFlag { get; set; }
        public string SupplierBuyoutFlag { get; set; }
        public string SupplierReplacedFlag { get; set; }
        public int? BackfillBidNumber { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public int? HiringManagerId { get; set; }

        public virtual Person CustomerContact { get; set; }
        public virtual GradeLevel GradeLevelNavigation { get; set; }
        public virtual HoldCode HoldCodeNavigation { get; set; }
        public virtual PositionStatus PositionStatusNavigation { get; set; }
        public virtual Person Supervisor { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Vacation Vacation { get; set; }
        public virtual ICollection<Amendment> Amendments { get; set; }
        public virtual ICollection<Deviation> Deviations { get; set; }
        public virtual ICollection<PositionHistory> PositionHistories { get; set; }
        public virtual ICollection<PositionMultiplierOption> PositionMultiplierOptions { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<TempPurchaseOrder> TempPurchaseOrders { get; set; }
    }
}
