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
    
    public partial class CHITIET_KHUYENMAI_DICHVU
    {
        public int MADV { get; set; }
        public int MAKM { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<double> GIAKHUYENMAI { get; set; }
        public Nullable<bool> OFF { get; set; }
        public Nullable<double> PHANTRAMGIAM { get; set; }
        public string LICHSU { get; set; }
        public string GHICHU { get; set; }
    
        public virtual DICHVU DICHVU { get; set; }
        public virtual KHUYENMAI KHUYENMAI { get; set; }
    }
}
