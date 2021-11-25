using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OpenOrdersRrsReport
    {
        public int? OrderNumber { get; set; }
        public string OrderType { get; set; }
        public string OrderStatus { get; set; }
        public string OrderStatusDescription { get; set; }
        public string OrderCreatedBy { get; set; }
        public byte? GradeLevel { get; set; }
        public string HoldCode { get; set; }
        public string HoldDescription { get; set; }
        public string DivisionCode { get; set; }
        public string DivisionDescription { get; set; }
        public int? DaysinstatusOld { get; set; }
        public int? Daysinstatus { get; set; }
        public string DaysRange { get; set; }
        public DateTime? RecdDt { get; set; }
        public int? PositionNumber { get; set; }
        public string PositionStatus { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? PositionOpenedDate { get; set; }
        public string CostCenter { get; set; }
        public string Location { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string ProductCode { get; set; }
        public string PrimaryDesc { get; set; }
        public string SecondaryDesc { get; set; }
        public string RequisitionerLoginId { get; set; }
        public string RequisitionerName { get; set; }
        public string RequisitionerPhoneNumber { get; set; }
        public string RequisitionerEmailAddress { get; set; }
        public string LoginId { get; set; }
        public string StaffingSpecialistName { get; set; }
        public string ReportsToCdsid { get; set; }
        public string ReportsToName { get; set; }
        public string ReportsToEmail { get; set; }
        public string AccountProfessName { get; set; }
        public DateTime? BroadcastDate { get; set; }
        public string BroadcastType { get; set; }
        public string CandidateName { get; set; }
        public int? Issuance { get; set; }
        public int? SubIssuance { get; set; }
        public string RegionCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? BroadcastDateDay999 { get; set; }
        public string UdfString1 { get; set; }
        public string UdfString2 { get; set; }
        public decimal? UdfNumber1 { get; set; }
        public decimal? UdfNumber2 { get; set; }
        public DateTime? UdfDate1 { get; set; }
        public DateTime? UdfDate2 { get; set; }
    }
}
