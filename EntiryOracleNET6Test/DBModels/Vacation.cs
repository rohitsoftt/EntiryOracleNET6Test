using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Vacation
    {
        public int PositionNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? VacationBidNumber { get; set; }

        public virtual Position PositionNumberNavigation { get; set; }
    }
}
