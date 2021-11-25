using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierCandsub
    {
        public decimal OrderNum { get; set; }
        public string Name { get; set; }
        public string SupplierId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal CandFileId { get; set; }
        public string Title { get; set; }
        public decimal? StraightTime { get; set; }
        public string OvertimePremiumRequired { get; set; }
        public string OrderType { get; set; }
        public DateTime BidRecDate { get; set; }
        public string Status { get; set; }
        public string Div { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public DateTime? DateRun { get; set; }
        public string Tstatus { get; set; }
    }
}
