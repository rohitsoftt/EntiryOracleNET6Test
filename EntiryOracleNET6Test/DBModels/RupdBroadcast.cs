using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RupdBroadcast
    {
        public int? BroadcastId { get; set; }
        public string Dmltype { get; set; }
        public decimal? Snapid { get; set; }
        public byte[] ChangeVector { get; set; }
    }
}
