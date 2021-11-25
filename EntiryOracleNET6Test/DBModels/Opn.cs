using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Opn
    {
        public int BroadcastId { get; set; }
        public int? OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public string OpnNotes { get; set; }
        public string OpnType { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual OpnType OpnTypeNavigation { get; set; }
    }
}
