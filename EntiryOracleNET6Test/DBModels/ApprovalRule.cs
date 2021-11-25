using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ApprovalRule
    {
        public string CostCenter { get; set; }
        public string Role { get; set; }
        public byte NumberRequired { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public virtual ApproverRole RoleNavigation { get; set; }
    }
}
