using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class SupplierStanding2
    {
        public decimal OrderNum { get; set; }
        public decimal PosNum { get; set; }
        public string PosStatus { get; set; }
        public DateTime? OpenDt { get; set; }
        public string OrderType { get; set; }
        public DateTime? Bdate { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Location { get; set; }
        public byte? BroadcastLevel { get; set; }
        public DateTime? MinPosDate { get; set; }
        public string Incentive { get; set; }
        public string BillingGroup { get; set; }
        public string Title { get; set; }
        public string Div { get; set; }
        public byte? Issuance { get; set; }
        public byte? SubIssuance { get; set; }
        public string Name { get; set; }
        public string SupplierId { get; set; }
        public DateTime? DateRun { get; set; }
        public string Tstatus { get; set; }
    }
}
