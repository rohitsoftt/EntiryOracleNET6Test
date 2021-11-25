using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OrderTasksForddev
    {
        public decimal OrderTaskId { get; set; }
        public int OrderNumber { get; set; }
        public string TaskTypeId { get; set; }
        public decimal? BidNumber { get; set; }
        public int? PositionNumber { get; set; }
        public string Request { get; set; }
        public int ResponsibleId { get; set; }
        public DateTime RespondDate { get; set; }
        public int? CompletedBy { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? TaskId { get; set; }
    }
}
