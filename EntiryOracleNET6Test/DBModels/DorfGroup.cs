using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class DorfGroup
    {
        public byte GroupId { get; set; }
        public string GroupName { get; set; }
        public string FileName { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string ActiveFlag { get; set; }
    }
}
