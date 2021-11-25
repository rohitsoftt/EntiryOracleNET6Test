using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BillableType
    {
        public BillableType()
        {
            TimesheetHours = new HashSet<TimesheetHour>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }
        public string IsBillable { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }

        public virtual ICollection<TimesheetHour> TimesheetHours { get; set; }
    }
}
