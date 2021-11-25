using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Candidate
    {
        public Candidate()
        {
            Amendments = new HashSet<Amendment>();
            BackgroundVerifications = new HashSet<BackgroundVerification>();
            Bids = new HashSet<Bid>();
            CandidateContractees = new HashSet<CandidateContractee>();
            Deviations = new HashSet<Deviation>();
            PerformanceReviews = new HashSet<PerformanceReview>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SupplierSpecificData = new HashSet<SupplierSpecificDatum>();
            TempPurchaseOrders = new HashSet<TempPurchaseOrder>();
            TimesheetHeaders = new HashSet<TimesheetHeader>();
        }

        public int CandidateId { get; set; }
        public string Ssn { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string CustomerRetireeFlag { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public virtual ICollection<Amendment> Amendments { get; set; }
        public virtual ICollection<BackgroundVerification> BackgroundVerifications { get; set; }
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual ICollection<CandidateContractee> CandidateContractees { get; set; }
        public virtual ICollection<Deviation> Deviations { get; set; }
        public virtual ICollection<PerformanceReview> PerformanceReviews { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SupplierSpecificDatum> SupplierSpecificData { get; set; }
        public virtual ICollection<TempPurchaseOrder> TempPurchaseOrders { get; set; }
        public virtual ICollection<TimesheetHeader> TimesheetHeaders { get; set; }
    }
}
