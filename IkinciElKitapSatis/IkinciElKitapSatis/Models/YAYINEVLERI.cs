//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IkinciElKitapSatis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class YAYINEVLERI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YAYINEVLERI()
        {
            this.KITAPLAR = new HashSet<KITAPLAR>();
        }
    
        public int YAYINEVIID { get; set; }
        public string YAYINEVIADI { get; set; }
        public string ADRES { get; set; }
        public string TELEFON { get; set; }
        public string EPOSTA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KITAPLAR> KITAPLAR { get; set; }
    }
}
