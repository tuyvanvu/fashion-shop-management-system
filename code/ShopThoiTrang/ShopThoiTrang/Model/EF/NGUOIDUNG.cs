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
    
    public partial class NGUOIDUNG
    {
        public NGUOIDUNG()
        {
            this.CHAMCONGs = new HashSet<CHAMCONG>();
            this.DATHANGs = new HashSet<DATHANG>();
            this.DONHANGs = new HashSet<DONHANG>();
            this.GIOHANGs = new HashSet<GIOHANG>();
            this.NGUOIDUNG_NHOMNGUOIDUNG = new HashSet<NGUOIDUNG_NHOMNGUOIDUNG>();
        }
    
        public string TENDN { get; set; }
        public string MATKHAU { get; set; }
        public string TENNGUOIDUNG { get; set; }
        public string EMAIL { get; set; }
        public string GIOITINH { get; set; }
        public string SDT { get; set; }
        public string DIACHI { get; set; }
        public string CMND { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public string AVATAR { get; set; }
    
        public virtual ICollection<CHAMCONG> CHAMCONGs { get; set; }
        public virtual ICollection<DATHANG> DATHANGs { get; set; }
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
        public virtual ICollection<GIOHANG> GIOHANGs { get; set; }
        public virtual ICollection<NGUOIDUNG_NHOMNGUOIDUNG> NGUOIDUNG_NHOMNGUOIDUNG { get; set; }
    }
}
