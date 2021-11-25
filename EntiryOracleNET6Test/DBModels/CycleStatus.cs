﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class CycleStatus
    {
        public CycleStatus()
        {
            Cycles = new HashSet<Cycle>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Cycle> Cycles { get; set; }
    }
}
