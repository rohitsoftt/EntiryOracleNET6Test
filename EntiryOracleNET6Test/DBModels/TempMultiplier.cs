using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempMultiplier
    {
        public string MultiplierId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public string MultiplierType { get; set; }
        public decimal? MultiplierValue { get; set; }
        public byte? DisplayOrder { get; set; }
        public string MultiplierAllowedFlag { get; set; }
        public string IsSelectableFlag { get; set; }
        public string OrderType { get; set; }
    }
}
