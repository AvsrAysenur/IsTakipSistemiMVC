//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IsTakipSistemiMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personeller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personeller()
        {
            this.Isler = new HashSet<Isler>();
        }
    
        public int personelId { get; set; }
        public string personelAdSoyad { get; set; }
        public string personelKullaniciAd { get; set; }
        public string personelParola { get; set; }
        public Nullable<int> personelBirimId { get; set; }
        public Nullable<int> personelYetkiTurId { get; set; }
    
        public virtual Birimler Birimler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Isler> Isler { get; set; }
        public virtual YetkiTurler YetkiTurler { get; set; }
    }
}