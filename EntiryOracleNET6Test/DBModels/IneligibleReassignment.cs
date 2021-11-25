using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class IneligibleReassignment
    {
        public int AmendmentNumber { get; set; }
        public int? TerminationCode { get; set; }
        public int? ContactCdsid { get; set; }
        public string BackfillFlag { get; set; }
        public string ContStartFlag { get; set; }
        public string InterviewFlag { get; set; }
        public string PosReqFlag { get; set; }
        public DateTime? LastDayWorked { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
