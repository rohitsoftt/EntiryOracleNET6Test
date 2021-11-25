using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class VRrsBidsDatum
    {
        public string MiscRef { get; set; }
        public int OrderNumber { get; set; }
        public int? SupplierId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StRate { get; set; }
        public string Availability { get; set; }
        public string CustomerRetiree { get; set; }
        public string PrevCustomerPosFlag { get; set; }
        public string TransferViolationFlag { get; set; }
        public string PrevCustomerManagers { get; set; }
        public string AdditionalInfo { get; set; }
        public string ResumePath { get; set; }
        public int BidNumber { get; set; }
        public int? CandidateId { get; set; }
    }
}
