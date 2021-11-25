using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Supplier
    {
        public Supplier()
        {
            DeviationIncumbentSuppliers = new HashSet<Deviation>();
            DeviationSuppliers = new HashSet<Deviation>();
            Margins = new HashSet<Margin>();
            OpnSuppliers = new HashSet<OpnSupplier>();
            Positions = new HashSet<Position>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
            SupplierAlgorithms = new HashSet<SupplierAlgorithm>();
            SupplierBuyoutNewSuppliers = new HashSet<SupplierBuyout>();
            SupplierContactPersonnel = new HashSet<SupplierContactPersonnel>();
            SupplierContractFees = new HashSet<SupplierContractFee>();
            SupplierHistories = new HashSet<SupplierHistory>();
            SupplierIpAddresses = new HashSet<SupplierIpAddress>();
            SupplierLocations = new HashSet<SupplierLocation>();
            SupplierSpecificData = new HashSet<SupplierSpecificDatum>();
            SupplierUsers = new HashSet<SupplierUser>();
            TempPurchaseOrders = new HashSet<TempPurchaseOrder>();
            TimesheetHeaders = new HashSet<TimesheetHeader>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string RegionCode { get; set; }
        public string TaxId { get; set; }
        public string OrganizationType { get; set; }
        public string Sic { get; set; }
        public string MinorityGroup { get; set; }
        public string ParentCompany { get; set; }
        public string SupplierStatus { get; set; }
        public string WomanOwnedFlag { get; set; }
        public string DeletedFlag { get; set; }
        public string SmallBusinessFlag { get; set; }
        public string QualityStatusFlag { get; set; }
        public string MinorityConfirmedFlag { get; set; }
        public string MinorityCertificationFlag { get; set; }
        public DateTime? BuyoutDate { get; set; }
        public DateTime? QualityAchievedDate { get; set; }
        public string QualityCertificationType { get; set; }
        public DateTime? DesourceDate { get; set; }
        public string SupplierUrl { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string WebAccessFlag { get; set; }

        public virtual MinorityGroup MinorityGroupNavigation { get; set; }
        public virtual OrganizationType OrganizationTypeNavigation { get; set; }
        public virtual QualityCertificationType QualityCertificationTypeNavigation { get; set; }
        public virtual RegionCode RegionCodeNavigation { get; set; }
        public virtual SupplierStatus SupplierStatusNavigation { get; set; }
        public virtual SupplierBuyout SupplierBuyoutSupplier { get; set; }
        public virtual SupplierJde SupplierJde { get; set; }
        public virtual ICollection<Deviation> DeviationIncumbentSuppliers { get; set; }
        public virtual ICollection<Deviation> DeviationSuppliers { get; set; }
        public virtual ICollection<Margin> Margins { get; set; }
        public virtual ICollection<OpnSupplier> OpnSuppliers { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<SupplierAlgorithm> SupplierAlgorithms { get; set; }
        public virtual ICollection<SupplierBuyout> SupplierBuyoutNewSuppliers { get; set; }
        public virtual ICollection<SupplierContactPersonnel> SupplierContactPersonnel { get; set; }
        public virtual ICollection<SupplierContractFee> SupplierContractFees { get; set; }
        public virtual ICollection<SupplierHistory> SupplierHistories { get; set; }
        public virtual ICollection<SupplierIpAddress> SupplierIpAddresses { get; set; }
        public virtual ICollection<SupplierLocation> SupplierLocations { get; set; }
        public virtual ICollection<SupplierSpecificDatum> SupplierSpecificData { get; set; }
        public virtual ICollection<SupplierUser> SupplierUsers { get; set; }
        public virtual ICollection<TempPurchaseOrder> TempPurchaseOrders { get; set; }
        public virtual ICollection<TimesheetHeader> TimesheetHeaders { get; set; }
    }
}
