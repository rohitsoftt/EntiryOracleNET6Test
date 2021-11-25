using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RenewalRejectionReason
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }
        public decimal? DisplayOrder { get; set; }
    }
}
