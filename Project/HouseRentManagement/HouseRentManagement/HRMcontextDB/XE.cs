namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XE")]
    public partial class XE
    {
        [Key]
        [StringLength(9)]
        public string BienSo { get; set; }

        [StringLength(50)]
        public string TenXe { get; set; }

        [StringLength(30)]
        public string LoaiCoGioi { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTheXe { get; set; }

        public virtual THEXE THEXE { get; set; }
    }
}
