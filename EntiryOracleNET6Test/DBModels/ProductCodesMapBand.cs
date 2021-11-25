using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ProductCodesMapBand
    {
        public int? OldProductCode { get; set; }
        public string OldBillingGroup { get; set; }
        public string OldPrimarySec { get; set; }
        public int? OldGrade { get; set; }
        public string OldBandingYN { get; set; }
        public string OldJobCategory { get; set; }
        public decimal? OldMaxRate { get; set; }
        public string OldTitle { get; set; }
        public string PrimaryDesc { get; set; }
        public string SecondaryDesc { get; set; }
        public decimal? Rate { get; set; }
        public int? Grade { get; set; }
        public int? NewCode { get; set; }
        public string OldBand { get; set; }
    }
}
