using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierSpecificDatum
    {
        public int SupplierId { get; set; }
        public int CandidateId { get; set; }
        public int? PoNumber { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }
        public string Udf6 { get; set; }
        public string Udf7 { get; set; }
        public string Udf8 { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
