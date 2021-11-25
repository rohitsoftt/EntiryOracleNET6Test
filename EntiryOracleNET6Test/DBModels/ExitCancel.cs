using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ExitCancel
    {
        public ExitCancel()
        {
            PerformanceReviews = new HashSet<PerformanceReview>();
        }

        public int ExitCancelId { get; set; }
        public string CancelBeforeStartFlag { get; set; }
        public DateTime? LastDayWorked { get; set; }
        public string NoStartFlag { get; set; }
        public string ClosingPositionFlag { get; set; }
        public string CustomerSupplierContactFlag { get; set; }
        public string InterviewRequiredFlag { get; set; }
        public string ExitReason { get; set; }
        public int? CustomerContactId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string SpecifiedFlag { get; set; }
        public int? SupplierId { get; set; }
        public string CandidateName { get; set; }

        public virtual Person CustomerContact { get; set; }
        public virtual TerminationReason ExitReasonNavigation { get; set; }
        public virtual ICollection<PerformanceReview> PerformanceReviews { get; set; }
    }
}
