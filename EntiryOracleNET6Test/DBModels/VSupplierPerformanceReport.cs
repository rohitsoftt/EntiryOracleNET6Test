using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VSupplierPerformanceReport
    {
        public string SupplierName { get; set; }
        public string PoNumber { get; set; }
        public string PositionDescription { get; set; }
        public string Description { get; set; }
        public string NegativeFlag { get; set; }
        public DateTime? MinStartDate { get; set; }
        public DateTime? MaxEndDate { get; set; }
    }
}
