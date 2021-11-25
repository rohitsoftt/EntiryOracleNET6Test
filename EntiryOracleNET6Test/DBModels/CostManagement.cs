using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class CostManagement
    {
        public int CostMgmtId { get; set; }
        public int? DeviationNumber { get; set; }
        public string CostMgmtRequested { get; set; }
        public int? CostMgmtRequestorUserId { get; set; }
        public string CostMgmtComments { get; set; }
        public DateTime? StartDate { get; set; }
        public string CustomerConfirmationFlag { get; set; }
        public string CustomerComments { get; set; }
        public int? CustomerUserId { get; set; }
        public DateTime? CustomerUpdatedDate { get; set; }
        public string SupplierConfirmationFlag { get; set; }
        public string SupplierComments { get; set; }
        public int? SupplierUserId { get; set; }
        public DateTime? SupplierUpdatedDate { get; set; }

        public virtual Person CostMgmtRequestorUser { get; set; }
        public virtual Deviation DeviationNumberNavigation { get; set; }
        public virtual Person SupplierUser { get; set; }
    }
}
