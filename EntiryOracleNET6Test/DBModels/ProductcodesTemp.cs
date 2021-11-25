using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ProductcodesTemp
    {
        public int ProductCode { get; set; }
        public string BillingGroupCode { get; set; }
        public int? ProductMainCode { get; set; }
        public int? ProductSubCode { get; set; }
        public byte? GradeLevel { get; set; }
        public string PositionDescription { get; set; }
        public string RateCode { get; set; }
        public string SkillsRequired { get; set; }
        public string SkillsPreferred { get; set; }
        public string ExpRequired { get; set; }
        public string ExpPreferred { get; set; }
        public string EduRequired { get; set; }
        public string EduPreferred { get; set; }
    }
}
