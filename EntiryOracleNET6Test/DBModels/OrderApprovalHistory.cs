using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OrderApprovalHistory
    {
        public int HistoryId { get; set; }
        public int ApprovalId { get; set; }
        public int? OrderNumber { get; set; }
        public string ApprovalStatus { get; set; }
        public string CostCenter { get; set; }
        public int? RequestorId { get; set; }
        public string Notes { get; set; }
        public string Comments { get; set; }
        public string Role { get; set; }
        public int? TargetApprover { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Approval Approval { get; set; }
    }
}
