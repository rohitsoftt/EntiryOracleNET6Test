using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class CandidateIdCorrection
    {
        public string PoNumber { get; set; }
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LoginId { get; set; }
        public string Name { get; set; }
        public string CorrectCdsId { get; set; }
        public string Corrected { get; set; }
        public DateTime? CorrectedDate { get; set; }
    }
}
