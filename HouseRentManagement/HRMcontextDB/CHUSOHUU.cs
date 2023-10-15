namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUSOHUU")]
    public partial class CHUSOHUU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUSOHUU()
        {
            CANHOes = new HashSet<CANHO>();
            HOPDONGTHUEs = new HashSet<HOPDONGTHUE>();
        }

        [Key]
        [StringLength(20)]
        public string MaChuSoHuu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenChuSoHuu { get; set; }

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
        public virtual ICollection<CANHO> CANHOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONGTHUE> HOPDONGTHUEs { get; set; }
    }
}
