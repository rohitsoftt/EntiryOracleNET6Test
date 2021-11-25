using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PurchaseOrdersTalenteibckyp
    {
        public string PoNumber { get; set; }
        public int PoRevision { get; set; }
        public int PoLineNumber { get; set; }
        public int? OrderNumber { get; set; }
        public string OrderType { get; set; }
        public int? PositionNumber { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
        public string WorkTask { get; set; }
        public string PoStatus { get; set; }
        public string ApprovalStatus { get; set; }
        public int? ContracteeId { get; set; }
        public decimal? StRate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SupplierId { get; set; }
        public int? LocationCode { get; set; }
        public int? ProductCode { get; set; }
        public string CostCenter { get; set; }
        public decimal? CustomerFee { get; set; }
        public decimal? SupplierFee { get; set; }
        public string TerminationReasonCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public decimal? PoNte { get; set; }
        public string Udf5 { get; set; }
        public string Udf6 { get; set; }
        public int? RequisitionerId { get; set; }
        public decimal? RrFactor { get; set; }
    }
}
