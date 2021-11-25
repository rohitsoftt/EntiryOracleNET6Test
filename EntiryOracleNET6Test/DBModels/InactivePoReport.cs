using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class InactivePoReport
    {
        public decimal InactivePoId { get; set; }
        public string PoNumber { get; set; }
        public int? ContracteeId { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ReportStatus { get; set; }
    }
}
