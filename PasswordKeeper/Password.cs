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
    
    public partial class Password
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Password()
        {
            this.CustomFields = new HashSet<CustomField>();
        }
    
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password1 { get; set; }
        public string Url { get; set; }
        public string Notes { get; set; }
        public int UserId { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreationDate { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomField> CustomFields { get; set; }
    }
}
