using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class MvDcrDashboard
    {
        public string Month { get; set; }
        public byte Year { get; set; }
        public string JobTitle { get; set; }
        public string CostCenter { get; set; }
        public string CandidateName { get; set; }
        public int UserId { get; set; }
        public int ProductCode { get; set; }
        public string Compentency { get; set; }
        public decimal? AmountBilled { get; set; }
        public decimal? MonthNumber { get; set; }
    }
}
