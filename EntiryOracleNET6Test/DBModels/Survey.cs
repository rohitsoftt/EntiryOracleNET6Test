using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Survey
    {
        public Survey()
        {
            SurveyQuestions = new HashSet<SurveyQuestion>();
        }

        public string SurveyCode { get; set; }
        public string SurveyName { get; set; }
        public string SurveyTypeCode { get; set; }
        public decimal? RresponseTime { get; set; }

        public virtual SurveyType SurveyTypeCodeNavigation { get; set; }
        public virtual ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    }
}
