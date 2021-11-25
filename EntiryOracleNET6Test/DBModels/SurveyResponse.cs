using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SurveyResponse
    {
        public int? SurveyResponseId { get; set; }
        public string SurveyCode { get; set; }
        public int? UserId { get; set; }
        public byte? QuestionNumber { get; set; }
        public string SurveyResultCode { get; set; }
        public string Comments { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? LocationCode { get; set; }
        public string DivisionCode { get; set; }

        public virtual Survey SurveyCodeNavigation { get; set; }
        public virtual Person User { get; set; }
    }
}
