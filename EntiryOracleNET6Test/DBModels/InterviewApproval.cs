using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class InterviewApproval
    {
        public int InterviewApprovalId { get; set; }
        public int? InterviewDetailsId { get; set; }
        public string InternalUserComments { get; set; }
        public int? CustomerUserId { get; set; }
        public int? SuggestedInterveiwerId { get; set; }
        public int? SupplierUserId { get; set; }
        public string CustomerConfirmationFlag { get; set; }
        public DateTime? CustomerConfirmationDate { get; set; }
        public string CustomerComments { get; set; }
        public string SupplierConfirmationFlag { get; set; }
        public DateTime? SupplierConfirmationDate { get; set; }
        public string SupplierComments { get; set; }
        public int? TaskId { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
        public string Udf4 { get; set; }
        public string Udf5 { get; set; }

        public virtual InterviewDetail InterviewDetails { get; set; }
    }
}
