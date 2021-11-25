using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierContactType
    {
        public SupplierContactType()
        {
            SupplierContacts = new HashSet<SupplierContact>();
        }

        public int ContactTypeNumber { get; set; }
        public string ContactType { get; set; }
        public string ActiveFlag { get; set; }
        public byte? DisplayOrder { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public virtual ICollection<SupplierContact> SupplierContacts { get; set; }
    }
}
