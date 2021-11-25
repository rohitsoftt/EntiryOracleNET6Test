using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempNavSubMenu
    {
        public long PageId { get; set; }
        public string PagePath { get; set; }
        public long? GroupId { get; set; }
        public string LinkName { get; set; }
        public long? DisplayOrder { get; set; }
    }
}
