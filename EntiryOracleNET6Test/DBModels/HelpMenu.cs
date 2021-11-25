using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class HelpMenu
    {
        public HelpMenu()
        {
            HelpSubMenus = new HashSet<HelpSubMenu>();
        }

        public int HelpMenuId { get; set; }
        public string Description { get; set; }
        public string ActiveFlag { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }

        public virtual ICollection<HelpSubMenu> HelpSubMenus { get; set; }
    }
}
