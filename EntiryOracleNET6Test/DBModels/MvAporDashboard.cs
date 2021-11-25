using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class MvAporDashboard
    {
        public string Month { get; set; }
        public decimal? Year { get; set; }
        public string JobTitle { get; set; }
        public string CostCenter { get; set; }
        public string Compentency { get; set; }
        public byte? SalaryGrade { get; set; }
        public decimal? TotalPo { get; set; }
        public decimal? MonthNumber { get; set; }
        public int? SupplierId { get; set; }
    }
}
