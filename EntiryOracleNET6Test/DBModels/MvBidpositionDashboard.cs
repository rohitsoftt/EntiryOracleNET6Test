using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class MvBidpositionDashboard
    {
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string OpnStatus { get; set; }
        public string Month { get; set; }
        public decimal? MonthNumber { get; set; }
        public decimal? Year { get; set; }
        public string CostCenter { get; set; }
        public string Title { get; set; }
    }
}
