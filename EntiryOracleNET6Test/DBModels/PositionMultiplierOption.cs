using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PositionMultiplierOption
    {
        public PositionMultiplierOption()
        {
            PosMultiplierOptHistories = new HashSet<PosMultiplierOptHistory>();
        }

        public int PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public int PoRevision { get; set; }
        public int PoLineNumber { get; set; }
        public string MultiplierId { get; set; }
        public string MultiplierAllowedFlag { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual PurchaseOrder Po { get; set; }
        public virtual Position PositionNumberNavigation { get; set; }
        public virtual ICollection<PosMultiplierOptHistory> PosMultiplierOptHistories { get; set; }
    }
}
