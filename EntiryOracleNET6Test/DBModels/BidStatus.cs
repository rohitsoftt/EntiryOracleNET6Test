using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BidStatus
    {
        public BidStatus()
        {
            Bids = new HashSet<Bid>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Bid> Bids { get; set; }
    }
}
