namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUCHUYENDO")]
    public partial class PHIEUCHUYENDO
    {
        [Key]
        [StringLength(20)]
        public string SoPhieuChuyenDo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(200)]
        public string NoiDung { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public DateTime? BDChuyen { get; set; }

        public DateTime? KTChuyen { get; set; }

        [Required]
        [StringLength(20)]
        public string MaCanHo { get; set; }

        public virtual CANHO CANHO { get; set; }
    }
}
