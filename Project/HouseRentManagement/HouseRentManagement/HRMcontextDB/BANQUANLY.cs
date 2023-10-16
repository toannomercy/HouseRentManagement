namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANQUANLY")]
    public partial class BANQUANLY
    {
        [Key]
        [StringLength(20)]
        public string MaQL { get; set; }

        [Required]
        [StringLength(50)]
        public string TenQuanLy { get; set; }

        [Required]
        [StringLength(20)]
        public string MaCV { get; set; }

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

        public virtual ADMIN ADMIN { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }
    }
}
