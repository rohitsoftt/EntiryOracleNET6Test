using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BillingGroup
    {
        public BillingGroup()
        {
            Algorithms = new HashSet<Algorithm>();
            Margins = new HashSet<Margin>();
            ProductCodes = new HashSet<ProductCode>();
            TargetRates = new HashSet<TargetRate>();
        }

        public string BillingGroupCode { get; set; }
        public string Description { get; set; }
        public int? Low { get; set; }
        public int? High { get; set; }
        public short? BidLimit { get; set; }
        public short? StdTimingDays { get; set; }

        public virtual ICollection<Algorithm> Algorithms { get; set; }
        public virtual ICollection<Margin> Margins { get; set; }
        public virtual ICollection<ProductCode> ProductCodes { get; set; }
        public virtual ICollection<TargetRate> TargetRates { get; set; }
    }
}
