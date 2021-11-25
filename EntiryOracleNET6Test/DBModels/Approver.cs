using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Approver
    {
        public int UserId { get; set; }
        public string Role { get; set; }
        public string CostCenter { get; set; }
        public string DivisionCode { get; set; }
        public string PassiveApproverFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public byte? ApproverSequenceNumber { get; set; }
        public string Notes { get; set; }

        public virtual ApproverRole RoleNavigation { get; set; }
        public virtual Person User { get; set; }
    }
}
