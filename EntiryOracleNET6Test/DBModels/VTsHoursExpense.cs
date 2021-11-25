using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VTsHoursExpense
    {
        public int TimesheetNumber { get; set; }
        public byte TimesheetRevision { get; set; }
        public decimal? TotalBillHours { get; set; }
        public decimal? TotalNonBillHours { get; set; }
        public decimal? ExTravelAmount { get; set; }
        public decimal? ExLodgeAmount { get; set; }
        public decimal? ExFoodAmount { get; set; }
        public decimal? ExTotalAmount { get; set; }
    }
}
