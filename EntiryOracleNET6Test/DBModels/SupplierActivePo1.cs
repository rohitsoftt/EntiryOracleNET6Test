using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierActivePo1
    {
        public string PoNum { get; set; }
        public int FileId { get; set; }
        public string SupplierId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateRun { get; set; }
        public string Opnsloc { get; set; }
        public string Dept { get; set; }
        public decimal? StRate { get; set; }
        public decimal? OtRate { get; set; }
        public decimal? PrRate { get; set; }
        public int? Location { get; set; }
        public string Commodity { get; set; }
        public string CandSsn { get; set; }
        public string CandName { get; set; }
        public string Title { get; set; }
        public string PsrName { get; set; }
        public string RtsName { get; set; }
        public decimal? Ot2Rate { get; set; }
        public decimal? Bill1Rate { get; set; }
        public decimal? Bill2Rate { get; set; }
    }
}
