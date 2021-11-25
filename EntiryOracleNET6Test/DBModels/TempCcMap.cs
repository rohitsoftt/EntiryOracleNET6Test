using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TempCcMap
    {
        public string Unit { get; set; }
        public string Opsloc { get; set; }
        public string Dept { get; set; }
        public string CostCenter { get; set; }
        public string CurrentAccountManager { get; set; }
        public string CurrentStaffingSpecialist { get; set; }
        public string NewAccountManager { get; set; }
        public string NewStaffingSpecialist { get; set; }
        public int? NewAccountManagerId { get; set; }
        public int? NewStaffingSpecialistId { get; set; }
    }
}
