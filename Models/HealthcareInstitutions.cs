//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pr5_golobokov.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HealthcareInstitutions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HealthcareInstitutions()
        {
            this.PaymentInvoices = new HashSet<PaymentInvoices>();
        }
    
        public int InstitutionID { get; set; }
        public string InstitutionName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentInvoices> PaymentInvoices { get; set; }
    }
}
