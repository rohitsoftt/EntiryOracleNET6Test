using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempReportingManager
    {
        public int? SNo { get; set; }
        public string CdsId { get; set; }
        public string PoNumber { get; set; }
        public decimal? FileId { get; set; }
        public string OldId { get; set; }
        public string NewId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
