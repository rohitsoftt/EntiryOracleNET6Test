using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ProductCode
    {
        public ProductCode()
        {
            Deviations = new HashSet<Deviation>();
            Orders = new HashSet<Order>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            TargetRates = new HashSet<TargetRate>();
            TempPurchaseOrders = new HashSet<TempPurchaseOrder>();
        }

        public int ProductCode1 { get; set; }
        public string BillingGroupCode { get; set; }
        public int? ProductMainCode { get; set; }
        public int? ProductSubCode { get; set; }
        public byte? GradeLevel { get; set; }
        public string PositionDescription { get; set; }
        public string RateCode { get; set; }
        public string SkillsRequired { get; set; }
        public string SkillsPreferred { get; set; }
        public string ExpRequired { get; set; }
        public string ExpPreferred { get; set; }
        public string EduRequired { get; set; }
        public string EduPreferred { get; set; }
        public string BackgroundVerificationFlag { get; set; }
        public string IsSelectableFlag { get; set; }
        public string RrFlag { get; set; }

        public virtual BillingGroup BillingGroupCodeNavigation { get; set; }
        public virtual GradeLevel GradeLevelNavigation { get; set; }
        public virtual ProductMain ProductMainCodeNavigation { get; set; }
        public virtual ProductSub ProductSubCodeNavigation { get; set; }
        public virtual ICollection<Deviation> Deviations { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<TargetRate> TargetRates { get; set; }
        public virtual ICollection<TempPurchaseOrder> TempPurchaseOrders { get; set; }
    }
}
