using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VPoisedPosition
    {
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public DateTime? PoisDate { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
    }
}
