namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHDTT")]
    public partial class CTHDTT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string SoHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaBangGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TuNgay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DenNgay { get; set; }

        public int? SoLuong { get; set; }

        public decimal? ThanhTien { get; set; }

        public virtual BANGGIA BANGGIA { get; set; }

        public virtual HOADONTHANHTOAN HOADONTHANHTOAN { get; set; }
    }
}
