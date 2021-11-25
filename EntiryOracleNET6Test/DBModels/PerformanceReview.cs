using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PerformanceReview
    {
        public string PoNumber { get; set; }
        public int ContracteeId { get; set; }
        public string CategoryCode { get; set; }
        public int ExitCancelId { get; set; }
        public DateTime ReviewDate { get; set; }
        public string RatingCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public virtual CategoryCode CategoryCodeNavigation { get; set; }
        public virtual Candidate Contractee { get; set; }
        public virtual ExitCancel ExitCancel { get; set; }
        public virtual RatingCode RatingCodeNavigation { get; set; }
    }
}
