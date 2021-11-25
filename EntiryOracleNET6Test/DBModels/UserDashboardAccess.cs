using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class UserDashboardAccess
    {
        public int? UserId { get; set; }
        public int? DashboardViewId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual DashboardMaster DashboardView { get; set; }
        public virtual Person User { get; set; }
    }
}
