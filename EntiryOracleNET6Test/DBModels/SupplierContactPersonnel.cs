using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierContactPersonnel
    {
        public SupplierContactPersonnel()
        {
            SupplierContacts = new HashSet<SupplierContact>();
        }

        public int ContactNumber { get; set; }
        public int SupplierId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string Prefix { get; set; }
        public string Title { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public int? SupplierLocationNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string IsActiveFlag { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual SupplierLocation SupplierLocationNumberNavigation { get; set; }
        public virtual ICollection<SupplierContact> SupplierContacts { get; set; }
    }
}
