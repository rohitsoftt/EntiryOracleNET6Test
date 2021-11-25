using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TemmSuppFee
    {
        public int SupplierId { get; set; }
        public decimal? VersionNumber { get; set; }
        public int RevisionNumber { get; set; }
        public decimal? SupplierFee { get; set; }
        public decimal? CustomerFee { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public decimal? AddlSuppFee { get; set; }
    }
}
