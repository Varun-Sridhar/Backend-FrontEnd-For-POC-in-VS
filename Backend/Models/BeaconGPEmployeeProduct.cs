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
    
    public partial class BeaconGPEmployeeProduct
    {
        public int EmployeeId { get; set; }
        public int ProductId { get; set; }
        public string PrimaryOrSecondary { get; set; }
        public int Id { get; set; }
        public Nullable<int> AdditionalProductId { get; set; }
    
        public virtual BeaconGPEmployeePersonalDetail BeaconGPEmployeePersonalDetail { get; set; }
    }
}