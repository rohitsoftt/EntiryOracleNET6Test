using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RatecutChangePo
    {
        public string PoNumber { get; set; }
        public string ProcessedFlag { get; set; }
        public decimal? Rate { get; set; }
    }
}
