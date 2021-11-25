using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempAporReport
    {
        public string Building { get; set; }
        public string Room { get; set; }
        public string SupplierName { get; set; }
        public string ProductMainDescription { get; set; }
        public string ProductSubDescription { get; set; }
        public int? CandidateId { get; set; }
        public string CandidateLastName { get; set; }
        public string CandidateFirstName { get; set; }
        public string PoNumber { get; set; }
        public DateTime? MinStartDate { get; set; }
        public DateTime? MaxEndDate { get; set; }
        public decimal? StRateSupplier { get; set; }
        public decimal? StRateCustomer { get; set; }
        public decimal? SupplierFee { get; set; }
        public decimal? CustomerFee { get; set; }
        public string WorkTask { get; set; }
        public string CostCenter { get; set; }
        public byte? GradeLevel { get; set; }
        public string LoginId { get; set; }
        public string PeopleLastName { get; set; }
        public string PeopleFirstName { get; set; }
        public decimal? Year { get; set; }
        public string Month { get; set; }
        public string ReportsTo { get; set; }
        public decimal? LocationCode { get; set; }
        public string LocationName { get; set; }
        public string CustomerRetiree { get; set; }
        public decimal? Invoice { get; set; }
        public decimal? InvoiceNumber { get; set; }
        public string DivisionCode { get; set; }
        public string MiscRef { get; set; }
        public int? SupplierId { get; set; }
        public int? PoLineNumber { get; set; }
        public int? PoRevision { get; set; }
        public decimal? PoNteAmount { get; set; }
        public string ReportsToId { get; set; }
        public decimal? UdfDecimal1 { get; set; }
        public decimal? UdfDecimal2 { get; set; }
        public decimal? UdfDecimal3 { get; set; }
        public decimal? UdfDecimal4 { get; set; }
        public decimal? UdfDecimal5 { get; set; }
        public int? UdfNumber1 { get; set; }
        public int? UdfNumber2 { get; set; }
        public int? UdfNumber3 { get; set; }
        public int? UdfNumber4 { get; set; }
        public int? UdfNumber5 { get; set; }
        public string UdfString1 { get; set; }
        public string UdfString2 { get; set; }
        public string UdfString3 { get; set; }
        public string UdfString4 { get; set; }
        public string UdfString5 { get; set; }
        public DateTime? UdfDate1 { get; set; }
        public DateTime? UdfDate2 { get; set; }
        public DateTime? UdfDate3 { get; set; }
        public DateTime? UdfDate4 { get; set; }
        public DateTime? UdfDate5 { get; set; }
        public int? OrderNumber { get; set; }
        public string OrderType { get; set; }
    }
}
