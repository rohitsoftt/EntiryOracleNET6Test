using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RrsSupplierFeed
    {
        public string SupplierFeedId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Process { get; set; }
    }
}
