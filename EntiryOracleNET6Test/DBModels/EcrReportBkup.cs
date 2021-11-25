using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class EcrReportBkup
    {
        public byte? Year { get; set; }
        public string Month { get; set; }
        public string CostCenter { get; set; }
        public string AccountCode { get; set; }
        public string PoNumber { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime? PoStartDate { get; set; }
        public DateTime? PoEndDate { get; set; }
        public DateTime? MaxWeekEndingDate { get; set; }
        public string SupervisorLoginId { get; set; }
        public string SupervisorName { get; set; }
        public int? CandidateFileId { get; set; }
        public string CandidateName { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string JobTitle { get; set; }
        public string SalaryGrade { get; set; }
        public decimal? SalaryGradeMaxRate { get; set; }
        public decimal? RegularRate { get; set; }
        public decimal? OvertimeRate { get; set; }
        public decimal? Overtime2Rate { get; set; }
        public decimal? PremiumRate { get; set; }
        public decimal? MtdRegularHours { get; set; }
        public decimal? MtdOvertimeHours { get; set; }
        public decimal? MtdOvertime2Hours { get; set; }
        public decimal? MtdPremiumHours { get; set; }
        public decimal? MtdTravelHours { get; set; }
        public decimal? MtdAmountBilled { get; set; }
        public decimal? MtdExpensesBilled { get; set; }
        public decimal? YtdRegularHours { get; set; }
        public decimal? YtdOvertimeHours { get; set; }
        public decimal? YtdOvertime2Hours { get; set; }
        public decimal? YtdPremiumHours { get; set; }
        public decimal? YtdTravelHours { get; set; }
        public decimal? YtdAmountBilled { get; set; }
        public decimal? YtdExpensesBilled { get; set; }
        public decimal? EstAnnualExpenditure { get; set; }
        public decimal? TotalNteAmount { get; set; }
        public decimal? Bill1Rate { get; set; }
        public decimal? Bill2Rate { get; set; }
        public decimal? MtdBill1Hours { get; set; }
        public decimal? MtdBill2Hours { get; set; }
        public decimal? YtdBill1Hours { get; set; }
        public decimal? YtdBill2Hours { get; set; }
    }
}
