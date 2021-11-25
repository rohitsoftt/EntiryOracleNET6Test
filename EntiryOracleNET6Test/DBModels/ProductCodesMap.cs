using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ProductCodesMap
    {
        public int? OldProductCode { get; set; }
        public string OldBillingGroup { get; set; }
        public int? OldGrade { get; set; }
        public decimal? OldRate { get; set; }
        public int? NewCode { get; set; }
        public decimal? NewRate { get; set; }
        public int? NewGradeLevel { get; set; }
        public string OldBilingClass { get; set; }
    }
}
