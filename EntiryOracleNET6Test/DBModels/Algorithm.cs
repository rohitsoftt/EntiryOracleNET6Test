using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Algorithm
    {
        public Algorithm()
        {
            SupplierAlgorithms = new HashSet<SupplierAlgorithm>();
        }

        public int AlgorithmNumber { get; set; }
        public string AlgorithmName { get; set; }
        public string ActiveFlag { get; set; }
        public string LocationRegionCode { get; set; }
        public string BillingGroup { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string BroadcastGroupCode { get; set; }

        public virtual BillingGroup BillingGroupNavigation { get; set; }
        public virtual BroadcastGroup BroadcastGroupCodeNavigation { get; set; }
        public virtual LocationRegionCode LocationRegionCodeNavigation { get; set; }
        public virtual ICollection<SupplierAlgorithm> SupplierAlgorithms { get; set; }
    }
}
