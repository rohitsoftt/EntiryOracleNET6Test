using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class DelegationType
    {
        public DelegationType()
        {
            Delegations = new HashSet<Delegation>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Delegation> Delegations { get; set; }
    }
}
