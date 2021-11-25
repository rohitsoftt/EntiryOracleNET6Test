using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OrdersForddev
    {
        public int OrderNumber { get; set; }
        public string OrderType { get; set; }
        public string PositionTitle { get; set; }
        public string Description { get; set; }
        public string WorkTask { get; set; }
        public DateTime? RequestedStartDate { get; set; }
        public byte? Issuance { get; set; }
        public string AdditionalSafetyInfo { get; set; }
        public string SafetyMaterialReqFlag { get; set; }
        public string StaffVacancyFlag { get; set; }
        public string GraspTrainingFlag { get; set; }
        public string HazcomTrainingFlag { get; set; }
        public string SecurityCheckRequiredFlag { get; set; }
        public int? RequisitionerId { get; set; }
        public decimal? TotalEccAmount { get; set; }
        public decimal? WeeklyStHours { get; set; }
        public decimal? WeeklyOtHours { get; set; }
        public string WorkHours { get; set; }
        public int? TravelPercent { get; set; }
        public string CostCenter { get; set; }
        public int? ProductCode { get; set; }
        public string AdditionalInfo { get; set; }
        public int? StaffingSpecialistId { get; set; }
        public int? ReqDeveloperId { get; set; }
        public int? AccountManagerId { get; set; }
        public byte? GradeLevel { get; set; }
        public int? LocationCode { get; set; }
        public string WorkBuilding { get; set; }
        public string WorkRoom { get; set; }
        public string HoldCode { get; set; }
        public string OrderStatus { get; set; }
        public string SkillsRequired { get; set; }
        public string SkillsPreferred { get; set; }
        public string EduRequired { get; set; }
        public string EduPreferred { get; set; }
        public string ExpRequired { get; set; }
        public string ExpPreferred { get; set; }
        public byte? Duration { get; set; }
        public string DurationUnits { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string OvertimePremiumFlag { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public DateTime? DefaultSubmitByDate { get; set; }
        public string PersonalQualities { get; set; }
        public string PrescreenFlag { get; set; }
        public short? BidLimit { get; set; }
        public string DivisionCode { get; set; }
    }
}
