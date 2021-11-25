using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class GradeLevel
    {
        public GradeLevel()
        {
            Deviations = new HashSet<Deviation>();
            Positions = new HashSet<Position>();
            ProductCodes = new HashSet<ProductCode>();
            TargetRates = new HashSet<TargetRate>();
        }

        public byte GradeLevel1 { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Deviation> Deviations { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<ProductCode> ProductCodes { get; set; }
        public virtual ICollection<TargetRate> TargetRates { get; set; }
    }
}
