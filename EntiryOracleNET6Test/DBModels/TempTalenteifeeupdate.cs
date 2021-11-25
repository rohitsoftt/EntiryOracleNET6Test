using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempTalenteifeeupdate
    {
        public string Ponumber { get; set; }
        public string PoNumber1 { get; set; }
        public int PoLineNumber { get; set; }
        public DateTime? MinStartDate { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? MaxEndDate { get; set; }
        public DateTime? Enddate { get; set; }
        public decimal? StRate { get; set; }
        public decimal? Strate1 { get; set; }
        public decimal? SupplierFee { get; set; }
        public string PoStatus { get; set; }
        public string Postatus1 { get; set; }
    }
}
