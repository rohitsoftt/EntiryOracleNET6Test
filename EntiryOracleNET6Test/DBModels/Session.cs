using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Session
    {
        public string Sessionid { get; set; }
        public string Applicationname { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Lockdate { get; set; }
        public decimal Lockid { get; set; }
        public decimal Timeout { get; set; }
        public decimal Locked { get; set; }
        public string Sessionitems { get; set; }
        public decimal Flags { get; set; }
    }
}
