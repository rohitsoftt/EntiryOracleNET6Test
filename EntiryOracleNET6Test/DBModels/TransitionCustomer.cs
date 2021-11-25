using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TransitionCustomer
    {
        public int CustomerId { get; set; }
        public int LaunchId { get; set; }
        public string Notes { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public virtual Person Customer { get; set; }
        public virtual Transition Launch { get; set; }
    }
}
