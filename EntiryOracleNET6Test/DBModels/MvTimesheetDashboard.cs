using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class MvTimesheetDashboard
    {
        public decimal? AmountBilled { get; set; }
        public decimal? AmountPaid { get; set; }
        public int? SupervisorId { get; set; }
        public string TimesheetStatus { get; set; }
        public string EarningsCode { get; set; }
        public decimal? Hours { get; set; }
        public string Title { get; set; }
        public string AgencyWorkerName { get; set; }
        public string CostCenter { get; set; }
        public string SupplierName { get; set; }
        public int? SupplierId { get; set; }
        public string Compentency { get; set; }
        public decimal? MonthNumber { get; set; }
        public string Month { get; set; }
        public decimal? Year { get; set; }
    }
}
