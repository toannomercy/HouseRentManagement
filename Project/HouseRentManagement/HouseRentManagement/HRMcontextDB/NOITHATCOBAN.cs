namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NOITHATCOBAN")]
    public partial class NOITHATCOBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOITHATCOBAN()
        {
            CTNTCBs = new HashSet<CTNTCB>();
        }

        [Key]
        [StringLength(20)]
        public string MaNTCB { get; set; }

        [StringLength(50)]
        public string TenNoiThat { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public int? SoLuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMua { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTNTCB> CTNTCBs { get; set; }
    }
}
