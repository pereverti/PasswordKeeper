//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasswordKeeper
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomField
    {
        public int IdPassword { get; set; }
        public int IdCustomFieldType { get; set; }
        public string ControlId { get; set; }
    
        public virtual Password Password { get; set; }
    }
}
