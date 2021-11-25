using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TasksForddev
    {
        public int TaskId { get; set; }
        public int? UserId { get; set; }
        public string ShortDescription { get; set; }
        public string PageUrl { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int? OrderNumber { get; set; }
        public string TaskCompleteFlag { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
    }
}
