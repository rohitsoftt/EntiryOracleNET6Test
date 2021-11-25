using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SurveyQuestion
    {
        public string SurveyCode { get; set; }
        public byte QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public virtual Survey SurveyCodeNavigation { get; set; }
    }
}
