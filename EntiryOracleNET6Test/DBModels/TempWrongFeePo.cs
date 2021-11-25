using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempWrongFeePo
    {
        public string PoNumber { get; set; }
        public string OldSupId { get; set; }
        public int FileId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? SupFee { get; set; }
        public string CategoryId { get; set; }
    }
}
