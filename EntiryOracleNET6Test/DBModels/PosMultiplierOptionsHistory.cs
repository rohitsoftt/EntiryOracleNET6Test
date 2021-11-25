using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PosMultiplierOptionsHistory
    {
        public int HistoryId { get; set; }
        public int PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public int PoRevision { get; set; }
        public int PoLineNumber { get; set; }
        public string MultiplierId { get; set; }
        public string MultiplierAllowedFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
