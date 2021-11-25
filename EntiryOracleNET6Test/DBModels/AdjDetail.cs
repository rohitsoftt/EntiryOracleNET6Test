using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class AdjDetail
    {
        public string Ponumbereces { get; set; }
        public string CostCenter { get; set; }
        public string WorkTask { get; set; }
        public decimal? RateAr { get; set; }
        public string GroupCode { get; set; }
        public DateTime WeekEndingDate { get; set; }
        public string HoursOrExpenses { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Amount { get; set; }
        public string NewInvoicenum { get; set; }
        public string Doc { get; set; }
    }
}
