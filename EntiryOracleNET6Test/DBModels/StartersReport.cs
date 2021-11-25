using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class StartersReport
    {
        public string PoNumber { get; set; }
        public int? OrderNumber { get; set; }
        public int? PoRevision { get; set; }
        public int? PoLineNumber { get; set; }
        public int? ContractorId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CostCenter { get; set; }
        public decimal? ProductCode { get; set; }
        public decimal? StRate { get; set; }
        public string ContracteeName { get; set; }
        public string ContractorCdsid { get; set; }
        public string SupervisorCdsid { get; set; }
        public string PositionTitle { get; set; }
        public string SupplierName { get; set; }
        public string PoStatus { get; set; }
        public DateTime? PoCreatedDate { get; set; }
        public int? SupplierId { get; set; }
        public string SupervisorName { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string OrderType { get; set; }
    }
}
