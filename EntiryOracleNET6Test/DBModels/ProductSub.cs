using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ProductSub
    {
        public ProductSub()
        {
            ProductCodes = new HashSet<ProductCode>();
        }

        public int ProductSubCode { get; set; }
        public string Description { get; set; }
        public string IsSelectableFlag { get; set; }

        public virtual ICollection<ProductCode> ProductCodes { get; set; }
    }
}
