using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempRateReductionPo
    {
        public string PoNumber { get; set; }
        public decimal? NewBidRate { get; set; }
        public DateTime? EffectiveDate { get; set; }
    }
}
