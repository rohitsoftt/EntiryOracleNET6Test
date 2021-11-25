using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Cycle
    {
        public Cycle()
        {
            TimesheetHeaderCreatedCycleNavigations = new HashSet<TimesheetHeader>();
            TimesheetHeaderProcessedCycleNavigations = new HashSet<TimesheetHeader>();
            TimesheetHeaderSubmittedCycleNavigations = new HashSet<TimesheetHeader>();
        }

        public int CycleNumber { get; set; }
        public int? FirstInvoice { get; set; }
        public int? LastInvoice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? PostByDate { get; set; }
        public DateTime? PostedDate { get; set; }
        public string CycleStatus { get; set; }
        public int? YearMonth { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }

        public virtual CycleStatus CycleStatusNavigation { get; set; }
        public virtual ICollection<TimesheetHeader> TimesheetHeaderCreatedCycleNavigations { get; set; }
        public virtual ICollection<TimesheetHeader> TimesheetHeaderProcessedCycleNavigations { get; set; }
        public virtual ICollection<TimesheetHeader> TimesheetHeaderSubmittedCycleNavigations { get; set; }
    }
}
