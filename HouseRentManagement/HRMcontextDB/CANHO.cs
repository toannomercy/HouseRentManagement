namespace HouseRentManagement.HRMcontextDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CANHO")]
    public partial class CANHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CANHO()
        {
            CTNTCBs = new HashSet<CTNTCB>();
            DANHSACHNHANKHAUs = new HashSet<DANHSACHNHANKHAU>();
            HOPDONGTHUEs = new HashSet<HOPDONGTHUE>();
            HOADONTHANHTOANs = new HashSet<HOADONTHANHTOAN>();
            PHIEUCHUYENDOes = new HashSet<PHIEUCHUYENDO>();
            PHIEUPHANHOIs = new HashSet<PHIEUPHANHOI>();
            PHIEUPHATs = new HashSet<PHIEUPHAT>();
            PHIEUSUACHUAs = new HashSet<PHIEUSUACHUA>();
            PHIEUTHICONGs = new HashSet<PHIEUTHICONG>();
        }

        [Key]
        [StringLength(20)]
        public string MaCanHo { get; set; }

        [Required]
        [StringLength(20)]
        public string TinhTrang { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTang { get; set; }

        [Required]
        [StringLength(20)]
        public string MaChuSoHuu { get; set; }

        [Required]
        [StringLength(20)]
        public string MaLoai { get; set; }

        public virtual CHUSOHUU CHUSOHUU { get; set; }

        public virtual LOAICANHO LOAICANHO { get; set; }

        public virtual TANG TANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTNTCB> CTNTCBs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHSACHNHANKHAU> DANHSACHNHANKHAUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONGTHUE> HOPDONGTHUEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONTHANHTOAN> HOADONTHANHTOANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUCHUYENDO> PHIEUCHUYENDOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHANHOI> PHIEUPHANHOIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUPHAT> PHIEUPHATs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUSUACHUA> PHIEUSUACHUAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHICONG> PHIEUTHICONGs { get; set; }
    }
}
