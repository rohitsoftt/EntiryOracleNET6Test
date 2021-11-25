using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VLastperiodBilledT
    {
        public string PoNumber { get; set; }
        public int? ContracteeId { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
