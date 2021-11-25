using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierLocation
    {
        public SupplierLocation()
        {
            SupplierContactPersonnel = new HashSet<SupplierContactPersonnel>();
        }

        public int SupplierLocationNumber { get; set; }
        public int SupplierId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Country { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Address4 { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<SupplierContactPersonnel> SupplierContactPersonnel { get; set; }
    }
}
