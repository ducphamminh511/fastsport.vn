//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fastsport.vn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class don_dat_hang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public don_dat_hang()
        {
            this.chi_tiet_hoa_don = new HashSet<chi_tiet_hoa_don>();
            this.chi_tiet_don_dat_hang = new HashSet<chi_tiet_don_dat_hang>();
            this.hoa_don = new HashSet<hoa_don>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Dia_chi_nhan_hang { get; set; }
        public string Ghi_chu { get; set; }
        public Nullable<double> Thanh_tien { get; set; }
        public Nullable<System.DateTime> ngay_lap_dh { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> trang_thai_don_dh_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_hoa_don> chi_tiet_hoa_don { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_don_dat_hang> chi_tiet_don_dat_hang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoa_don> hoa_don { get; set; }
        public virtual khach_hang khach_hang { get; set; }
        public virtual trang_thai_ddh trang_thai_ddh { get; set; }
    }
}
