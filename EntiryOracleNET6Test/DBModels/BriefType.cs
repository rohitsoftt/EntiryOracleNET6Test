using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BriefType
    {
        public BriefType()
        {
            Briefs = new HashSet<Brief>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Brief> Briefs { get; set; }
    }
}
