using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PsFeedDataTemp
    {
        public int Id { get; set; }
        public int FeedId { get; set; }
        public string PoNumber { get; set; }
        public int? OrderNumber { get; set; }
        public int? B2bPositionNumber { get; set; }
        public int? ContracteeId { get; set; }
        public string ContracteeCdsid { get; set; }
        public string CandidateLastName { get; set; }
        public string CandidateFirstName { get; set; }
        public int? SupervisorId { get; set; }
        public string SupervisorCdsid { get; set; }
        public string PositionTitle { get; set; }
        public int ProductCode { get; set; }
        public byte GradeLevel { get; set; }
        public string CostCenter { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LocationCode { get; set; }
        public string DivisionCode { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string SendFlag { get; set; }
        public string FeedComments { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }

        public virtual PsFeedMasterTemp Feed { get; set; }
    }
}
