using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Temp4
    {
        public string PoNumber { get; set; }
        public int? FileId { get; set; }
        public string CdsId { get; set; }
        public int? PositionNumber { get; set; }
        public string Pspn { get; set; }
        public string ProcessedFlag { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
    }
}
