//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    [Serializable]
    public partial class GiaoVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoVu()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
        public string MaGiaoVu;
        public string MaGV
        {
            get { return this.MaGiaoVu; }
            set
            {
                MaGiaoVu = value;
            }
        } 
        public string TenGiaoVu { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
