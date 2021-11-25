using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OldPosPnet
    {
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public int? CandidateId { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
