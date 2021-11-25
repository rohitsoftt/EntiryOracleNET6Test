using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PosMultiplierOptHistory
    {
        public int HistoryId { get; set; }
        public int PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public int PoRevision { get; set; }
        public int PoLineNumber { get; set; }
        public string MultiplierId { get; set; }
        public string MultiplierAllowed { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PositionMultiplierOption PositionMultiplierOption { get; set; }
    }
}
