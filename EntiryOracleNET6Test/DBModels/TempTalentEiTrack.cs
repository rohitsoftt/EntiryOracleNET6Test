using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempTalentEiTrack
    {
        public decimal Id { get; set; }
        public int OrderNumber { get; set; }
        public int PositionNumber { get; set; }
        public short Issuance { get; set; }
        public short SubIssuance { get; set; }
        public string Udf1 { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string CandidateId { get; set; }
        public string Cf1 { get; set; }
        public string Cf2 { get; set; }
    }
}
