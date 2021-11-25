using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class AlgorithmOverrideSupplier
    {
        public int OrderNumber { get; set; }
        public int SupplierId { get; set; }
        public int PositionNumber { get; set; }
        public string CandidateName { get; set; }
        public string IncludeFlag { get; set; }
        public string ExcludeFlag { get; set; }
        public string SpecifiedFlag { get; set; }
        public string ReasonCode { get; set; }
    }
}
