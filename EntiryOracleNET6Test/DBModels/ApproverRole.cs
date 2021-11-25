using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ApproverRole
    {
        public ApproverRole()
        {
            ApprovalRules = new HashSet<ApprovalRule>();
            Approvals = new HashSet<Approval>();
            Approvers = new HashSet<Approver>();
            OrderResponsibilities = new HashSet<OrderResponsibility>();
            RenewalApprovers = new HashSet<RenewalApprover>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<ApprovalRule> ApprovalRules { get; set; }
        public virtual ICollection<Approval> Approvals { get; set; }
        public virtual ICollection<Approver> Approvers { get; set; }
        public virtual ICollection<OrderResponsibility> OrderResponsibilities { get; set; }
        public virtual ICollection<RenewalApprover> RenewalApprovers { get; set; }
    }
}
