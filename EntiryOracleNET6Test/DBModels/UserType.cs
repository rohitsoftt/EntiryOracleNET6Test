using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class UserType
    {
        public UserType()
        {
            People = new HashSet<Person>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
