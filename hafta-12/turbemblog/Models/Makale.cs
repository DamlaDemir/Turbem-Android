//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace turbemblog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Makale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Makale()
        {
            this.EtiketMakales = new HashSet<EtiketMakale>();
        }
    
        public int id { get; set; }
        public string baslik { get; set; }
        public Nullable<int> sahipId { get; set; }
        public Nullable<System.DateTime> yayimTarihi { get; set; }
        public string icerik { get; set; }
        public Nullable<int> kategoriId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EtiketMakale> EtiketMakales { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
