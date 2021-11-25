using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Location
    {
        public Location()
        {
            Deviations = new HashSet<Deviation>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            TempPurchaseOrders = new HashSet<TempPurchaseOrder>();
        }

        public int LocationCode { get; set; }
        public string LocationName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string RegionCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string GroupCode { get; set; }

        public virtual LocationRegionCode RegionCodeNavigation { get; set; }
        public virtual ICollection<Deviation> Deviations { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<TempPurchaseOrder> TempPurchaseOrders { get; set; }
    }
}
