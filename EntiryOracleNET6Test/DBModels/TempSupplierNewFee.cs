using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempSupplierNewFee
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public decimal? OldFee { get; set; }
        public int? NoOfPos { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal? NewFee { get; set; }
    }
}
