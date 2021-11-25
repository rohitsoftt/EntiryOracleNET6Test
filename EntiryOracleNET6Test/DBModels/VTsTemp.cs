using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VTsTemp
    {
        public int? TimesheetNumber { get; set; }
        public byte? TimesheetRevision { get; set; }
        public DateTime? WorkDate { get; set; }
        public decimal? THours { get; set; }
    }
}
