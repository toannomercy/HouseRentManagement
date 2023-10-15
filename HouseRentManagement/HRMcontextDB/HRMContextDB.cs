using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HouseRentManagement.HRMcontextDB
{
    public partial class HRMContextDB : DbContext
    {
        public HRMContextDB()
            : base("name=HRMContextDB")
        {
        }

        public virtual DbSet<ADMIN> ADMINS { get; set; }
        public virtual DbSet<BANGGIA> BANGGIAs { get; set; }
        public virtual DbSet<BANQUANLY> BANQUANLies { get; set; }
        public virtual DbSet<CANHO> CANHOes { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<CHUSOHUU> CHUSOHUUs { get; set; }
        public virtual DbSet<CTHDTT> CTHDTTs { get; set; }
        public virtual DbSet<CTNTCB> CTNTCBs { get; set; }
        public virtual DbSet<DANHSACHNHANKHAU> DANHSACHNHANKHAUs { get; set; }
        public virtual DbSet<HOADONTHANHTOAN> HOADONTHANHTOANs { get; set; }
        public virtual DbSet<HOPDONGTHUE> HOPDONGTHUEs { get; set; }
        public virtual DbSet<LOAICANHO> LOAICANHOes { get; set; }
        public virtual DbSet<NGUOITHUE> NGUOITHUEs { get; set; }
        public virtual DbSet<NOITHATCOBAN> NOITHATCOBANs { get; set; }
        public virtual DbSet<PHIEUCHUYENDO> PHIEUCHUYENDOes { get; set; }
        public virtual DbSet<PHIEUPHANHOI> PHIEUPHANHOIs { get; set; }
        public virtual DbSet<PHIEUPHAT> PHIEUPHATs { get; set; }
        public virtual DbSet<PHIEUSUACHUA> PHIEUSUACHUAs { get; set; }
        public virtual DbSet<PHIEUTHICONG> PHIEUTHICONGs { get; set; }
        public virtual DbSet<TANG> TANGs { get; set; }
        public virtual DbSet<THECUDAN> THECUDANs { get; set; }
        public virtual DbSet<THEXE> THEXEs { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<XE> XEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADMIN>()
                .Property(e => e.MaQL)
                .IsUnicode(false);

            modelBuilder.Entity<ADMIN>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<BANGGIA>()
                .Property(e => e.MaBangGia)
                .IsUnicode(false);

            modelBuilder.Entity<BANGGIA>()
                .Property(e => e.GiaTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<BANGGIA>()
                .HasMany(e => e.CTHDTTs)
                .WithRequired(e => e.BANGGIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.MaQL)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.MaCV)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<BANQUANLY>()
                .HasOptional(e => e.ADMIN)
                .WithRequired(e => e.BANQUANLY);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MaTang)
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MaChuSoHuu)
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.CTNTCBs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.DANHSACHNHANKHAUs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.HOPDONGTHUEs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.HOADONTHANHTOANs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUCHUYENDOes)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUPHANHOIs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUPHATs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUSUACHUAs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CANHO>()
                .HasMany(e => e.PHIEUTHICONGs)
                .WithRequired(e => e.CANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MaCV)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.LuongCoBan)
                .HasPrecision(20, 3);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.BANQUANLies)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUSOHUU>()
                .Property(e => e.MaChuSoHuu)
                .IsUnicode(false);

            modelBuilder.Entity<CHUSOHUU>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<CHUSOHUU>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<CHUSOHUU>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CHUSOHUU>()
                .HasMany(e => e.CANHOes)
                .WithRequired(e => e.CHUSOHUU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHUSOHUU>()
                .HasMany(e => e.HOPDONGTHUEs)
                .WithRequired(e => e.CHUSOHUU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTHDTT>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<CTHDTT>()
                .Property(e => e.MaBangGia)
                .IsUnicode(false);

            modelBuilder.Entity<CTHDTT>()
                .Property(e => e.ThanhTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<CTNTCB>()
                .Property(e => e.MaNTCB)
                .IsUnicode(false);

            modelBuilder.Entity<CTNTCB>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<DANHSACHNHANKHAU>()
                .Property(e => e.MaNguoiThue)
                .IsUnicode(false);

            modelBuilder.Entity<DANHSACHNHANKHAU>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.SoHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.TongTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONTHANHTOAN>()
                .HasMany(e => e.CTHDTTs)
                .WithRequired(e => e.HOADONTHANHTOAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.SoHopDong)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.TienCoc)
                .HasPrecision(20, 3);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.TienThue)
                .HasPrecision(20, 3);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.MaChuSoHuu)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.MaNguoiThue)
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONGTHUE>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<LOAICANHO>()
                .Property(e => e.MaLoai)
                .IsUnicode(false);

            modelBuilder.Entity<LOAICANHO>()
                .Property(e => e.GiaThueMacDinh)
                .HasPrecision(20, 3);

            modelBuilder.Entity<LOAICANHO>()
                .HasMany(e => e.CANHOes)
                .WithRequired(e => e.LOAICANHO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.MaNguoiThue)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHUE>()
                .HasMany(e => e.DANHSACHNHANKHAUs)
                .WithRequired(e => e.NGUOITHUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOITHUE>()
                .HasMany(e => e.HOPDONGTHUEs)
                .WithRequired(e => e.NGUOITHUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOITHUE>()
                .HasMany(e => e.THECUDANs)
                .WithRequired(e => e.NGUOITHUE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NOITHATCOBAN>()
                .Property(e => e.MaNTCB)
                .IsUnicode(false);

            modelBuilder.Entity<NOITHATCOBAN>()
                .HasMany(e => e.CTNTCBs)
                .WithRequired(e => e.NOITHATCOBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUCHUYENDO>()
                .Property(e => e.SoPhieuChuyenDo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUCHUYENDO>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHANHOI>()
                .Property(e => e.SoPhieuPhanHoi)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHANHOI>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.SoPhieuPhat)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.ThanhTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<PHIEUPHAT>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUSUACHUA>()
                .Property(e => e.SoPhieuSuaChua)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUSUACHUA>()
                .Property(e => e.TongTien)
                .HasPrecision(20, 3);

            modelBuilder.Entity<PHIEUSUACHUA>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHICONG>()
                .Property(e => e.SoPhieuThiCong)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHICONG>()
                .Property(e => e.MaCanHo)
                .IsUnicode(false);

            modelBuilder.Entity<TANG>()
                .Property(e => e.MaTang)
                .IsUnicode(false);

            modelBuilder.Entity<TANG>()
                .HasMany(e => e.CANHOes)
                .WithRequired(e => e.TANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THECUDAN>()
                .Property(e => e.MaTheCuDan)
                .IsUnicode(false);

            modelBuilder.Entity<THECUDAN>()
                .Property(e => e.MaNguoiThue)
                .IsUnicode(false);

            modelBuilder.Entity<THECUDAN>()
                .HasMany(e => e.THEXEs)
                .WithRequired(e => e.THECUDAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THECUDAN>()
                .HasOptional(e => e.USER)
                .WithRequired(e => e.THECUDAN);

            modelBuilder.Entity<THEXE>()
                .Property(e => e.MaTheXe)
                .IsUnicode(false);

            modelBuilder.Entity<THEXE>()
                .Property(e => e.MaTheCuDan)
                .IsUnicode(false);

            modelBuilder.Entity<THEXE>()
                .HasMany(e => e.XEs)
                .WithRequired(e => e.THEXE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.MaTheCuDan)
                .IsUnicode(false);

            modelBuilder.Entity<USER>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<XE>()
                .Property(e => e.BienSo)
                .IsUnicode(false);

            modelBuilder.Entity<XE>()
                .Property(e => e.MaTheXe)
                .IsUnicode(false);
        }
    }
}
