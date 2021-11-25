using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempLocRegionRemap
    {
        public string LocationCode { get; set; }
        public string OldRegionCode { get; set; }
        public string NewRegionCode { get; set; }
    }
}
