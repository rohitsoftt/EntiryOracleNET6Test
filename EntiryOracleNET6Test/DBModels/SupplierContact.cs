using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierContact
    {
        public int ContactNumber { get; set; }
        public int ContactTypeNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual SupplierContactPersonnel ContactNumberNavigation { get; set; }
        public virtual SupplierContactType ContactTypeNumberNavigation { get; set; }
    }
}
