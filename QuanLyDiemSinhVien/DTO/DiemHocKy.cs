//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiemHocKy
    {
        public string MaHocKy { get; set; }
        public string MSSV { get; set; }
        public Nullable<int> Diem { get; set; }
    
        public virtual HocKy HocKy { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}
