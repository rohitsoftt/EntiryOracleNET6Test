using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Temp
    {
        public decimal? OldId { get; set; }
        public decimal? NewId { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
