using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Fee
    {
        public int SupplierId { get; set; }
        public decimal? SupplierFee { get; set; }
        public decimal? CustomerFee { get; set; }
        public DateTime? EffectiveDate { get; set; }
    }
}
