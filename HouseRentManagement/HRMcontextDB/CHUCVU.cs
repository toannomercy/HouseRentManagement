namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCVU")]
    public partial class CHUCVU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUCVU()
        {
            BANQUANLies = new HashSet<BANQUANLY>();
        }

        [Key]
        [StringLength(20)]
        public string MaCV { get; set; }

        [StringLength(50)]
        public string TenChucVu { get; set; }

        public decimal? LuongCoBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANQUANLY> BANQUANLies { get; set; }
    }
}
