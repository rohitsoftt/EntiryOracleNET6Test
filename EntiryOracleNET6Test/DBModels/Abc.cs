using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Abc
    {
        public string Position { get; set; }
        public decimal? OrderNumOpportunities { get; set; }
        public decimal? OrderNumSuppliers { get; set; }
        public decimal? AlgExpectedHit { get; set; }
        public decimal? AlgHit { get; set; }
    }
}
