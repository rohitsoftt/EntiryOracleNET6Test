using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempCostcenterAmendment
    {
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public int? CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string PoNumber { get; set; }
        public int? PoRevision { get; set; }
        public int? PoLineNumber { get; set; }
        public string OldCc { get; set; }
        public string NewCc { get; set; }
        public string OldWo { get; set; }
        public string NewWo { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
