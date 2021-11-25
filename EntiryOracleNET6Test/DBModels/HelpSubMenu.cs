using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class HelpSubMenu
    {
        public int HelpSubMenuId { get; set; }
        public int HelpMenuId { get; set; }
        public string Description { get; set; }
        public string AttachedFileName { get; set; }
        public string AttachedFileType { get; set; }
        public string HtmlTextDescription { get; set; }
        public string ActiveFlag { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }

        public virtual HelpMenu HelpMenu { get; set; }
    }
}
