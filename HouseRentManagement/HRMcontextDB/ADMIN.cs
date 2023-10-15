namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ADMINS")]
    public partial class ADMIN
    {
        [Key]
        [StringLength(20)]
        public string MaQL { get; set; }

        [Required]
        [StringLength(60)]
        public string MatKhau { get; set; }

        public virtual BANQUANLY BANQUANLY { get; set; }
    }
}
