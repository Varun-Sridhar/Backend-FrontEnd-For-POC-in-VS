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
    
    public partial class BeaconLocation
    {
        public Nullable<int> CountryID { get; set; }
        public int LocationID { get; set; }
        public string Location { get; set; }
        public Nullable<bool> isActive { get; set; }
    }
}
