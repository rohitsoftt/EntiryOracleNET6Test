using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierContractFee
    {
        public int SupplierId { get; set; }
        public int VersionNumber { get; set; }
        public int RevisionNumber { get; set; }
        public decimal? SupplierFee { get; set; }
        public decimal? CustomerFee { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public decimal? AddlSuppFee { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
