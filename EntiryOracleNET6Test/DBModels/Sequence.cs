using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Sequence
    {
        public int CycleNumber { get; set; }
        public string SequenceCategory { get; set; }
        public string SequenceName { get; set; }
        public int? StartingValue { get; set; }
        public int? EndingValue { get; set; }
    }
}
