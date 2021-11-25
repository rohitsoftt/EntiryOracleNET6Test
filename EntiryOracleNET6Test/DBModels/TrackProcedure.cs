using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TrackProcedure
    {
        public string Job { get; set; }
        public DateTime? DateRun { get; set; }
        public string Comments { get; set; }
    }
}
