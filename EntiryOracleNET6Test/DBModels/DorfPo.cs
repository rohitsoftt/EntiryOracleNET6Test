using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class DorfPo
    {
        public string PoNumber { get; set; }
        public int FileId { get; set; }
        public string CdsId { get; set; }
        public int? PersonId { get; set; }
        public string ActiveFlag { get; set; }
        public byte? GroupId { get; set; }
        public DateTime? EffectiveDate { get; set; }
    }
}
