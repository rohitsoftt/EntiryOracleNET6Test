using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BroadcastGroup
    {
        public BroadcastGroup()
        {
            Algorithms = new HashSet<Algorithm>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Algorithm> Algorithms { get; set; }
    }
}
