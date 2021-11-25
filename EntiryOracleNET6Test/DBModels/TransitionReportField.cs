using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TransitionReportField
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public string DisplayName { get; set; }
        public string TableInName { get; set; }
    }
}
