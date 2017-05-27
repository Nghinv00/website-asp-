//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_cafe_film.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThanhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhVien()
        {
            this.MovieUser = new HashSet<MovieUser>();
            this.RatingOfMovie = new HashSet<RatingOfMovie>();
        }
    
        public int MaThanhVien { get; set; }
        public string HoTen { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public string Passwords { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string Gmail { get; set; }
        public Nullable<int> SoDienThoai { get; set; }
        public Nullable<double> SoDuTaiKhoan { get; set; }
        public Nullable<int> OccupationID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieUser> MovieUser { get; set; }
        public virtual Occupation Occupation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RatingOfMovie> RatingOfMovie { get; set; }
    }
}