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
    
    public partial class chi_tiet_hoa_don
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> ngay_lap_hd { get; set; }
        public Nullable<int> hoa_don_id { get; set; }
        public Nullable<int> san_pham_id { get; set; }
        public Nullable<int> loai_sp_id { get; set; }
        public Nullable<int> size_id { get; set; }
        public Nullable<int> color_id { get; set; }
        public Nullable<int> don_dh_id { get; set; }
        public Nullable<int> customer_id { get; set; }
    
        public virtual color color { get; set; }
        public virtual khach_hang khach_hang { get; set; }
        public virtual don_dat_hang don_dat_hang { get; set; }
        public virtual hoa_don hoa_don { get; set; }
        public virtual loai_san_pham loai_san_pham { get; set; }
        public virtual san_pham san_pham { get; set; }
        public virtual size size { get; set; }
    }
}