using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierAlgorithm
    {
        public SupplierAlgorithm()
        {
            SupplierAlgorithmHistories = new HashSet<SupplierAlgorithmHistory>();
        }

        public int SupplierId { get; set; }
        public int AlgorithmNumber { get; set; }
        public byte? AlgorithmDay { get; set; }
        public string DeletedFlag { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Algorithm AlgorithmNumberNavigation { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<SupplierAlgorithmHistory> SupplierAlgorithmHistories { get; set; }
    }
}
