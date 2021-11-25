using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ReportJobParameter
    {
        public byte ParameterId { get; set; }
        public byte ReportId { get; set; }
        public byte? ParameterTypeId { get; set; }
        public string ParameterDesc { get; set; }
        public string ParameterValue { get; set; }

        public virtual ReportParameterType ParameterType { get; set; }
        public virtual ReportsJob Report { get; set; }
    }
}
