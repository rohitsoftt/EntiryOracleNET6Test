using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class LocationRegionCode
    {
        public LocationRegionCode()
        {
            Algorithms = new HashSet<Algorithm>();
            Locations = new HashSet<Location>();
            TargetRates = new HashSet<TargetRate>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Algorithm> Algorithms { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<TargetRate> TargetRates { get; set; }
    }
}
