//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSpa
{
    using System;
    using System.Collections.Generic;
    
    public partial class TRANGTHAI_SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANGTHAI_SANPHAM()
        {
            this.SANPHAMs = new HashSet<SANPHAM>();
            this.LOAISANPHAMs = new HashSet<LOAISANPHAM>();
        }
    
        public int MATTSP { get; set; }
        public string TTSP_TEN { get; set; }
        public Nullable<bool> TTSP_TRANGTHAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOAISANPHAM> LOAISANPHAMs { get; set; }
    }
}
