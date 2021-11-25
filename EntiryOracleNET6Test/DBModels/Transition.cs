using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Transition
    {
        public Transition()
        {
            TransitionCustomers = new HashSet<TransitionCustomer>();
        }

        public int LaunchId { get; set; }
        public string LaunchName { get; set; }
        public string LaunchStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public virtual LaunchStatus LaunchStatusNavigation { get; set; }
        public virtual TransitionFieldDefault TransitionFieldDefault { get; set; }
        public virtual ICollection<TransitionCustomer> TransitionCustomers { get; set; }
    }
}
