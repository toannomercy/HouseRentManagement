namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGGIA")]
    public partial class BANGGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANGGIA()
        {
            CTHDTTs = new HashSet<CTHDTT>();
        }

        [Key]
        [StringLength(20)]
        public string MaBangGia { get; set; }

        [StringLength(50)]
        public string TenDichVu { get; set; }

        [StringLength(30)]
        public string DonViTinh { get; set; }

        public decimal? GiaTien { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHDTT> CTHDTTs { get; set; }
    }
}
