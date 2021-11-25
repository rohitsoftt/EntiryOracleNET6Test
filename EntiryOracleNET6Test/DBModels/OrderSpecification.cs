using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OrderSpecification
    {
        public int? OrderNumber { get; set; }
        public string CandidateLoginId { get; set; }
        public string CandidateFirstName { get; set; }
        public string CandidateLastName { get; set; }
        public string SupplierId { get; set; }
        public int? PositionNumber { get; set; }
    }
}
