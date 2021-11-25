using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class ReportParameterType
    {
        public ReportParameterType()
        {
            ReportJobParameters = new HashSet<ReportJobParameter>();
        }

        public byte ParameterTypeId { get; set; }
        public string ParamaterTypeCode { get; set; }
        public string ParameterTypeDesc { get; set; }

        public virtual ICollection<ReportJobParameter> ReportJobParameters { get; set; }
    }
}
