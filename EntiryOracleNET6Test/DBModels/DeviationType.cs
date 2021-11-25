using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class DeviationType
    {
        public DeviationType()
        {
            Deviations = new HashSet<Deviation>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }
        public string DeviationLevel { get; set; }

        public virtual ICollection<Deviation> Deviations { get; set; }
    }
}
