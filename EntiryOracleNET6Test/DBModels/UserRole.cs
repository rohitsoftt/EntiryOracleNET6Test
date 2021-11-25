using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class UserRole
    {
        public int AuthLevel { get; set; }
        public int UserTypeCode { get; set; }
        public string Description { get; set; }
        public string UsedFor { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual UserType UserTypeCodeNavigation { get; set; }
    }
}
