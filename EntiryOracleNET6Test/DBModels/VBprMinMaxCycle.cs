using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VBprMinMaxCycle
    {
        public int? YearMonth { get; set; }
        public decimal? BprMonthNum { get; set; }
        public string BprMonth { get; set; }
        public decimal? BprYear { get; set; }
        public decimal? MinCycleNo { get; set; }
        public decimal? MaxCycleNo { get; set; }
        public DateTime? MinCycleStart { get; set; }
        public DateTime? MaxCycleEnd { get; set; }
    }
}
