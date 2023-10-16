namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONTHANHTOAN")]
    public partial class HOADONTHANHTOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONTHANHTOAN()
        {
            CTHDTTs = new HashSet<CTHDTT>();
        }

        [Key]
        [StringLength(20)]
        public string SoHoaDon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public decimal? TongTien { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        [Required]
        [StringLength(20)]
        public string MaCanHo { get; set; }

        public virtual CANHO CANHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDTT> CTHDTTs { get; set; }
    }
}
