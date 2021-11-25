using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Microsoftdtproperty
    {
        public decimal Id { get; set; }
        public decimal? Objectid { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }
        public byte[] Lvalue { get; set; }
        public decimal Version { get; set; }
    }
}
