using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ReportGroup
    {
        public ReportGroup()
        {
            ReportNames = new HashSet<ReportName>();
        }

        public int ReportGroupId { get; set; }
        public string ReportGroupName { get; set; }

        public virtual ICollection<ReportName> ReportNames { get; set; }
    }
}
