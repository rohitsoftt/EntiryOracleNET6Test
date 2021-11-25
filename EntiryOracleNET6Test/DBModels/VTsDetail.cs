using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VTsDetail
    {
        public int TimesheetNumber { get; set; }
        public byte TimesheetRevision { get; set; }
        public decimal? RgHours { get; set; }
        public decimal? OtHours { get; set; }
        public decimal? Ot2Hours { get; set; }
        public decimal? PrHours { get; set; }
        public decimal? RgRateAp { get; set; }
        public decimal? OtRateAp { get; set; }
        public decimal? Ot2RateAp { get; set; }
        public decimal? PrRateAp { get; set; }
        public decimal? RgAmtPaid { get; set; }
        public decimal? OtAmtPaid { get; set; }
        public decimal? Ot2AmtPaid { get; set; }
        public decimal? PrAmtPaid { get; set; }
        public decimal? ExAmtPaid { get; set; }
        public decimal? RgRateAr { get; set; }
        public decimal? OtRateAr { get; set; }
        public decimal? Ot2RateAr { get; set; }
        public decimal? PrRateAr { get; set; }
        public decimal? RgAmtBilled { get; set; }
        public decimal? OtAmtBilled { get; set; }
        public decimal? Ot2AmtBilled { get; set; }
        public decimal? PrAmtBilled { get; set; }
        public decimal? ExAmtBilled { get; set; }
        public decimal? TotalAmtPaid { get; set; }
        public decimal? TotalAmtBilled { get; set; }
    }
}
