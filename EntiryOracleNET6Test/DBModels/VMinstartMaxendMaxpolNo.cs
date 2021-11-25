using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VMinstartMaxendMaxpolNo
    {
        public int? OrderNumber { get; set; }
        public string PoNum { get; set; }
        public int? ContracteeId { get; set; }
        public DateTime? MinStartDate { get; set; }
        public DateTime? MaxEndDate { get; set; }
        public decimal? MaxPoLineNum { get; set; }
        public int MaxPoRevision { get; set; }
    }
}
