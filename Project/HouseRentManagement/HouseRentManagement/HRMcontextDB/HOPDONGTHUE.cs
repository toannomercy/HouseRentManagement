namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOPDONGTHUE")]
    public partial class HOPDONGTHUE
    {
        [Key]
        [StringLength(20)]
        public string SoHopDong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public decimal? TienCoc { get; set; }

        public decimal? TienThue { get; set; }

        [StringLength(200)]
        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKT { get; set; }

        [Required]
        [StringLength(20)]
        public string MaChuSoHuu { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNguoiThue { get; set; }

        [Required]
        [StringLength(20)]
        public string MaCanHo { get; set; }

        public virtual CANHO CANHO { get; set; }

        public virtual CHUSOHUU CHUSOHUU { get; set; }

        public virtual NGUOITHUE NGUOITHUE { get; set; }
    }
}
