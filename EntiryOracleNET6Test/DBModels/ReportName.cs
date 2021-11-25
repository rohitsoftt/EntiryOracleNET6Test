using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ReportName
    {
        public int ReportId { get; set; }
        public string ReportName1 { get; set; }
        public int ReportGroupId { get; set; }
        public string ReportPath { get; set; }

        public virtual ReportGroup ReportGroup { get; set; }
    }
}
