namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TANG")]
    public partial class TANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TANG()
        {
            CANHOes = new HashSet<CANHO>();
        }

        [Key]
        [StringLength(20)]
        public string MaTang { get; set; }

        [Column("Tang")]
        [StringLength(30)]
        public string Tang1 { get; set; }

        public int? SoCanHo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CANHO> CANHOes { get; set; }
    }
}
