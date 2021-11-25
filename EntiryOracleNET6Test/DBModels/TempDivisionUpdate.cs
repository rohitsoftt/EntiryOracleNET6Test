using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempDivisionUpdate
    {
        public string OldDivisionCode { get; set; }
        public string NewDivisionCode { get; set; }
        public string NewDivisionDescription { get; set; }
        public string CostCenter { get; set; }
        public string AporMonth { get; set; }
        public string AporYear { get; set; }
        public string Processed { get; set; }
        public string OrdersUpdated { get; set; }
        public string CostCenterUpdated { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
