using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Amendment
    {
        public int AmendmentNumber { get; set; }
        public int OrderNumber { get; set; }
        public int? PositionNumber { get; set; }
        public string PoNumber { get; set; }
        public string AmendmentType { get; set; }
        public string AmendmentStatus { get; set; }
        public int? ContracteeId { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string ApplyToAllFlag { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public decimal? PoLineNumber { get; set; }
        public string OrderType { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }

        public virtual AmendmentStatus AmendmentStatusNavigation { get; set; }
        public virtual AmendmentType AmendmentTypeNavigation { get; set; }
        public virtual Candidate Contractee { get; set; }
        public virtual Position PositionNumberNavigation { get; set; }
    }
}
