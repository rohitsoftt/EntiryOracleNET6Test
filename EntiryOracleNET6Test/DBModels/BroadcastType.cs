using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BroadcastType
    {
        public BroadcastType()
        {
            Broadcasts = new HashSet<Broadcast>();
            Deviations = new HashSet<Deviation>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Broadcast> Broadcasts { get; set; }
        public virtual ICollection<Deviation> Deviations { get; set; }
    }
}
