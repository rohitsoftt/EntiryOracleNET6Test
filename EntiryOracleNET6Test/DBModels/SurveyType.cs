using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SurveyType
    {
        public SurveyType()
        {
            Surveys = new HashSet<Survey>();
        }

        public string SurveyTypeCode { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }
        public int NumberSkipsAllowed { get; set; }

        public virtual ICollection<Survey> Surveys { get; set; }
    }
}
