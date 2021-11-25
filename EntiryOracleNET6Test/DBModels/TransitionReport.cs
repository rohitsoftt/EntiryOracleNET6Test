using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TransitionReport
    {
        public int UserId { get; set; }
        public string ReportName { get; set; }
        public string QueryText { get; set; }
        public string TransIds { get; set; }
        public string FieldIds { get; set; }
        public string SortOrder { get; set; }

        public virtual Person User { get; set; }
    }
}
