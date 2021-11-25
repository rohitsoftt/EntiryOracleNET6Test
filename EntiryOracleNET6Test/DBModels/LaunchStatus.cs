using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class LaunchStatus
    {
        public LaunchStatus()
        {
            Transitions = new HashSet<Transition>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Transition> Transitions { get; set; }
    }
}
