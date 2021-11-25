using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierCandfeed
    {
        public decimal? OrderNum { get; set; }
        public string Name { get; set; }
        public string SupplierId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal? CandFileId { get; set; }
        public string Bhstat { get; set; }
        public DateTime Bhcd { get; set; }
        public string Ohstat { get; set; }
        public DateTime? Ohcd { get; set; }
        public decimal BidNum { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public DateTime? DateRun { get; set; }
        public string Tstatus { get; set; }
    }
}
