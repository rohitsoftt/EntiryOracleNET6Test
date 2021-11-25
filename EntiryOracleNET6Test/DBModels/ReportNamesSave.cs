using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ReportNamesSave
    {
        public int ReportId { get; set; }
        public string ReportName { get; set; }
        public int ReportGroupId { get; set; }
        public string ReportPath { get; set; }
    }
}
