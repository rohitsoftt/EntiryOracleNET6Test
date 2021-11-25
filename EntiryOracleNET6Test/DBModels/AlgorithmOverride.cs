using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class AlgorithmOverride
    {
        public int OrderNumber { get; set; }
        public int PositionNumber { get; set; }
        public string TimingOverrideFlag { get; set; }
        public string IncludeAlgorithmFlag { get; set; }
        public string TimingOverrideReasonCode { get; set; }
    }
}
