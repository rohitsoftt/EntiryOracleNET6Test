using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VMinstartMaxendMaxpoline
    {
        public string PoNumber { get; set; }
        public int? ContracteeId { get; set; }
        public int MaxPoRevision { get; set; }
        public DateTime? MinStartDate { get; set; }
        public DateTime? MaxEndDate { get; set; }
        public decimal? MaxPoLineNum { get; set; }
    }
}
