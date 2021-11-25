using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Appmenu
    {
        public byte Listorder { get; set; }
        public string Modulename { get; set; }
        public string Enabled { get; set; }
        public long? Authlevel { get; set; }
        public string Href { get; set; }
        public string Image { get; set; }
    }
}
