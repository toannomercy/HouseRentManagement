namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THECUDAN")]
    public partial class THECUDAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THECUDAN()
        {
            THEXEs = new HashSet<THEXE>();
        }

        [Key]
        [StringLength(20)]
        public string MaTheCuDan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public int? HSD { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNguoiThue { get; set; }

        public virtual NGUOITHUE NGUOITHUE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THEXE> THEXEs { get; set; }

        public virtual USER USER { get; set; }
    }
}
