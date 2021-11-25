using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BillingIncrement
    {
        public int IncrementId { get; set; }
        public decimal? IncrementValue { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
