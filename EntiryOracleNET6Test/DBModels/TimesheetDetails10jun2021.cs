using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TimesheetDetails10jun2021
    {
        public int DetailLineNumber { get; set; }
        public int TimesheetNumber { get; set; }
        public byte TimesheetRevision { get; set; }
        public string EarningsCode { get; set; }
        public string Shift { get; set; }
        public decimal? Hours { get; set; }
        public string AdjustedFlag { get; set; }
        public decimal? AmountBilled { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? CheckAmount { get; set; }
        public decimal? RateAr { get; set; }
        public decimal? RateAp { get; set; }
        public string CostCenter { get; set; }
        public string WorkTask { get; set; }
        public string PoEarningsCodeSuffix { get; set; }
        public decimal? PreRrRateAr { get; set; }
        public decimal? PreRrAmountBilled { get; set; }
        public string AisCode { get; set; }
        public string ProjectNumber { get; set; }
    }
}
