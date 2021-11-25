using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class PoQuarterTable
    {
        public string Quarter { get; set; }
        public DateTime? QtrStart { get; set; }
        public DateTime? QtrEnd { get; set; }
    }
}
