//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHASANXUAT
    {
        public NHASANXUAT()
        {
            this.SANPHAMs = new HashSet<SANPHAM>();
        }
    
        public string MANSX { get; set; }
        public string TENNSX { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public Nullable<decimal> Diem { get; set; }
    
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}