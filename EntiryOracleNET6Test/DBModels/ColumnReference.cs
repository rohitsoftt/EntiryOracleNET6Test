using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ColumnReference
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
    }
}
