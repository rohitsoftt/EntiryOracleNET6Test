using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ReportsJob
    {
        public ReportsJob()
        {
            ReportJobParameters = new HashSet<ReportJobParameter>();
        }

        public byte ReportId { get; set; }
        public string ReportCode { get; set; }
        public string ReportDesc { get; set; }
        public string ReportType { get; set; }
        public string ReportFrequency { get; set; }
        public string ReportReadyToRun { get; set; }

        public virtual ICollection<ReportJobParameter> ReportJobParameters { get; set; }
    }
}
