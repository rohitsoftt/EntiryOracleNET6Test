using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempProductCode
    {
        public int NewProductCode { get; set; }
        public string NewBillingGroup { get; set; }
        public int? NewGrade { get; set; }
        public string PrimaryDesc { get; set; }
        public string SecondaryDesc { get; set; }
        public decimal? Az02 { get; set; }
        public decimal? Mi01 { get; set; }
    }
}
