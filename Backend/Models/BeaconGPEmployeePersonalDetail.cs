//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Backend.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BeaconGPEmployeePersonalDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BeaconGPEmployeePersonalDetail()
        {
            this.BeaconGPITMs = new HashSet<BeaconGPITM>();
            this.BeaconGPEmployeeProducts = new HashSet<BeaconGPEmployeeProduct>();
        }
    
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string PanNo { get; set; }
        public string PassportNo { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public Nullable<System.DateTime> AnniversaryDate { get; set; }
        public Nullable<int> NoOfChildren { get; set; }
        public string PersonalIdentificationNo { get; set; }
        public string MaritalStatus { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string PersonalPhone1 { get; set; }
        public string PersonalPhone2 { get; set; }
        public string OfficePhone { get; set; }
        public string IPExtension { get; set; }
        public string PersonalEmail { get; set; }
        public string OfficeEmail { get; set; }
        public string Title { get; set; }
        public string HomeTown { get; set; }
        public string PostalCode { get; set; }
        public Nullable<int> Country { get; set; }
        public string PreviousExperience { get; set; }
        public Nullable<int> JobHops { get; set; }
        public string PreferedLocation { get; set; }
        public string EmergencyContactName { get; set; }
        public Nullable<decimal> EmergencyContactNumber { get; set; }
        public string PFNumber { get; set; }
        public string UANNumber { get; set; }
        public string ICICIAccountNumber { get; set; }
        public Nullable<System.DateTime> EmployeeConversionDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeaconGPITM> BeaconGPITMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeaconGPEmployeeProduct> BeaconGPEmployeeProducts { get; set; }
        public virtual BeaconGPManager BeaconGPManager { get; set; }
    }
}