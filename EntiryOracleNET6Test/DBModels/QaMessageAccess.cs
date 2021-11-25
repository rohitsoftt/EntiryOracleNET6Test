using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class QaMessageAccess
    {
        public int UserId { get; set; }
        public int ReferenceTypeId { get; set; }
        public int? AccessTypeCode { get; set; }

        public virtual QaAccessType AccessTypeCodeNavigation { get; set; }
        public virtual QaReferenceType ReferenceType { get; set; }
    }
}
