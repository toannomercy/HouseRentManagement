namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUSUACHUA")]
    public partial class PHIEUSUACHUA
    {
        [Key]
        [StringLength(20)]
        public string SoPhieuSuaChua { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(200)]
        public string NoiDung { get; set; }

        public decimal? TongTien { get; set; }

        [StringLength(50)]
        public string DonViSuaChua { get; set; }

        [Required]
        [StringLength(20)]
        public string MaCanHo { get; set; }

        public virtual CANHO CANHO { get; set; }
    }
}
