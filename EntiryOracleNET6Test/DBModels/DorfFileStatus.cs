using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class DorfFileStatus
    {
        public string DorfFeed { get; set; }
        public string Status { get; set; }
        public byte? GroupId { get; set; }
        public string Comments { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
