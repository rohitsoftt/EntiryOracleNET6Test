using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempItPosRemap
    {
        public int OrderNumber { get; set; }
        public int PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public int? ContracteeId { get; set; }
        public int? OldProductCode { get; set; }
        public int? NewProductCode { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
