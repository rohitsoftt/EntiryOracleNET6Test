using System;
using System.Collections.Generic;

#nullable disable

namespace EntiryOracleNET6Test.DBModels
{
    public partial class Person
    {
        public Person()
        {
            ApprovalApprovedByNavigations = new HashSet<Approval>();
            ApprovalTargetApproverNavigations = new HashSet<Approval>();
            Approvers = new HashSet<Approver>();
            CandidateContractees = new HashSet<CandidateContractee>();
            CostCenters = new HashSet<CostCenter>();
            CostManagementCostMgmtRequestorUsers = new HashSet<CostManagement>();
            CostManagementSupplierUsers = new HashSet<CostManagement>();
            DelegationDelegatedFromNavigations = new HashSet<Delegation>();
            DelegationDelegatedToNavigations = new HashSet<Delegation>();
            DeviationApprovedByNavigations = new HashSet<Deviation>();
            DeviationRebidAcknowledgedByNavigations = new HashSet<Deviation>();
            DeviationRequisitioners = new HashSet<Deviation>();
            DeviationStaffingsPecialists = new HashSet<Deviation>();
            DeviationSupervisors = new HashSet<Deviation>();
            ExitCancels = new HashSet<ExitCancel>();
            Orders = new HashSet<Order>();
            PositionCustomerContacts = new HashSet<Position>();
            PositionSupervisors = new HashSet<Position>();
            RenewalApprovers = new HashSet<RenewalApprover>();
            SecurityChecks = new HashSet<SecurityCheck>();
            SupplierUsers = new HashSet<SupplierUser>();
            TimesheetHeaderApprovedByNavigations = new HashSet<TimesheetHeader>();
            TimesheetHeaderSupervisors = new HashSet<TimesheetHeader>();
            TransitionCustomers = new HashSet<TransitionCustomer>();
            TransitionFieldDefaultRequisitioners = new HashSet<TransitionFieldDefault>();
            TransitionFieldDefaultSupervisors = new HashSet<TransitionFieldDefault>();
            TransitionReports = new HashSet<TransitionReport>();
            VacationReplacements = new HashSet<VacationReplacement>();
        }

        public int UserId { get; set; }
        public string Password { get; set; }
        public string LoginId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public int? LocationCode { get; set; }
        public int? UserTypeCode { get; set; }
        public long? AuthLevel { get; set; }
        public string Building { get; set; }
        public string Room { get; set; }
        public DateTime? LastMessageReadDate { get; set; }
        public string CostCenter { get; set; }
        public string EmailAddress { get; set; }
        public string EmailNotifyFlag { get; set; }
        public string ActiveFlag { get; set; }
        public int? LastUpdatedBy { get; set; }
        public string DivisionCode { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public string UnclassifiedFlag { get; set; }
        public DateTime? PwdSystemAssignedDate { get; set; }
        public DateTime? PwdLastChangedDate { get; set; }
        public DateTime? PwdLastSuccessLoginDate { get; set; }
        public byte? PwdFailedAttempts { get; set; }
        public string PwdSystemAssignedFlag { get; set; }
        public string PwdLockedFlag { get; set; }
        public string LanguageId { get; set; }

        public virtual Division DivisionCodeNavigation { get; set; }
        public virtual Language Language { get; set; }
        public virtual UserType UserTypeCodeNavigation { get; set; }
        public virtual ICollection<Approval> ApprovalApprovedByNavigations { get; set; }
        public virtual ICollection<Approval> ApprovalTargetApproverNavigations { get; set; }
        public virtual ICollection<Approver> Approvers { get; set; }
        public virtual ICollection<CandidateContractee> CandidateContractees { get; set; }
        public virtual ICollection<CostCenter> CostCenters { get; set; }
        public virtual ICollection<CostManagement> CostManagementCostMgmtRequestorUsers { get; set; }
        public virtual ICollection<CostManagement> CostManagementSupplierUsers { get; set; }
        public virtual ICollection<Delegation> DelegationDelegatedFromNavigations { get; set; }
        public virtual ICollection<Delegation> DelegationDelegatedToNavigations { get; set; }
        public virtual ICollection<Deviation> DeviationApprovedByNavigations { get; set; }
        public virtual ICollection<Deviation> DeviationRebidAcknowledgedByNavigations { get; set; }
        public virtual ICollection<Deviation> DeviationRequisitioners { get; set; }
        public virtual ICollection<Deviation> DeviationStaffingsPecialists { get; set; }
        public virtual ICollection<Deviation> DeviationSupervisors { get; set; }
        public virtual ICollection<ExitCancel> ExitCancels { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Position> PositionCustomerContacts { get; set; }
        public virtual ICollection<Position> PositionSupervisors { get; set; }
        public virtual ICollection<RenewalApprover> RenewalApprovers { get; set; }
        public virtual ICollection<SecurityCheck> SecurityChecks { get; set; }
        public virtual ICollection<SupplierUser> SupplierUsers { get; set; }
        public virtual ICollection<TimesheetHeader> TimesheetHeaderApprovedByNavigations { get; set; }
        public virtual ICollection<TimesheetHeader> TimesheetHeaderSupervisors { get; set; }
        public virtual ICollection<TransitionCustomer> TransitionCustomers { get; set; }
        public virtual ICollection<TransitionFieldDefault> TransitionFieldDefaultRequisitioners { get; set; }
        public virtual ICollection<TransitionFieldDefault> TransitionFieldDefaultSupervisors { get; set; }
        public virtual ICollection<TransitionReport> TransitionReports { get; set; }
        public virtual ICollection<VacationReplacement> VacationReplacements { get; set; }
    }
}
