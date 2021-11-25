using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VacationReplacement
    {
        public int VacationReplacementId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SpecifiedCandidateName { get; set; }
        public string SpecifiedSupplierName { get; set; }
        public string SameSupplierFlag { get; set; }
        public string CustomerSupplierContactFlag { get; set; }
        public string AllPreferredFlag { get; set; }
        public string InterviewRequiredFlag { get; set; }
        public int? RequisitionerId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ContactEmailAddress { get; set; }

        public virtual Person Requisitioner { get; set; }
    }
}
