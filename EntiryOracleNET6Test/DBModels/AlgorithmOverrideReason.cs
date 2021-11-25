using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class AlgorithmOverrideReason
    {
        public AlgorithmOverrideReason()
        {
            Broadcasts = new HashSet<Broadcast>();
        }

        public string ReasonCode { get; set; }
        public string ReasonType { get; set; }
        public string ReasonText { get; set; }
        public string IsValidFlag { get; set; }

        public virtual ICollection<Broadcast> Broadcasts { get; set; }
    }
}
