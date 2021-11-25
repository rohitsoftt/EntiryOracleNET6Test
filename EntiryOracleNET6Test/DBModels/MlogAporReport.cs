using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class MlogAporReport
    {
        public string CostCenter { get; set; }
        public string UdfString2 { get; set; }
        public string MRow { get; set; }
        public decimal? Sequence { get; set; }
        public DateTime? Snaptime { get; set; }
        public string Dmltype { get; set; }
        public string OldNew { get; set; }
        public byte[] ChangeVector { get; set; }
    }
}
