using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VSupplierContactInfo
    {
        public int SupplierId { get; set; }
        public string ContactType { get; set; }
        public decimal? SupplierLocationNumber { get; set; }
        public decimal? ContactNumber { get; set; }
    }
}
