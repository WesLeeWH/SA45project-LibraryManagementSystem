//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExtendApplication
    {
        public int ApplicationID { get; set; }
        public Nullable<int> TransactionID { get; set; }
        public Nullable<int> ExtendDays { get; set; }
        public string IsApproved { get; set; }
        public string Remarks { get; set; }
    
        public virtual IssueTran IssueTran { get; set; }
    }
}
