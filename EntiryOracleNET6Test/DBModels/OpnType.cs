using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OpnType
    {
        public OpnType()
        {
            Opns = new HashSet<Opn>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Opn> Opns { get; set; }
    }
}
