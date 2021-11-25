using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class FeedSequence
    {
        public string SequenceCategory { get; set; }
        public string SequenceName { get; set; }
        public int? MinValue { get; set; }
        public long? MaxValue { get; set; }
        public int? IncrementBy { get; set; }
        public long? LastValue { get; set; }
        public string Wrap { get; set; }
    }
}
