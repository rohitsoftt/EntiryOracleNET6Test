using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VBroadcastsBroadcastDetail
    {
        public int BroadcastId { get; set; }
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
        public byte? BroadcastRound { get; set; }
        public string BroadcastType { get; set; }
        public DateTime? BroadcastDate { get; set; }
        public long? AlgorithmNumber { get; set; }
        public long? AlgorithmDay { get; set; }
        public string TimingOverrideReason { get; set; }
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
