using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RrsHoliday
    {
        public DateTime HolidayDate { get; set; }
        public string HolidayName { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
