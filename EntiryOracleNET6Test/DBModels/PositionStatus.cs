using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PositionStatus
    {
        public PositionStatus()
        {
            Positions = new HashSet<Position>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}
