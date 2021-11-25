using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ApprovalsForddev
    {
        public int ApprovalId { get; set; }
        public string ApprovalStatus { get; set; }
        public string ApprovalType { get; set; }
        public string ObjectId { get; set; }
        public string CostCenter { get; set; }
        public int? RequestorId { get; set; }
        public int? ApprovedBy { get; set; }
        public string Notes { get; set; }
        public string Comments { get; set; }
        public DateTime? NoticeDate { get; set; }
        public int? TaskId { get; set; }
        public string Role { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? TargetApprover { get; set; }
    }
}
