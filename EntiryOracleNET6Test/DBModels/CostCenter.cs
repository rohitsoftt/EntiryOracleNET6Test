using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class CostCenter
    {
        public CostCenter()
        {
            WorkOrders = new HashSet<WorkOrder>();
        }

        public string CostCenter1 { get; set; }
        public string DivisionCode { get; set; }
        public string Description { get; set; }
        public int? ReqDeveloperId { get; set; }
        public int? AccountManagerId { get; set; }
        public int? StaffingSpecialistId { get; set; }
        public string DepartmentId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string BackgroundVerificationFlag { get; set; }
        public string ActiveFlag { get; set; }
        public int? RenewalSubmitterId { get; set; }
        public int? SupplierRelationsId { get; set; }
        public int? ChannelPartnerId { get; set; }

        public virtual Person ReqDeveloper { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
