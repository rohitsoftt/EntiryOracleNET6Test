using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RegionCode
    {
        public RegionCode()
        {
            Suppliers = new HashSet<Supplier>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
