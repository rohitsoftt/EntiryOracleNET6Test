using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierAlgorithmHistory
    {
        public int HistoryId { get; set; }
        public int SupplierId { get; set; }
        public int AlgorithmNumber { get; set; }
        public byte? AlgorithmDay { get; set; }
        public string DeletedFlag { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual SupplierAlgorithm SupplierAlgorithm { get; set; }
    }
}
