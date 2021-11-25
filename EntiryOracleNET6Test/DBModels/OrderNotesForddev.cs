using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class OrderNotesForddev
    {
        public int OrderNotesId { get; set; }
        public int? OrderNumber { get; set; }
        public string Notes { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PositionNumber { get; set; }
        public int? BidNumber { get; set; }
        public int? ResponsibleId { get; set; }
    }
}
