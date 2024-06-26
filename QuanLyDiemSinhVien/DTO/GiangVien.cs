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
    
    public partial class GiangVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiangVien()
        {
            this.Lops = new HashSet<Lop>();
            this.LopTinChis = new HashSet<LopTinChi>();
        }
    
        public string MaGV { get; set; }
        public string HoLot { get; set; }
        public string Ten { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string HocHam { get; set; }
        public string HocVi { get; set; }
        public string ChuyenMon { get; set; }
        public string MaKhoa { get; set; }
        public string TenDangNhap { get; set; }
        public string FullName
        {
            get {  return this.HoLot.Trim() +" "+this.Ten.Trim(); }
        }
    
        public virtual Khoa Khoa { get; set; }
        public virtual TaiKhoang TaiKhoang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lop> Lops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LopTinChi> LopTinChis { get; set; }
    }
}
