using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TimesheetStatus
    {
        public TimesheetStatus()
        {
            TimesheetHeaders = new HashSet<TimesheetHeader>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<TimesheetHeader> TimesheetHeaders { get; set; }
    }
}
