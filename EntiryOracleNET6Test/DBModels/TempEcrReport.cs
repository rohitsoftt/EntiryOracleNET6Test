using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempEcrReport
    {
        public int? CustomerId { get; set; }
        public int? YearMonth { get; set; }
        public string Opnsloc { get; set; }
        public string Department { get; set; }
        public string PoNumber { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? PoStartDate { get; set; }
        public DateTime? PoEndDate { get; set; }
        public DateTime? MaxWeekEndingDate { get; set; }
        public int? SupervisorId { get; set; }
        public string GlobalCandidateCode { get; set; }
        public int? CandidateId { get; set; }
        public string GlobalSupplierCode { get; set; }
        public string SupplierCode { get; set; }
        public string JobTitle { get; set; }
        public string AccountCode { get; set; }
        public string SalaryGrade { get; set; }
        public decimal? SalaryGradeMaxRate { get; set; }
        public decimal? RegularRate { get; set; }
        public decimal? OvertimeRate { get; set; }
        public decimal? MtdRegularHours { get; set; }
        public decimal? MtdOvertimeHours { get; set; }
        public decimal? MtdPremiumHours { get; set; }
        public decimal? MtdAmountBilled { get; set; }
        public decimal? YtdRegularHours { get; set; }
        public decimal? YtdOvertimeHours { get; set; }
        public decimal? YtdPremiumHours { get; set; }
        public decimal? YtdAmountBilled { get; set; }
        public decimal? EstAnnualExpenditure { get; set; }
        public decimal? TotalNteAmount { get; set; }
        public string CurrencyCode { get; set; }
        public decimal? PremiumRate { get; set; }
        public decimal? MtdTravelHours { get; set; }
        public decimal? YtdTravelHours { get; set; }
        public decimal? MtdExpensesBilled { get; set; }
        public decimal? YtdExpensesBilled { get; set; }
    }
}
