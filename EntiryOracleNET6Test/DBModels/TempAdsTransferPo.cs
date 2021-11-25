using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempAdsTransferPo
    {
        public int? OrderNumber { get; set; }
        public string PoNumber { get; set; }
        public string OldCostCenter { get; set; }
        public string NewCostCenter { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
