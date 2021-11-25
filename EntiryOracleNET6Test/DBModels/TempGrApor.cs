using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempGrApor
    {
        public int? CustomerId { get; set; }
        public int? YearMonth { get; set; }
        public string Opnsloc { get; set; }
        public string Department { get; set; }
        public string PoNumber { get; set; }
        public string GlobalCandidateCode { get; set; }
        public int? CandidateId { get; set; }
        public string GlobalSupplierCode { get; set; }
        public string SupplierCode { get; set; }
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public DateTime? MinStartDate { get; set; }
        public DateTime? MaxEndDate { get; set; }
        public decimal? RegularRate { get; set; }
        public decimal? OvertimeRate { get; set; }
        public decimal? PremiumRate { get; set; }
        public int? SupervisorId { get; set; }
        public string WorkTask { get; set; }
        public string SalaryGrade { get; set; }
        public string OccupationCode { get; set; }
        public string GlobalLocationCode { get; set; }
        public string AccountCode { get; set; }
        public string JobTitle { get; set; }
        public decimal? NteAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string Active { get; set; }
    }
}
