//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sehir_T
    {
        public Sehir_T()
        {
            this.Ilce_T = new HashSet<Ilce_T>();
        }
    
        public int ID { get; set; }
        public string SehirAdi { get; set; }
        public Nullable<bool> AktifMi { get; set; }
    
        public virtual ICollection<Ilce_T> Ilce_T { get; set; }
    }
}