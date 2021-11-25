using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempTreasonMap
    {
        public string NewReason { get; set; }
        public string OldReason { get; set; }
        public string IsNegative { get; set; }
        public int ReasonId { get; set; }
    }
}
