using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierHold
    {
        public decimal OrderNum { get; set; }
        public decimal PosNum { get; set; }
        public string PosStatus { get; set; }
        public DateTime StatusDt { get; set; }
        public string HoldCode { get; set; }
        public string Description { get; set; }
        public string OrderType { get; set; }
        public DateTime? Bdate { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Div { get; set; }
        public string Name { get; set; }
        public string SupplierId { get; set; }
        public DateTime? DateRun { get; set; }
        public string Tstatus { get; set; }
    }
}
