using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierHistory
    {
        public int HistoryId { get; set; }
        public int SupplierId { get; set; }
        public string SupplierStatus { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
