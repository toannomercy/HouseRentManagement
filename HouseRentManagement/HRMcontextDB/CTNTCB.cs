namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTNTCB")]
    public partial class CTNTCB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaNTCB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaCanHo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTrangBi { get; set; }

        public int? SoLuongTB { get; set; }

        public virtual CANHO CANHO { get; set; }

        public virtual NOITHATCOBAN NOITHATCOBAN { get; set; }
    }
}
