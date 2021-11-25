using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class QaMessage
    {
        public int MessageNumber { get; set; }
        public int? ReferenceType { get; set; }
        public int? ReferenceNumber { get; set; }
        public int? AuthorId { get; set; }
        public string MessageBody { get; set; }
        public DateTime? Posted { get; set; }
        public DateTime? Validated { get; set; }
        public int? ModeratorId { get; set; }
        public string Response { get; set; }
        public DateTime? Expires { get; set; }
        public string RespondToAll { get; set; }

        public virtual QaReferenceType ReferenceTypeNavigation { get; set; }
    }
}
