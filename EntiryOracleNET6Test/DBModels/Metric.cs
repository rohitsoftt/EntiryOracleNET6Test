using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Metric
    {
        public int MetricId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Subject { get; set; }
        public string Available { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FileLocation { get; set; }
        public bool ReportType { get; set; }
        public int? SupplierId { get; set; }
    }
}
