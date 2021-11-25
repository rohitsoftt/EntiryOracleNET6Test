using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PositionSnapshotInfo
    {
        public int OrderNumber { get; set; }
        public int PositionNumber { get; set; }
        public byte Issuance { get; set; }
        public byte SubIssuance { get; set; }
        public string OrderType { get; set; }
        public string CostCenter { get; set; }
        public int? ContracteeId { get; set; }
        public int? SupplierId { get; set; }
        public int? RequisitionerId { get; set; }
        public int? SupervisorId { get; set; }
        public int? StaffingSpecialistId { get; set; }
        public int? CustomerId { get; set; }
        public int? LocationCode { get; set; }
        public string WorkBuilding { get; set; }
        public string WorkRoom { get; set; }
        public byte? GradeLevel { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? SupplierStRate { get; set; }
        public decimal? SupplierOtRate { get; set; }
        public decimal? CustomerOtRate { get; set; }
        public decimal? CustomerStRate { get; set; }
        public decimal? EccAmount { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ProductCode { get; set; }
        public decimal? CustomerFee { get; set; }
        public string WorkOrderNumber { get; set; }
    }
}
