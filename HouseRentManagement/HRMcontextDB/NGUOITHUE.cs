namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOITHUE")]
    public partial class NGUOITHUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOITHUE()
        {
            DANHSACHNHANKHAUs = new HashSet<DANHSACHNHANKHAU>();
            HOPDONGTHUEs = new HashSet<HOPDONGTHUE>();
            THECUDANs = new HashSet<THECUDAN>();
        }

        [Key]
        [StringLength(20)]
        public string MaNguoiThue { get; set; }

        [Required]
        [StringLength(50)]
        public string TenNguoiThue { get; set; }

        [Required]
        [StringLength(12)]
        public string CCCD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHNHANKHAU> DANHSACHNHANKHAUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONGTHUE> HOPDONGTHUEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THECUDAN> THECUDANs { get; set; }
    }
}
