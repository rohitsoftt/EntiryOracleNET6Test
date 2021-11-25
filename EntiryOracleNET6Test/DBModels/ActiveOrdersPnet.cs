using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ActiveOrdersPnet
    {
        public int? OrderNumber { get; set; }
        public string OrderStatus { get; set; }
        public int? PositionNumber { get; set; }
        public int? Issuance { get; set; }
        public int? SubIssuance { get; set; }
        public string PositionStatus { get; set; }
        public string ProcessedFlag { get; set; }
    }
}
