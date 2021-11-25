using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TsMappingPnet
    {
        public string PoNumber { get; set; }
        public int? CandidateId { get; set; }
        public DateTime? WeekEndingDate { get; set; }
        public string TsStatus { get; set; }
        public int? OldTsNumber { get; set; }
        public int? OldTsRevision { get; set; }
        public int? NewTsNumber { get; set; }
        public string RevisedFlag { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
