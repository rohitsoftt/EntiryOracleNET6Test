using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ContractItemCode
    {
        public string ProductCode { get; set; }
        public string ItemClassName { get; set; }
        public string MainCode { get; set; }
        public string SubCode { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string BillingClass { get; set; }
        public string BillingGroup { get; set; }
    }
}
