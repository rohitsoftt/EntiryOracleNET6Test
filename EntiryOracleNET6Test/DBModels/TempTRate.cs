using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempTRate
    {
        public string RegionCode { get; set; }
        public string BillingGroupCode { get; set; }
        public byte GradeLevel { get; set; }
        public decimal? TargetRate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int ProductCode { get; set; }
        public decimal? SupplierTargetRate { get; set; }
    }
}
