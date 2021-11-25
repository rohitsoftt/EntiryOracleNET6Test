using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TargetRate
    {
        public string RegionCode { get; set; }
        public string BillingGroupCode { get; set; }
        public byte GradeLevel { get; set; }
        public decimal? TargetRate1 { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int ProductCode { get; set; }
        public decimal? SupplierTargetRate { get; set; }

        public virtual BillingGroup BillingGroupCodeNavigation { get; set; }
        public virtual GradeLevel GradeLevelNavigation { get; set; }
        public virtual ProductCode ProductCodeNavigation { get; set; }
        public virtual LocationRegionCode RegionCodeNavigation { get; set; }
    }
}
