using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class QaAccessType
    {
        public QaAccessType()
        {
            QaMessageAccesses = new HashSet<QaMessageAccess>();
        }

        public int AccessTypeCode { get; set; }
        public string AccessTypeDescription { get; set; }

        public virtual ICollection<QaMessageAccess> QaMessageAccesses { get; set; }
    }
}
