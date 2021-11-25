using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BidBreakdownsHistory
    {
        public int BidBreakdownsHistoryId { get; set; }
        public int? BidNumber { get; set; }
        public decimal? StraightTimeRate { get; set; }
        public decimal? OvertimeMultiplier { get; set; }
        public decimal? HolidayMultiplier { get; set; }
        public decimal? ShiftPremiumMultiplier { get; set; }
        public decimal? Fica { get; set; }
        public decimal? Futa { get; set; }
        public decimal? Suta { get; set; }
        public decimal? WorkersCompCost { get; set; }
        public decimal? SingleBusinessTax { get; set; }
        public decimal? TotalVarExpenses { get; set; }
        public decimal? PaidTimeOff { get; set; }
        public decimal? HealthInsurance { get; set; }
        public decimal? LifeInsurance { get; set; }
        public decimal? TrainingCost { get; set; }
        public decimal? NonbillableWork { get; set; }
        public decimal? OtherSemivarExpenses { get; set; }
        public decimal? TotalSemivarExpenses { get; set; }
        public decimal? Selling { get; set; }
        public decimal? GeneralManagement { get; set; }
        public decimal? Recruiting { get; set; }
        public decimal? Facilities { get; set; }
        public decimal? OtherOpExpenses { get; set; }
        public decimal? TotalOpExpenses { get; set; }
        public decimal? TotalHourlyCosts { get; set; }
        public decimal? AdministrationCost { get; set; }
        public string AdditionalInfo { get; set; }
        public string SupplierRep { get; set; }
        public string Phone { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? SicknessCost { get; set; }
        public decimal? SupplierMarginPercent { get; set; }
        public string EmploymentStatus { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public int? DeviationNumber { get; set; }
        public string Comments { get; set; }
        public string BidType { get; set; }
    }
}
