using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TransitionDetail
    {
        public string Ssn { get; set; }
        public int LaunchId { get; set; }
        public int? CandidateUserId { get; set; }
        public string CandidateLoginId { get; set; }
        public int? SupplierId { get; set; }
        public int? BidNumber { get; set; }
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public string DivisionCode { get; set; }
        public string SupervisorLoginId { get; set; }
        public string CostCenter { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? StRate { get; set; }
        public long? LocationCode { get; set; }
        public string WorkTask { get; set; }
        public string WorkBuilding { get; set; }
        public string CustomerPo { get; set; }
        public int? ProductCode { get; set; }
        public byte? GradeLevel { get; set; }
        public string ShiftPremiumFlag { get; set; }
        public string CustomerApprovalStatus { get; set; }
        public string SupplierConfirmed { get; set; }
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public string CandidateEmailAddress { get; set; }
        public string UnclassFirstName { get; set; }
        public string UnclassLastName { get; set; }
        public string UnclassLoginId { get; set; }
        public string UnclassEmailAddress { get; set; }
        public string UnclassPhone { get; set; }
        public int? UnclassUserId { get; set; }
        public int? UnclassLocationCode { get; set; }
        public string SupervisorFirstName { get; set; }
        public string SupervisorLastName { get; set; }
        public int? SupervisorUserId { get; set; }
        public string SupervisorEmailAddress { get; set; }
        public string SupervisorPhone { get; set; }
        public int? SupervisorLocationCode { get; set; }
        public decimal? EstimatedCandidateCost { get; set; }
        public string TransitionStatusFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string OvertimePremiumFlag { get; set; }
        public string Udf6 { get; set; }
        public string SubDivision { get; set; }
        public string PositionTitle { get; set; }
        public string UnclassOrganization { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
    }
}
