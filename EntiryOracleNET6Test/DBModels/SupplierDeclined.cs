using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierDeclined
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public decimal CandFileId { get; set; }
        public string DeclinedCode { get; set; }
        public string Result { get; set; }
        public DateTime ChangedDate { get; set; }
        public int OrderNum { get; set; }
        public string Name { get; set; }
        public string SupplierId { get; set; }
        public string Div { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public DateTime? DateRun { get; set; }
        public string Tstatus { get; set; }
    }
}
