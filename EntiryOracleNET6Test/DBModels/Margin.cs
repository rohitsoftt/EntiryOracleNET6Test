using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Margin
    {
        public string MarginType { get; set; }
        public string BillingGroup { get; set; }
        public int SupplierId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal? MarginValue { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public virtual BillingGroup BillingGroupNavigation { get; set; }
        public virtual MarginType MarginTypeNavigation { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
