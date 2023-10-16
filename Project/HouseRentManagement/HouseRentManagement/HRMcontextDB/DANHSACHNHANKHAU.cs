namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHSACHNHANKHAU")]
    public partial class DANHSACHNHANKHAU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaNguoiThue { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaCanHo { get; set; }

        [StringLength(50)]
        public string QuanHeVoiChuThue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDenO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayRoiDi { get; set; }

        public virtual CANHO CANHO { get; set; }

        public virtual NGUOITHUE NGUOITHUE { get; set; }
    }
}
