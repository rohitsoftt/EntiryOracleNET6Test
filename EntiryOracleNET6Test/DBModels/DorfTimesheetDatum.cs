using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class DorfTimesheetDatum
    {
        public string DorfRecordId { get; set; }
        public int DorfBatchId { get; set; }
        public DateTime? FeedDate { get; set; }
        public int? PersonId { get; set; }
        public string CdsId { get; set; }
        public string PoNumber { get; set; }
        public int FileId { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime WeekEndingDate { get; set; }
        public string ShiftType { get; set; }
        public string BillableType { get; set; }
        public decimal? Hours { get; set; }
        public int HoursLineNumber { get; set; }
        public string ExpenseType { get; set; }
        public decimal? ExpenseAmount { get; set; }
        public string FeedComments { get; set; }
        public string FeedStatus { get; set; }
        public string ExceptionStatus { get; set; }
        public string ExceptionComments { get; set; }
        public string ExceptionResolution { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedByDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public byte? GroupId { get; set; }
    }
}
