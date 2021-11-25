using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Lookup
    {
        public string TableName { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime PreviousDate { get; set; }
    }
}
