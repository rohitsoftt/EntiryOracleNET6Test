﻿using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TimesheetHeader
    {
        public TimesheetHeader()
        {
            TimesheetHours = new HashSet<TimesheetHour>();
        }

        public int TimesheetNumber { get; set; }
        public byte TimesheetRevision { get; set; }
        public string PoNumber { get; set; }
        public int ContracteeId { get; set; }
        public DateTime WeekEndingDate { get; set; }
        public string TimesheetStatus { get; set; }
        public int CreatedCycle { get; set; }
        public int? SubmittedCycle { get; set; }
        public int? ProcessedCycle { get; set; }
        public int SupplierId { get; set; }
        public string Notes { get; set; }
        public string AdjustmentReason { get; set; }
        public int? InvoiceNumber { get; set; }
        public int? SupervisorId { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime StatusDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string AcctOverrideFlag { get; set; }

        public virtual Person ApprovedByNavigation { get; set; }
        public virtual Candidate Contractee { get; set; }
        public virtual Cycle CreatedCycleNavigation { get; set; }
        public virtual Cycle ProcessedCycleNavigation { get; set; }
        public virtual Cycle SubmittedCycleNavigation { get; set; }
        public virtual Person Supervisor { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual TimesheetStatus TimesheetStatusNavigation { get; set; }
        public virtual ICollection<TimesheetHour> TimesheetHours { get; set; }
    }
}
