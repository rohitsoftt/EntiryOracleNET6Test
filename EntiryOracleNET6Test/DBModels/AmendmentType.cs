using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class AmendmentType
    {
        public AmendmentType()
        {
            Amendments = new HashSet<Amendment>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Amendment> Amendments { get; set; }
    }
}
