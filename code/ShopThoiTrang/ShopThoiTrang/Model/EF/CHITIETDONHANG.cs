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
    
    public partial class CHITIETDONHANG
    {
        public string MADONHANG { get; set; }
        public string MASANPHAM { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<decimal> DONGIA { get; set; }
    
        public virtual DONHANG DONHANG { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
