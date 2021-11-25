using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class FeedGroupSetting
    {
        public int GroupId { get; set; }
        public string SettingCategory { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
    }
}
