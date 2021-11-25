using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Delegation
    {
        public string ObjectId { get; set; }
        public int DelegatedFrom { get; set; }
        public int DelegatedTo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DelegationType { get; set; }

        public virtual Person DelegatedFromNavigation { get; set; }
        public virtual Person DelegatedToNavigation { get; set; }
        public virtual DelegationType DelegationTypeNavigation { get; set; }
    }
}
