using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Renewal
    {
        public int RenewalId { get; set; }
        public string RenewalType { get; set; }
        public int OrderNumber { get; set; }
        public int PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public int ContracteeId { get; set; }
        public int SupplierId { get; set; }
        public string CostCenter { get; set; }
        public int? SupervisorId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? NteAmount { get; set; }
        public DateTime? NewEndDate { get; set; }
        public decimal? NewFunds { get; set; }
        public decimal? TsBilledAmount { get; set; }
        public decimal? TsApprovedAmount { get; set; }
        public decimal? TsPendingAmount { get; set; }
        public decimal? TsMissingAmount { get; set; }
        public string RenewalStatus { get; set; }
        public string JobStatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public DateTime? EmailNotifyDate { get; set; }
        public string RenewalNotes { get; set; }
        public string RejectReason { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
    }
}
