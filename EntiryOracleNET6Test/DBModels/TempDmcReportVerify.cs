using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempDmcReportVerify
    {
        public string PoNum { get; set; }
        public int? CandFileId { get; set; }
        public DateTime? TsEndDate { get; set; }
        public int? TimesheetNumber { get; set; }
        public byte? TimesheetRevision { get; set; }
        public byte? DetailLineNumber { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
