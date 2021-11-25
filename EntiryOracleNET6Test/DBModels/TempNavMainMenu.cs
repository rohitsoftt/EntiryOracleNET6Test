using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempNavMainMenu
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public string ImageId { get; set; }
        public string HImageId { get; set; }
        public string DefaultPage { get; set; }
    }
}
