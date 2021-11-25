using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class MarginType
    {
        public MarginType()
        {
            Margins = new HashSet<Margin>();
        }

        public string MarginTypeCode { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Margin> Margins { get; set; }
    }
}
