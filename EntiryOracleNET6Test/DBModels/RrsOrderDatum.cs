using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class RrsOrderDatum
    {
        public int RrsRecordId { get; set; }
        public int? RrsBatchId { get; set; }
        public string Ll4cdsid { get; set; }
        public string Deptcode { get; set; }
        public byte? Noofopenings { get; set; }
        public string Reportstocdsid { get; set; }
        public string Reqorganization { get; set; }
        public string Suppliercontact { get; set; }
        public string Contactcdsid { get; set; }
        public string Upgradeflag { get; set; }
        public string Candidate { get; set; }
        public int? Supplierid { get; set; }
        public string Companycar { get; set; }
        public string Miscref { get; set; }
        public string Accountcode { get; set; }
        public int? Productcode { get; set; }
        public string Positiondesc { get; set; }
        public string Skillsreq { get; set; }
        public string Eeprequired { get; set; }
        public string Eexppreferred { get; set; }
        public string Additionalinfo { get; set; }
        public string Startdate { get; set; }
        public byte? Durationunits { get; set; }
        public short? Contractorlocation { get; set; }
        public string Backgroundverification { get; set; }
        public string FeedStatus { get; set; }
        public string ExceptionStatus { get; set; }
        public string ExceptionComments { get; set; }
        public string ExceptionResolution { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedByDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? B2bOrderNumber { get; set; }
        public DateTime? SentDate { get; set; }
        public string Education { get; set; }
        public string Psoftpositionnumber { get; set; }
        public string Hiringmanagercdsid { get; set; }
        public string Specifiedsupplier { get; set; }
        public string Purchasedservicetopo { get; set; }
    }
}
