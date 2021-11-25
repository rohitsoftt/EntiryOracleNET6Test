using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempTargetRatesCpcUsford
    {
        public int? ProductCode { get; set; }
        public string Title { get; set; }
        public string Grade { get; set; }
        public string BillingGroup { get; set; }
        public decimal? OldRate { get; set; }
        public decimal? OldSupplierRate { get; set; }
        public decimal? NewRate { get; set; }
        public decimal? NewSupplierRate { get; set; }
        public string RegionCode { get; set; }
    }
}
