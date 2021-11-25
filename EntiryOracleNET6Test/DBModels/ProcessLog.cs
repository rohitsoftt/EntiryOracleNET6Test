using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ProcessLog
    {
        public int ProcessId { get; set; }
        public string ProcessType { get; set; }
        public string ProcessName { get; set; }
        public DateTime? ProcessStartDate { get; set; }
        public DateTime? ProcessEndDate { get; set; }
        public decimal? ProcessTime { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
    }
}
