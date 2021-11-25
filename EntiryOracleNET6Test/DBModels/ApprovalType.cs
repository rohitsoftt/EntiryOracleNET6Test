using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ApprovalType
    {
        public ApprovalType()
        {
            Approvals = new HashSet<Approval>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Approval> Approvals { get; set; }
    }
}
