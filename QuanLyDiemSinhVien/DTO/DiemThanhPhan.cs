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
    
    public partial class DiemThanhPhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiemThanhPhan()
        {
            this.ChiTietDiems = new HashSet<ChiTietDiem>();
        }
    
        public System.Guid MaDiem { get; set; }
        public string MaLop { get; set; }
        public double PhanTram { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDiem> ChiTietDiems { get; set; }
        public virtual LopTinChi LopTinChi { get; set; }
    }
}
