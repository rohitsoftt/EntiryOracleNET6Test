using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ProductRateCode
    {
        public string RateCode { get; set; }
        public string PositionDescription { get; set; }
        public string SkillsRequired { get; set; }
        public string SkillsPreferred { get; set; }
        public string ExpRequired { get; set; }
        public string ExpPreferred { get; set; }
        public string EduRequired { get; set; }
        public string EduPreferred { get; set; }
    }
}
