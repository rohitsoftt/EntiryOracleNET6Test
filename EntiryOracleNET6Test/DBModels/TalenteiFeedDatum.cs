using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class TalenteiFeedDatum
    {
        public decimal? FeedRecordId { get; set; }
        public decimal? FeedId { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Title { get; set; }
        public int Jobordernumber { get; set; }
        public string Description { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public decimal? Targetrate { get; set; }
        public decimal? Hoursperweek { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Hiringmanagerfirstname { get; set; }
        public string Hiringmanagerlastname { get; set; }
        public string Hiringmanageremail { get; set; }
        public string Hiringmanagerphone { get; set; }
        public string Postingowner { get; set; }
        public string Additionaluser1 { get; set; }
        public string Additionaluser2 { get; set; }
        public string Additionaluser3 { get; set; }
        public string Additionaluser4 { get; set; }
        public string Additionaluser5 { get; set; }
        public string Additionaluser6 { get; set; }
        public string Additionaluser7 { get; set; }
        public string Additionaluser8 { get; set; }
        public string Additionaluser9 { get; set; }
        public string Additionaluser10 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string Udf1 { get; set; }
        public string Udf2 { get; set; }
        public string Udf3 { get; set; }
    }
}
