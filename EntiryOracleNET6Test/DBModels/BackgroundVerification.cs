using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BackgroundVerification
    {
        public int HistoryId { get; set; }
        public int? CandidateId { get; set; }
        public int? OrderNumber { get; set; }
        public int? BidNumber { get; set; }
        public string BvInitiated { get; set; }
        public string BvRecd { get; set; }
        public string BvRejected { get; set; }
        public string BvToYale { get; set; }
        public string BvWaived { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? BvInitiateDate { get; set; }
        public DateTime? BvRecdDate { get; set; }
        public DateTime? BvRejectDate { get; set; }
        public DateTime? BvYaleDate { get; set; }
        public DateTime? BvWaivedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }

        public virtual Bid BidNumberNavigation { get; set; }
        public virtual Candidate Candidate { get; set; }
        public virtual Order OrderNumberNavigation { get; set; }
    }
}
