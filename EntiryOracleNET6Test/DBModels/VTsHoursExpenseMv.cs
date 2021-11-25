using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VTsHoursExpenseMv
    {
        public decimal TimesheetNumber { get; set; }
        public decimal TimesheetRevision { get; set; }
        public string TimesheetStatus { get; set; }
        public decimal? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal? BillHours { get; set; }
        public decimal? NonbillHours { get; set; }
        public decimal? ExTravelAmount { get; set; }
        public decimal? ExLodgeAmount { get; set; }
        public decimal? ExFoodAmount { get; set; }
        public decimal? ExInterviewAmount { get; set; }
        public decimal? ExOtherAmount { get; set; }
        public decimal? ExTrainingAmount { get; set; }
        public decimal? ExTotalAmount { get; set; }
        public decimal? ExTktDomestic { get; set; }
        public decimal? ExTktAbroad { get; set; }
        public decimal? ExAccommodation { get; set; }
        public decimal? ExRentalCar { get; set; }
        public decimal? ExOther { get; set; }
        public decimal? ExAllowance { get; set; }
        public decimal? ExTravelKm { get; set; }
        public decimal? ExTravelOther { get; set; }
        public decimal? ExTravelSw { get; set; }
        public decimal? ExTravelNSw { get; set; }
    }
}
