using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TerminationReason
    {
        public TerminationReason()
        {
            ExitCancels = new HashSet<ExitCancel>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            TempPurchaseOrders = new HashSet<TempPurchaseOrder>();
        }

        public string TerminationReasonCode { get; set; }
        public string Description { get; set; }
        public string NegativeFlag { get; set; }

        public virtual ICollection<ExitCancel> ExitCancels { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<TempPurchaseOrder> TempPurchaseOrders { get; set; }
    }
}
