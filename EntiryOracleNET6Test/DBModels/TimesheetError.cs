using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TimesheetError
    {
        public int? GroupId { get; set; }
        public int? TimesheetNumber { get; set; }
        public byte? TimesheetRevision { get; set; }
        public string PoNumber { get; set; }
        public int? ContracteeId { get; set; }
        public DateTime? WeekEndingDate { get; set; }
        public string ErrorCategory { get; set; }
        public string ErrorDescription { get; set; }
    }
}
