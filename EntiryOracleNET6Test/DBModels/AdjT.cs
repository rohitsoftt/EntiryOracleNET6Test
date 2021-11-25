using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class AdjT
    {
        public string Remitduns { get; set; }
        public string PlantCode { get; set; }
        public string Docprefix { get; set; }
        public DateTime DocDate { get; set; }
        public decimal? DocTotal { get; set; }
        public string DebitCredit { get; set; }
        public string Currency { get; set; }
        public string Terms { get; set; }
        public decimal? Bol { get; set; }
        public string Po { get; set; }
        public string MultiPo { get; set; }
        public string MultiPlt { get; set; }
        public string DocType { get; set; }
        public string TsaDate { get; set; }
        public int Doc { get; set; }
    }
}
