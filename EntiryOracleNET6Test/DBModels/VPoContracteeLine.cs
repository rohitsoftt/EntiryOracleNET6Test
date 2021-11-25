using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VPoContracteeLine
    {
        public string PoNumber { get; set; }
        public int? PoRevision { get; set; }
        public decimal? PoLineNumber { get; set; }
        public int? ContracteeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
