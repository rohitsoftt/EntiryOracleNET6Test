using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class AccountCodeImport
    {
        public decimal AccountCodeImportId { get; set; }
        public string CompanyCode { get; set; }
        public string WorkOrderNumber { get; set; }
        public string CostCenter { get; set; }
        public string Description { get; set; }
        public string NationalCompanyCode { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
