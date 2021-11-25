using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SecurityCheck
    {
        public int BidNumber { get; set; }
        public DateTime? SecurityCheckInitiationDate { get; set; }
        public DateTime? SecurityCheckReceivedDate { get; set; }
        public DateTime? SecurityCheckRejectedDate { get; set; }
        public DateTime? SecurityCheckToYaleDate { get; set; }
        public DateTime? SecurityCheckWaivedDate { get; set; }
        public int? SecurityCheckWaivedBy { get; set; }

        public virtual Person SecurityCheckWaivedByNavigation { get; set; }
    }
}
