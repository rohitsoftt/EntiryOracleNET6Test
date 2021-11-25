using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class MvAmendmentDashboard
    {
        public string CostCenter { get; set; }
        public string PositionTitle { get; set; }
        public string Month { get; set; }
        public decimal? MonthNumber { get; set; }
        public decimal? Year { get; set; }
        public string AmendmentType { get; set; }
        public string Compentency { get; set; }
        public decimal? TotalAmendments { get; set; }
        public int? SupplierId { get; set; }
    }
}
