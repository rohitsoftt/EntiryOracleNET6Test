using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierQuality
    {
        public string SupplierId { get; set; }
        public string PoNum { get; set; }
        public decimal? PositionNum { get; set; }
        public string Cname { get; set; }
        public decimal? FileId { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string CategoryId { get; set; }
        public string Rating { get; set; }
    }
}
