using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OrderResponsibilitiesForddev
    {
        public int OrderResponsibilityId { get; set; }
        public int OrderNumber { get; set; }
        public string ApproverRole { get; set; }
        public int UserId { get; set; }
    }
}
