using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TransitionFieldDefault
    {
        public int LaunchId { get; set; }
        public int? SupervisorId { get; set; }
        public int? RequisitionerId { get; set; }
        public string CostCenter { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual Transition Launch { get; set; }
        public virtual Person Requisitioner { get; set; }
        public virtual Person Supervisor { get; set; }
    }
}
