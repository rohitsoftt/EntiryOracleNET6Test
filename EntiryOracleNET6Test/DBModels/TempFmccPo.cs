using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempFmccPo
    {
        public string PoNumber { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? CurrentRate { get; set; }
        public decimal? NewRate { get; set; }
    }
}
