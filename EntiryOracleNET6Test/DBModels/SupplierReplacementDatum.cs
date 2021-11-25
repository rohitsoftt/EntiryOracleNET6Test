using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierReplacementDatum
    {
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public int? PoLineNumber { get; set; }
        public int? PoRevision { get; set; }
        public int? ContracteeId { get; set; }
        public string ContracteeName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? OldSupplierId { get; set; }
        public int? NewSupplierId { get; set; }
        public int? CustomerContactId { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
