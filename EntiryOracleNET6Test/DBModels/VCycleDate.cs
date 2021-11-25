using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VCycleDate
    {
        public int? CycleNumber { get; set; }
        public DateTime? WeekStartDate { get; set; }
        public DateTime? WeekEndingDate { get; set; }
        public string CycleStatus { get; set; }
    }
}
