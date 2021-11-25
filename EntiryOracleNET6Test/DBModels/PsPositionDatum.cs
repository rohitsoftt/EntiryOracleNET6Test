using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PsPositionDatum
    {
        public int OrderNumber { get; set; }
        public int PositionNumber { get; set; }
        public byte Issuance { get; set; }
        public byte SubIssuance { get; set; }
        public string PsoftPositionNumber { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string UdfString1 { get; set; }
        public string UdfString2 { get; set; }
        public string UdfString3 { get; set; }
        public int? UdfNumber1 { get; set; }
        public int? UdfNumber2 { get; set; }
        public int? UdfNumber3 { get; set; }
        public DateTime? UdfDate1 { get; set; }
        public DateTime? UdfDate2 { get; set; }
        public DateTime? UdfDate3 { get; set; }

        public virtual Position PositionNumberNavigation { get; set; }
    }
}
