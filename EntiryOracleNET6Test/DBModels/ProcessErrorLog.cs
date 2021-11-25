using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ProcessErrorLog
    {
        public int ErrorLogId { get; set; }
        public string ProcedureName { get; set; }
        public DateTime? DateRaised { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string ErrorComments { get; set; }
    }
}
