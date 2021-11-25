using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TransitionError
    {
        public int TransitionErrorId { get; set; }
        public string ErrorDescription { get; set; }
        public long? ErrorNumber { get; set; }
        public int? LaunchId { get; set; }
        public string CandidateSsn { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
