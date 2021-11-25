using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class CandidateContractee
    {
        public int CandidateId { get; set; }
        public int UserId { get; set; }
        public string UserField1 { get; set; }
        public string UserField2 { get; set; }
        public string UserField3 { get; set; }
        public string UserField4 { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Person User { get; set; }
    }
}
