using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempT
    {
        public int TimesheetNumber { get; set; }
        public byte TimesheetRevision { get; set; }
        public int HoursLineNumber { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? QuitTime { get; set; }
        public decimal? Hours { get; set; }
        public string BillableType { get; set; }
        public string WorkTask { get; set; }
        public decimal? ExpenseAmount { get; set; }
        public string ExpenseDescription { get; set; }
        public string ExpenseType { get; set; }
        public string AdjustmentFlag { get; set; }
        public string Shift { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string CostCenter { get; set; }
        public decimal? BreakTime { get; set; }
    }
}
