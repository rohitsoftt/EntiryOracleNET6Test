using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class CategoryCode
    {
        public CategoryCode()
        {
            PerformanceReviews = new HashSet<PerformanceReview>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<PerformanceReview> PerformanceReviews { get; set; }
    }
}
