using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempTsDetails10jun2021
    {
        public int TimesheetNumber { get; set; }
        public byte TimesheetRevision { get; set; }
        public DateTime WeekEndingDate { get; set; }
        public int DetailLineNumber { get; set; }
        public string PoNumber { get; set; }
        public decimal? StRate { get; set; }
        public decimal? NewRate { get; set; }
        public decimal? OldRate { get; set; }
        public decimal? Hours { get; set; }
        public string EarningsCode { get; set; }
        public decimal? RateAr { get; set; }
        public decimal? AmountBilled { get; set; }
        public decimal? RateAp { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? PreRrRateAr { get; set; }
        public decimal? PreRrAmountBilled { get; set; }
    }
}
