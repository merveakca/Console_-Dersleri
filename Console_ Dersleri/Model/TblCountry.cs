//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Console__Dersleri.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblCountry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblCountry()
        {
            this.TblFlight = new HashSet<TblFlight>();
            this.TblFlight1 = new HashSet<TblFlight>();
        }
    
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCapital { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFlight> TblFlight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblFlight> TblFlight1 { get; set; }
    }
}
