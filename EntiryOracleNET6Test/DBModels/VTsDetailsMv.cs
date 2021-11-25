using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VTsDetailsMv
    {
        public decimal TimesheetNumber { get; set; }
        public decimal TimesheetRevision { get; set; }
        public string TimesheetStatus { get; set; }
        public decimal? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal? RgHours { get; set; }
        public decimal? OtHours { get; set; }
        public decimal? Ot2Hours { get; set; }
        public decimal? PrHours { get; set; }
        public decimal? Bill1Hours { get; set; }
        public decimal? Bill2Hours { get; set; }
        public decimal? TravelHours { get; set; }
        public decimal? RgRateAp { get; set; }
        public decimal? OtRateAp { get; set; }
        public decimal? Ot2RateAp { get; set; }
        public decimal? PrRateAp { get; set; }
        public decimal? Bill1RateAp { get; set; }
        public decimal? Bill2RateAp { get; set; }
        public decimal? TravelRateAp { get; set; }
        public decimal? RgAmtPaid { get; set; }
        public decimal? OtAmtPaid { get; set; }
        public decimal? Ot2AmtPaid { get; set; }
        public decimal? PrAmtPaid { get; set; }
        public decimal? Bill1AmtPaid { get; set; }
        public decimal? Bill2AmtPaid { get; set; }
        public decimal? TravelAmtPaid { get; set; }
        public decimal? ExAmtPaid { get; set; }
        public decimal? RgRateAr { get; set; }
        public decimal? OtRateAr { get; set; }
        public decimal? Ot2RateAr { get; set; }
        public decimal? PrRateAr { get; set; }
        public decimal? Bill1RateAr { get; set; }
        public decimal? Bill2RateAr { get; set; }
        public decimal? TravelRateAr { get; set; }
        public decimal? RgAmtBilled { get; set; }
        public decimal? OtAmtBilled { get; set; }
        public decimal? Ot2AmtBilled { get; set; }
        public decimal? PrAmtBilled { get; set; }
        public decimal? Bill1AmtBilled { get; set; }
        public decimal? Bill2AmtBilled { get; set; }
        public decimal? TravelAmtBilled { get; set; }
        public decimal? ExAmtBilled { get; set; }
        public decimal? TotalAmtPaid { get; set; }
        public decimal? TotalAmtBilled { get; set; }
    }
}
