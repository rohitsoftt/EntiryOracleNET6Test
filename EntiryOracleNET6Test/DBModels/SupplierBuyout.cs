using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierBuyout
    {
        public int SupplierId { get; set; }
        public int NewSupplierId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Supplier NewSupplier { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
