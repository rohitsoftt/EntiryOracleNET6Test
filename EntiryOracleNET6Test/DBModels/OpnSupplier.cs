using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OpnSupplier
    {
        public int BroadcastId { get; set; }
        public int SupplierId { get; set; }
        public string PassFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
