using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Division
    {
        public Division()
        {
            People = new HashSet<Person>();
        }

        public string DivisionCode { get; set; }
        public string Description { get; set; }
        public string IsActiveFlag { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
