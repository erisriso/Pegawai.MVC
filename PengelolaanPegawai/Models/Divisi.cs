//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PengelolaanPegawai.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Divisi
    {
        public Divisi()
        {
            this.Pegawais = new HashSet<Pegawai>();
        }
    
        public int DivisiID { get; set; }
        public string NamaDivisi { get; set; }
    
        public virtual ICollection<Pegawai> Pegawais { get; set; }
    }
}