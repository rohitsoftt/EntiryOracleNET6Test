using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempPsPositionAmendment
    {
        public int? PositionNumber { get; set; }
        public int? OrderNumber { get; set; }
        public string PsPositionNumber { get; set; }
        public string TicketDetail { get; set; }
        public byte? Issuance { get; set; }
        public string PoNumber { get; set; }
        public int? PoLineNumber { get; set; }
        public string IsUpdated { get; set; }
    }
}
