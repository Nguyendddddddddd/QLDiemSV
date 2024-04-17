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
    
    public partial class LopTinChi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LopTinChi()
        {
            this.SinhViens = new HashSet<SinhVien>();
            this.GiangViens = new HashSet<GiangVien>();
        }
    
        public string MaLop { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<int> SLSinhVien { get; set; }
        public Nullable<int> SLToiDa { get; set; }
        public string MaHocKy { get; set; }
        public string MaMon { get; set; }
        public string MaDiemTP { get; set; }
    
        public virtual DiemThanhPhan DiemThanhPhan { get; set; }
        public virtual HocKy HocKy { get; set; }
        public virtual MonHoc MonHoc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SinhVien> SinhViens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiangVien> GiangViens { get; set; }
    }
}
