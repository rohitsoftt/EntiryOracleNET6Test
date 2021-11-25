using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempCostCentersUk
    {
        public string CostCenter { get; set; }
        public string DivisionCode { get; set; }
        public string Description { get; set; }
        public int? ReqDeveloperId { get; set; }
        public int? AccountManagerId { get; set; }
        public int? StaffingSpecialistId { get; set; }
        public string DepartmentId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string BackgroundVerificationFlag { get; set; }
    }
}
