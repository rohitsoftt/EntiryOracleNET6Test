using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempProductCodesRemap
    {
        public string OldProductCode { get; set; }
        public string BillingGroup { get; set; }
        public int NewProductCode { get; set; }
        public int? RefGrade { get; set; }
    }
}
