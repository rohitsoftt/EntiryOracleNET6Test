using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierAmendedPo
    {
        public string PoNum { get; set; }
        public int FileId { get; set; }
        public string SupplierId { get; set; }
        public int? Location { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? RptBeginDate { get; set; }
        public DateTime? RptEndDate { get; set; }
        public string AmendType { get; set; }
    }
}
