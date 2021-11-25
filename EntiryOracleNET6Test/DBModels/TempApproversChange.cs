using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempApproversChange
    {
        public string CostCenter { get; set; }
        public string Department { get; set; }
        public string AccountProfessional { get; set; }
        public int? AccountProfessionalId { get; set; }
        public string OldCcs { get; set; }
        public int? OldCcsId { get; set; }
        public string NewCcs { get; set; }
        public int? NewCcsId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
