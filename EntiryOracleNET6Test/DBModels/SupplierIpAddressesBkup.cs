using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierIpAddressesBkup
    {
        public int SupplierId { get; set; }
        public string IpLow { get; set; }
        public string IpHigh { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
