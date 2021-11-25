using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BroadcastDetail
    {
        public int BroadcastId { get; set; }
        public int SupplierId { get; set; }
        public string CandidateName { get; set; }
        public string ExcludedFlag { get; set; }
        public string IncludedFlag { get; set; }
        public string SpecifiedFlag { get; set; }
        public string PassFlag { get; set; }
        public decimal? MaxRate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string AlgorithmOverrideReason { get; set; }
    }
}
