using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Brief
    {
        public int BriefId { get; set; }
        public string BriefType { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateExpires { get; set; }
        public string BriefOrigin { get; set; }
        public string BriefSubject { get; set; }
        public string BriefText { get; set; }
        public string AvailableFlag { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual BriefType BriefTypeNavigation { get; set; }
    }
}
