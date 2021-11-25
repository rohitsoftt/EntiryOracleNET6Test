using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ExitCancelTmp
    {
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public int? ContracteeId { get; set; }
        public string OldValue { get; set; }
        public DateTime? LastDayWorked { get; set; }
        public string ExitReason { get; set; }
        public string TerminationReasonCode { get; set; }
        public int PoLineNumber { get; set; }
        public string ProcessedFlag { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
