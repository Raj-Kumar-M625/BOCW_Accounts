//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entity()
        {
            this.AdvanceRequests = new HashSet<AdvanceRequest>();
            this.BonusAgreementDetails = new HashSet<BonusAgreementDetail>();
            this.DWS = new HashSet<DW>();
            this.EntityAgreements = new HashSet<EntityAgreement>();
            this.EntityBankDetails = new HashSet<EntityBankDetail>();
            this.EntityContacts = new HashSet<EntityContact>();
            this.EntityCrops = new HashSet<EntityCrop>();
            this.EntityImages = new HashSet<EntityImage>();
            this.EntitySurveys = new HashSet<EntitySurvey>();
            this.EntityWorkFlows = new HashSet<EntityWorkFlow>();
            this.IssueReturns = new HashSet<IssueReturn>();
            this.TerminateAgreementRequests = new HashSet<TerminateAgreementRequest>();
        }
    
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public long DayId { get; set; }
        public string HQCode { get; set; }
        public bool AtBusiness { get; set; }
        public string EntityType { get; set; }
        public string EntityName { get; set; }
        public System.DateTime EntityDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string LandSize { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public bool IsApproved { get; set; }
        public System.DateTime ApproveDate { get; set; }
        public string ApproveRef { get; set; }
        public string ApproveNotes { get; set; }
        public string ApprovedBy { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public long SqliteEntityId { get; set; }
        public int ContactCount { get; set; }
        public int CropCount { get; set; }
        public int ImageCount { get; set; }
        public string UniqueIdType { get; set; }
        public string UniqueId { get; set; }
        public string TaxId { get; set; }
        public int AgreementCount { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
        public string FatherHusbandName { get; set; }
        public string HQName { get; set; }
        public string TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string EntityNumber { get; set; }
        public string CreatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdvanceRequest> AdvanceRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonusAgreementDetail> BonusAgreementDetails { get; set; }
        public virtual Day Day { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DW> DWS { get; set; }
        public virtual TenantEmployee TenantEmployee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityAgreement> EntityAgreements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityBankDetail> EntityBankDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityContact> EntityContacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityCrop> EntityCrops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityImage> EntityImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntitySurvey> EntitySurveys { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityWorkFlow> EntityWorkFlows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IssueReturn> IssueReturns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TerminateAgreementRequest> TerminateAgreementRequests { get; set; }
    }
}