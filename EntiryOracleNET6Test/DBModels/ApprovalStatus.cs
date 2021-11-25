using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ApprovalStatus
    {
        public ApprovalStatus()
        {
            Approvals = new HashSet<Approval>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            TempPurchaseOrders = new HashSet<TempPurchaseOrder>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Approval> Approvals { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<TempPurchaseOrder> TempPurchaseOrders { get; set; }
    }
}
