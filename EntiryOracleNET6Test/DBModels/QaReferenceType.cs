using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class QaReferenceType
    {
        public QaReferenceType()
        {
            QaMessageAccesses = new HashSet<QaMessageAccess>();
            QaMessages = new HashSet<QaMessage>();
        }

        public int ReferenceTypeId { get; set; }
        public string ReferenceTypeDescription { get; set; }

        public virtual ICollection<QaMessageAccess> QaMessageAccesses { get; set; }
        public virtual ICollection<QaMessage> QaMessages { get; set; }
    }
}
