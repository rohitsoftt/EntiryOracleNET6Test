using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class BriefAttachment
    {
        public decimal AttachmentId { get; set; }
        public decimal BriefId { get; set; }
        public string AttachmentTitle { get; set; }
        public string AttachmentSize { get; set; }
        public string AttachmentPath { get; set; }
    }
}
