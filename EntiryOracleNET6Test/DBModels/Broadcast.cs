using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Broadcast
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
        public string UndoBroadcastFlag { get; set; }

        public virtual BroadcastType BroadcastTypeNavigation { get; set; }
        public virtual Order OrderNumberNavigation { get; set; }
        public virtual AlgorithmOverrideReason TimingOverrideReasonNavigation { get; set; }
    }
}
