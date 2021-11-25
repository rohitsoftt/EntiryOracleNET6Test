using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class MlogBid
    {
        public int? BidNumber { get; set; }
        public DateTime? Snaptime { get; set; }
        public string Dmltype { get; set; }
        public string OldNew { get; set; }
        public byte[] ChangeVector { get; set; }
    }
}
