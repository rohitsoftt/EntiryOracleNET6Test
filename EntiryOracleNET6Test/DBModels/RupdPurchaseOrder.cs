using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RupdPurchaseOrder
    {
        public string PoNumber { get; set; }
        public int? PoRevision { get; set; }
        public int? PoLineNumber { get; set; }
        public string Dmltype { get; set; }
        public decimal? Snapid { get; set; }
        public byte[] ChangeVector { get; set; }
    }
}
