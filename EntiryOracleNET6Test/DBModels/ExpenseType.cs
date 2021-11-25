using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ExpenseType
    {
        public ExpenseType()
        {
            TimesheetHours = new HashSet<TimesheetHour>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<TimesheetHour> TimesheetHours { get; set; }
    }
}
