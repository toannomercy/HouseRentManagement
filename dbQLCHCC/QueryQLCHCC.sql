-- Tao DB
Create database QLCHCC 
--on 
--(
--	name = 'D:\WorkSpaces\dbQLCHCC\QLCHCC_Data',
--	filename = 'D:\WorkSpaces\dbQLCHCC\QLCHCC.MDF'
--)
--log on 
--(
--	name = 'D:\WorkSpaces\dbQLCHCC\QLCHCC_Log',
--	filename = 'D:\WorkSpaces\dbQLCHCC\QLCHCC.LDF'
--)
use QLCHCC
use master

--Tao Bang
go
create table LOAICANHO
(
	MaLoai varchar(20) not null constraint PK_LOAICANHO primary key,
	TenLoai nvarchar(50),
	DienTich float,
	SoPhongNgu int,
	GiaThueMacDinh Decimal(20, 3),
	Constraint DienTich_Check check (DienTich in (30, 40, 60, 90)),
	Constraint SoPhongNgu_Check check (SoPhongNgu in (1, 2, 3)),
	Constraint GiaThueMacDinh_Check check (GiaThueMacDinh in (5000000, 6500000, 7000000, 8500000))
)
go 
Create table TANG
(
	MaTang varchar(20) not null constraint PK_TANG primary key,
	Tang nvarchar(30),
	SoCanHo int
)
go
Create table NGUOITHUE
(
	MaNguoiThue varchar(20) not null constraint PK_NGUOITHUE primary key,
	TenNguoiThue nvarchar(50) not null,
	CCCD varchar(12) not null,
	NgaySinh Date,
	GioiTinh bit,
	SDT varchar(10),
	Email varchar(50),
	constraint CCCD_NGUOITHUE check (CCCD LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	constraint GioiTinh_NGUOITHUE check (GioiTinh in (0, 1)),
	constraint SDT_NGUOITHUE check (SDT like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
go
Create table CHUSOHUU
(
	MaChuSoHuu varchar(20) not null constraint PK_CHUSOHUU primary key,
	TenChuSoHuu nvarchar(50) not null,
	CCCD varchar(12) not null,
	NgaySinh Date,
	GioiTinh bit,
	SDT varchar(10),
	Email varchar(50),
	constraint CCCD_CHU check (CCCD LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	constraint GioiTinh_CHU check (GioiTinh in (0, 1)),
	constraint SDT_CHU check (SDT like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
go
Create table CHUCVU
(
	MaCV varchar(20) not null constraint PK_CHUCVU primary key,
	TenChucVu nvarchar(50),
	LuongCoBan Decimal (20,3)
)
go
Create table BANQUANLY
(
	MaQL varchar(20) not null constraint PK_BANQUANLY primary key,
	TenQuanLy nvarchar(50) not null,
	MaCV varchar(20) not null,
	CCCD varchar(12) not null,
	NgaySinh Date,
	GioiTinh bit,
	SDT varchar(10),
	Email varchar(50),
	constraint CCCD_QL check (CCCD LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	constraint GioiTinh_BANQL check (GioiTinh in (0, 1)),
	constraint SDT_QL check (SDT like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
	constraint FK_BANQL_MACV foreign key(MaCV) references CHUCVU(MaCV)
)
go
Create table ADMINS
(
	MaQL varchar(20) not null constraint PK_ADMINS primary key,
	MatKhau varchar(60) not null,
	constraint MATKHAU_ADMINS_CHECK check (len(MatKhau) >= 8),
	constraint MATKHAU_ADMINS_KHACNAME check (MatKhau <> MaQL),
	constraint FK_ADMINS_MAQL foreign key(MaQL) references BANQUANLY(MaQL)
)
go
Create table THECUDAN
(
	MaTheCuDan varchar(20) not null constraint PK_THECUDAN primary key,
	NgayLap Date,
	HSD int,
	MaNguoiThue varchar(20) not null,
	constraint FK_THECUDAN_MANGUOITHUE foreign key(MaNguoiThue) references NGUOITHUE(MaNguoiThue)
)
go
Create table USERS
(
	MaTheCuDan varchar(20) not null constraint PK_USERS primary key,
	MatKhau varchar(60) not null,
	constraint MATKHAU_USERS_CHECK check (len(MatKhau) >= 8),
	constraint MATKHAU_USERS_KHACNAME check (MatKhau <> MaTheCuDan),
	constraint FK_USERS_MAQL foreign key(MaTheCuDan) references THECUDAN(MaTheCuDan)
)
go
Create table THEXE
(
	MaTheXe varchar(20) not null constraint PK_THEXE primary key,
	NgayLap Date,
	HSD int, 
	MaTheCuDan varchar(20) not null,
	constraint FK_THEXE_MATHECUDAN foreign key(MaTheCuDan) references THECUDAN(MaTheCuDan)
)
go
Create table XE
(
	BienSo varchar(9) not null constraint PK_XE primary key,
	TenXe nvarchar (50),
	LoaiCoGioi nvarchar (30),
	MaTheXe varchar(20) not null,
	constraint FK_XE_MATHEXE foreign key(MaTheXe) references THEXE(MaTheXe)
)
Create table CANHO
(
	MaCanHo varchar(20) not null constraint PK_CANHO primary key,
	TinhTrang nvarchar(20) not null,
	constraint TinhTrang_Check check (TinhTrang in (N'Trống', N'Đầy', N'Đang Sửa Chữa')),
	MaTang varchar(20) not null,
	MaChuSoHuu varchar(20) not null,
	MaLoai varchar(20) not null,
	constraint FK_CANHO_MATANG foreign key(MaTang) references TANG(MaTang),
	constraint FK_CANHO_MACHUSOHUU foreign key(MaChuSoHuu) references CHUSOHUU(MaChuSoHuu),
	constraint FK_CANHO_MALOAI foreign key(MaLoai) references LOAICANHO(MaLoai)
)
go
Create table NOITHATCOBAN
(
	MaNTCB varchar(20) not null constraint PK_NOITHATCOBAN primary key,
	TenNoiThat nvarchar(50),
	TrangThai nvarchar(50),
	SoLuong int,
	NgayMua date
)
go
Create table CTNTCB
(
	MaNTCB varchar(20) not null,
	MaCanHo varchar(20) not null,
	NgayTrangBi date,
	SoLuongTB int,
	constraint PK_CTNTCB primary key(MaNTCB, MaCanHo),
	constraint FK_CTNTCB_MANOITHAT foreign key(MaNTCB) references NOITHATCOBAN(MaNTCB),
	constraint FK_CTNTCB_MACANHO foreign key(MaCanHo) references CANHO(MaCanHo)
)
go
Create table HOPDONGTHUE
(
	SoHopDong varchar(20) not null constraint PK_HOPDONGTHUE primary key,
	NgayLap date,
	TienCoc Decimal(20,3),
	TienThue Decimal(20,3),
	NoiDung nvarchar(200),
	NgayBD date,
	NgayKT date,
	MaChuSoHuu varchar(20) not null,
	MaNguoiThue varchar(20) not null,
	MaCanHo varchar(20) not null,
	constraint FK_HD_MACANHO foreign key (MaCanHo) references CANHO(MaCanHo),
	constraint FK_HD_MACHUSOHUU foreign key (MaChuSoHuu) references CHUSOHUU(MaChuSoHuu),
	constraint FK_HD_MANGUOITHUE foreign key (MaNguoiThue) references NGUOITHUE(MaNguoiThue)
)
go
Create table DANHSACHNHANKHAU
(
	MaNguoiThue varchar(20) not null,
	MaCanHo varchar(20) not null,
	QuanHeVoiChuThue nvarchar(50),
	NgayDenO date,
	NgayRoiDi date,
	constraint PK_DSNK primary key(MaNguoiThue, MaCanHo),
	constraint FK_DSNK_MANGUOITHUE foreign key(MaNguoiThue) references NGUOITHUE(MaNguoiThue),
	constraint FK_DSNK_MACANHO foreign key(MaCanHo) references CANHO(MaCanHo)
)
go
Create table HOADONTHANHTOAN
(
	SoHoaDon varchar(20) not null constraint PK_HOADONTT primary key,
	NgayLap date,
	TongTien Decimal(20, 3),
	TrangThai nvarchar(50),
	GhiChu nvarchar(200),
	MaCanHo varchar(20) not null,
	constraint FK_HOADON_MACANHO foreign key(MaCanHo) references CANHO(MaCanHo)
)
go
Create table BANGGIA
(
	MaBangGia varchar(20) not null constraint PK_BANGGIA primary key,
	TenDichVu nvarchar(50),
	DonViTinh nvarchar(30),
	GiaTien Decimal(20, 3),
	TrangThai nvarchar(20),
	constraint TRANGTHAI_BANGGIA check (TrangThai in(N'Đang sử dụng', N'Ngừng sử dụng'))
)
go
Create table CTHDTT
(
	SoHoaDon varchar(20) not null,
	MaBangGia varchar(20) not null,
	TuNgay date, 
	DenNgay date,
	SoLuong int,
	ThanhTien Decimal(20, 3),
	constraint PK_CTHDTT primary key(SoHoaDon, MaBangGia),
	constraint FK_CTHDTT_SOHOADON foreign key(SoHoaDon) references HOADONTHANHTOAN(SoHoaDon),
	constraint FK_CTHDTT_MABANGGIA foreign key(MaBangGia) references BANGGIA(MaBangGia)
)
go
Create table PHIEUPHANHOI
(
	SoPhieuPhanHoi varchar(20) not null constraint PK_PHIEUPHANHOI primary key,
	NgayLap date, 
	NoiDung Nvarchar(200),
	TinhTrang nvarchar(20),
	MaCanHo varchar(20) not null,
	constraint FK_PHIEUPHANHOI_MACANHO foreign key(MaCanHo) references CANHO(MaCanHo)
)
go
Create table PHIEUSUACHUA
(
	SoPhieuSuaChua varchar(20) not null constraint PK_PHIEUSUACHUA primary key,
	NgayLap date, 
	NoiDung nvarchar(200),
	TongTien Decimal(20, 3),
	DonViSuaChua nvarchar(50),
	MaCanHo varchar(20) not null,
	constraint FK_PHIEUSUACHUA_MACANHO foreign key(MaCanHo) references CANHO(MaCanHo)

)
go
Create table PHIEUPHAT
(
	SoPhieuPhat varchar(20) not null constraint PK_PHIEUPHAT primary key,
	NgayLap date, 
	NoiDung nvarchar(200),
	ThanhTien Decimal(20, 3),
	MaCanHo varchar(20) not null,
	constraint FK_PHIEUPHAT_MACANHO foreign key(MaCanHo) references CANHO(MaCanHo)
)
go
Create table PHIEUCHUYENDO
(
	SoPhieuChuyenDo varchar(20) not null constraint PK_PHIEUCHUYENDO primary key,
	NgayLap date,
	NoiDung nvarchar(200),
	TrangThai nvarchar(50),
	BDChuyen datetime,
	KTChuyen datetime,
	MaCanHo varchar(20) not null,
	constraint FK_PHIEUCHUYENDO_MACANHO foreign key(MaCanHo) references CANHO(MaCanHo)
)
go
Create table PHIEUTHICONG
(
	SoPhieuThiCong varchar(20) not null constraint PK_PHIEUTHICONG primary key,
	NgayLap date,
	NoiDung nvarchar(200),
	TinhTrang nvarchar(30),
	BDThiCong datetime,
	KTThiCong datetime,
	MaCanHo varchar(20) not null,
	constraint FK_PHIEUTHICONG_MACANHO foreign key(MaCanHo) references CANHO(MaCanHo)
)

-- Them du lieu
INSERT INTO LOAICANHO (MaLoai, TenLoai, DienTich, SoPhongNgu, GiaThueMacDinh)
VALUES ('ST', N'Studio', 30, 1, 5000000);
INSERT INTO LOAICANHO (MaLoai, TenLoai, DienTich, SoPhongNgu, GiaThueMacDinh)
VALUES ('1PN', N'Căn 1 phòng ngủ', 40, 1, 6500000);
INSERT INTO LOAICANHO (MaLoai, TenLoai, DienTich, SoPhongNgu, GiaThueMacDinh)
VALUES ('2PN', N'Căn 2 phòng ngủ', 60, 2, 7000000);
INSERT INTO LOAICANHO (MaLoai, TenLoai, DienTich, SoPhongNgu, GiaThueMacDinh)
VALUES ('3PN', N'Căn 3 phòng ngủ', 90, 3, 8500000);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F001', N'Tầng 1', 10);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F002', N'Tầng 2', 11);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F003', N'Tầng 3', 12);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F004', N'Tầng 4', 14);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F005', N'Tầng 5', 10);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F006', N'Tầng 6', 11);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F007', N'Tầng 7', 12);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F008', N'Tầng 8', 10);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F009', N'Tầng 9', 9);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F010', N'Tầng 10', 11);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F011', N'Tầng 11', 10);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F012', N'Tầng 12', 9);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F013', N'Tầng 13', 8);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F014', N'Tầng 14', 11);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F015', N'Tầng 15', 12);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F016', N'Tầng 16', 9);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F017', N'Tầng 17', 10);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F018', N'Tầng 18', 8);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F019', N'Tầng 19', 11);
INSERT INTO TANG (MaTang, Tang, SoCanHo)
VALUES ('F020', N'Tầng 20', 10);
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH01', N'Nguyễn Văn An', '079228009560', '2000-01-01', 1, '0909900009', 'anne@gmail.com');
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH02', N'Chu Thị Hương', '076807001085', '1996-11-02', 0, '0845173534', 'smell@gmail.com');
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH03', N'Trần Ngọc Anh Thư', '078060622006', '2001-03-27', 0, '0436144372', 'athu@gmail.com');
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH04', N'Nguyễn Lê Kỳ Nam', '074119480195', '1984-12-20', 1, '0427444824', 'namky@gmail.com');
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH05', N'Lê Thị Lệ', '079521207130', '2003-04-01', 0, '0356542142', 'leecry@gmail.com');
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH06', N'Lê Văn Nam', '071319340250', '1997-09-08', 1, '0554146600', 'namlee@gmail.com');
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH07', N'Lê Bảo Anh', '079476897968', '1990-06-07', 0, '0804184902', 'ruby@gmail.com');
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH08', N'Nguyễn Thị Thủy', '077088838867', '1993-1-12', 0, '0281906234', 'water@gmail.com');
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH09', N'Trần Trung Tiến', '079667614809', '2000-12-14', 1, '0357462255', 'sound@gmail.com');
INSERT INTO NGUOITHUE (MaNguoiThue, TenNguoiThue, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('KH10', N'Lê Thành Công', '079179646561', '1999-09-12', 1, '0273507057', 'success@gmail.com');
INSERT INTO CHUSOHUU (MaChuSoHuu, TenChuSoHuu, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('CHU01', N'Lê Đại Nam', '076553134960', '1984-12-14', 1, '0185849002', 'dainam@gmail.com');
INSERT INTO CHUSOHUU (MaChuSoHuu, TenChuSoHuu, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('CHU02', N'Trần Công Vinh', '071526265441', '1987-04-01', 1, '0468035667', 'congvien@gmail.com');
INSERT INTO CHUSOHUU (MaChuSoHuu, TenChuSoHuu, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('CHU03', N'Nguyễn Thủy Tiên', '074276200387', '1985-01-04', 0, '0574700730', 'thuytinh@gmail.com');
INSERT INTO CHUSOHUU (MaChuSoHuu, TenChuSoHuu, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('CHU04', N'Nguyễn Phương Hằng', '070082881374', '1980-12-12', 0, '0216534848', 'hanghayho@gmail.com');
INSERT INTO CHUSOHUU (MaChuSoHuu, TenChuSoHuu, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('CHU05', N'Văn Hoài Linh', '073545676935', '1977-05-03', 1, '0159735328', 'linhtienty@gmail.com');
INSERT INTO CHUCVU (MaCV, TenChucVu, LuongCoBan)
VALUES('GD', N'Giám đốc', 60000000);
INSERT INTO CHUCVU (MaCV, TenChucVu, LuongCoBan)
VALUES('QL', N'Quản lý', 20000000);
INSERT INTO CHUCVU (MaCV, TenChucVu, LuongCoBan)
VALUES('LT', N'Lễ Tân', 10000000);
INSERT INTO CHUCVU (MaCV, TenChucVu, LuongCoBan)
VALUES('BV', N'Bảo vệ', 7000000);
INSERT INTO CHUCVU (MaCV, TenChucVu, LuongCoBan)
VALUES('KT', N'Nhân viên kỹ thuật', 9000000);
INSERT INTO BANQUANLY(MaQL, TenQuanLy, MaCV, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('QL01', N'Nguyễn Trường Tồn', 'QL', '073785676935', '1977-05-03', 1, '0159735456', 'truongton@gmail.com');
INSERT INTO BANQUANLY(MaQL, TenQuanLy, MaCV, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('GD01', N'Lê Văn Hùng', 'GD', '073789374655', '1969-07-03', 1, '0159774932', 'vanhung@gmail.com');
INSERT INTO BANQUANLY(MaQL, TenQuanLy, MaCV, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('LT01', N'Nguyễn Anh Thư', 'LT', '073477460087', '1999-04-04', 0, '0400717286', 'qlathu@gmail.com');
INSERT INTO BANQUANLY(MaQL, TenQuanLy, MaCV, CCCD, NgaySinh, GioiTinh, SDT, Email)
VALUES('QL02', N'Trần Trọng Trường', 'QL', '073448081147', '1971-08-07', 1, '0931776235', 'truong@gmail.com');
INSERT INTO ADMINS (MaQL, MatKhau)
VALUES ('GD01', 'passgiamdoc');
INSERT INTO ADMINS (MaQL, MatKhau)
VALUES ('QL01', 'passquanly1');
INSERT INTO ADMINS (MaQL, MatKhau)
VALUES ('QL02', 'passquanly2');
INSERT INTO ADMINS (MaQL, MatKhau)
VALUES ('LT01', 'passletan');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T001', '2023-01-03', 12, 'KH01');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T002', '2022-12-01', 24, 'KH02');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T003', '2023-07-03', 24, 'KH03');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T004', '2021-01-04', 36, 'KH04');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T005', '2022-02-02', 24, 'KH05');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T006', '2023-01-03', 12, 'KH06');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T007', '2022-12-01', 24, 'KH07');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T008', '2023-07-03', 24, 'KH08');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T009', '2023-07-03', 24, 'KH09');
INSERT INTO THECUDAN (MaTheCuDan, NgayLap, HSD, MaNguoiThue)
VALUES ('T010', '2022-02-02', 24, 'KH10');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T001','passcudan1');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T002','passcudan2');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T003','passcudan3');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T004','passcudan4');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T005','passcudan5');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T006','passcudan6');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T007','passcudan7');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T008','passcudan8');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T009','passcudan9');
INSERT INTO USERS (MaTheCuDan, MatKhau)
VALUES ('T010','passcudan10');
INSERT INTO THEXE (MaTheXe, NgayLap, HSD, MaTheCuDan)
VALUES ('TX01','2023-01-03', 12, 'T001');
INSERT INTO THEXE (MaTheXe, NgayLap, HSD, MaTheCuDan)
VALUES ('TX02','2022-12-01', 24, 'T002');
INSERT INTO THEXE (MaTheXe, NgayLap, HSD, MaTheCuDan)
VALUES ('TX03','2023-07-03', 24, 'T003');
INSERT INTO THEXE (MaTheXe, NgayLap, HSD, MaTheCuDan)
VALUES ('TX04','2021-01-04', 36, 'T004');
INSERT INTO THEXE (MaTheXe, NgayLap, HSD, MaTheCuDan)
VALUES ('TX05','2022-02-02', 24, 'T005');
INSERT INTO XE (BienSo, TenXe, LoaiCoGioi, MaTheXe)
VALUES ('XE001', N'Wave alpha', N'Xe mô tô hai bánh', 'TX01');
INSERT INTO XE (BienSo, TenXe, LoaiCoGioi, MaTheXe)
VALUES ('XE002', N'AirBlack', N'Xe mô tô hai bánh', 'TX02');
INSERT INTO XE (BienSo, TenXe, LoaiCoGioi, MaTheXe)
VALUES ('XE003', N'Mazda', N'Xe ô tô', 'TX03');
INSERT INTO XE (BienSo, TenXe, LoaiCoGioi, MaTheXe)
VALUES ('XE004', N'BMW', N'Xe ô tô', 'TX04');
INSERT INTO XE (BienSo, TenXe, LoaiCoGioi, MaTheXe)
VALUES ('XE005', N'Kawasaki Z1000', N'Xe mô tô', 'TX05');
INSERT INTO CANHO (MaCanHo, TinhTrang, MaTang, MaChuSoHuu, MaLoai)
VALUES ('VIN001', N'Đầy', 'F010', 'CHU01', '2PN');
INSERT INTO CANHO (MaCanHo, TinhTrang, MaTang, MaChuSoHuu, MaLoai)
VALUES ('VIN002', N'Đầy', 'F011', 'CHU02', 'ST');
INSERT INTO CANHO (MaCanHo, TinhTrang, MaTang, MaChuSoHuu, MaLoai)
VALUES ('VIN003', N'Đầy', 'F002', 'CHU03', '3PN');
INSERT INTO CANHO (MaCanHo, TinhTrang, MaTang, MaChuSoHuu, MaLoai)
VALUES ('VIN004', N'Đầy', 'F003', 'CHU04', '1PN');
INSERT INTO CANHO (MaCanHo, TinhTrang, MaTang, MaChuSoHuu, MaLoai)
VALUES ('VIN005', N'Đầy', 'F009', 'CHU05', '2PN');
INSERT INTO HOPDONGTHUE (SoHopDong, NgayLap, TienCoc, TienThue, NgayBD, NgayKT, MaChuSoHuu, MaNguoiThue, MaCanHo)
VALUES ('HD001', '2023-01-03', 15000000, 7500000, '2023-01-06', '2024-01-06', 'CHU01', 'KH01', 'VIN001');
INSERT INTO HOPDONGTHUE (SoHopDong, NgayLap, TienCoc, TienThue, NgayBD, NgayKT, MaChuSoHuu, MaNguoiThue, MaCanHo)
VALUES ('HD002', '2022-12-01', 10000000, 5500000, '2022-12-03', '2024-12-03', 'CHU02', 'KH02', 'VIN002');
INSERT INTO HOPDONGTHUE (SoHopDong, NgayLap, TienCoc, TienThue, NgayBD, NgayKT, MaChuSoHuu, MaNguoiThue, MaCanHo)
VALUES ('HD003', '2023-07-03', 20000000, 10000000, '2023-07-06', '2025-07-06', 'CHU03', 'KH03', 'VIN003');
INSERT INTO HOPDONGTHUE (SoHopDong, NgayLap, TienCoc, TienThue, NgayBD, NgayKT, MaChuSoHuu, MaNguoiThue, MaCanHo)
VALUES ('HD004', '2021-01-04', 7000000, 5000000, '2021-01-07', '2024-01-07', 'CHU04', 'KH04', 'VIN004');
INSERT INTO HOPDONGTHUE (SoHopDong, NgayLap, TienCoc, TienThue, NgayBD, NgayKT, MaChuSoHuu, MaNguoiThue, MaCanHo)
VALUES ('HD005', '2022-02-02', 15000000, 8000000, '2022-02-06', '2024-02-06', 'CHU05', 'KH05', 'VIN005');
INSERT INTO NOITHATCOBAN (MaNTCB, TenNoiThat, TrangThai, SoLuong, NgayMua)
VALUES ('ML', N'Máy lạnh', N'Mới', 300, '2021-01-01');
INSERT INTO NOITHATCOBAN (MaNTCB, TenNoiThat, TrangThai, SoLuong, NgayMua)
VALUES ('QA', N'Quạt', N'Mới', 250, '2021-01-01');
INSERT INTO NOITHATCOBAN (MaNTCB, TenNoiThat, TrangThai, SoLuong, NgayMua)
VALUES ('BE', N'Bếp điện', N'Mới', 400, '2021-01-01');
INSERT INTO NOITHATCOBAN (MaNTCB, TenNoiThat, TrangThai, SoLuong, NgayMua)
VALUES ('TU', N'Tủ lạnh', N'Mới', 300, '2021-01-01');
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('ML', 'VIN001', '2021-01-02', 2);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('ML', 'VIN002', '2021-01-02', 1);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('ML', 'VIN003', '2021-01-02', 3);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('ML', 'VIN004', '2021-01-02', 1);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('ML', 'VIN005', '2021-01-02', 2);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('TU', 'VIN003', '2021-01-02', 1);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('BE', 'VIN003', '2021-01-02', 1);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('QA', 'VIN003', '2021-01-02', 2);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('TU', 'VIN005', '2021-01-02', 1);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('BE', 'VIN001', '2021-01-02', 1);
INSERT INTO CTNTCB (MaNTCB, MaCanHo, NgayTrangBi, SoLuongTB)
VALUES ('BE', 'VIN004', '2021-01-02', 1);
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH01', 'VIN001', N'Chủ Thuê', '2023-01-06', '2024-01-06');
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH06', 'VIN001', N'Anh họ', '2023-01-06', '2024-01-06');
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH02', 'VIN002', N'Chủ Thuê', '2022-12-03', '2024-12-03');
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH07', 'VIN002', N'Chị ruột', '2022-12-03', '2024-12-03');
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH03', 'VIN003', N'Chủ Thuê', '2023-07-06', '2025-07-06');
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH08', 'VIN003', N'Chị Chồng', '2023-07-06', '2025-07-06');
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH09', 'VIN003', N'Chồng', '2023-07-06', '2025-07-06');
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH04', 'VIN004', N'Chủ Thuê', '2021-01-07', '2024-01-07');
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH05', 'VIN005', N'Chủ Thuê', '2022-02-06', '2024-02-06');
INSERT INTO DANHSACHNHANKHAU (MaNguoiThue, MaCanHo, QuanHeVoiChuThue, NgayDenO, NgayRoiDi)
VALUES ('KH10', 'VIN005', N'Chồng', '2022-02-06', '2024-02-06');
INSERT INTO BANGGIA(MaBangGia, TenDichVu, DonViTinh, GiaTien)
VALUES ('DIEN', N'Cấp Điện', N'kWh', 3000);
INSERT INTO BANGGIA(MaBangGia, TenDichVu, DonViTinh, GiaTien)
VALUES ('NUOC', N'Cấp nước', N'm3', 14000);
INSERT INTO BANGGIA(MaBangGia, TenDichVu, DonViTinh, GiaTien)
VALUES ('QLST', N'Phí quản lý căn hộ STUDIO', N'Tháng', 300000);
INSERT INTO BANGGIA(MaBangGia, TenDichVu, DonViTinh, GiaTien)
VALUES ('QL1PN', N'Phí quản lý căn hộ 1 phòng ngủ', N'Tháng', 500000);
INSERT INTO BANGGIA(MaBangGia, TenDichVu, DonViTinh, GiaTien)
VALUES ('QL2PN', N'Phí quản lý căn hộ 2 phòng ngủ', N'Tháng', 700000);
INSERT INTO BANGGIA(MaBangGia, TenDichVu, DonViTinh, GiaTien)
VALUES ('QL3PN', N'Phí quản lý căn hộ 3 phòng ngủ', N'Tháng', 900000);
INSERT INTO BANGGIA(MaBangGia, TenDichVu, DonViTinh, GiaTien)
VALUES ('GXD', N'Phí giữ xe đạp', N'Chiếc/ Tháng', 100000);
INSERT INTO BANGGIA(MaBangGia, TenDichVu, DonViTinh, GiaTien)
VALUES ('GXM', N'Phí giữ xe máy', N'Chiếc/ Tháng', 150000);
INSERT INTO BANGGIA(MaBangGia, TenDichVu, DonViTinh, GiaTien)
VALUES ('GXOTO', N'Phí giữ xe ô tô', N'Chiếc/ Tháng', 1250000);
INSERT INTO HOADONTHANHTOAN(SoHoaDon, NgayLap, TongTien, TrangThai, GhiChu, MaCanHo)
VALUES ('001', '2023-03-03', 2020000, N'Chưa Thanh Toán', N'Hoá đơn tháng 02-2023', 'VIN001');
INSERT INTO HOADONTHANHTOAN(SoHoaDon, NgayLap, TongTien, TrangThai, GhiChu, MaCanHo)
VALUES ('002', '2023-04-04', 1180000, N'Chưa Thanh Toán', N'Hoá đơn tháng 03-2023', 'VIN002');
INSERT INTO HOADONTHANHTOAN(SoHoaDon, NgayLap, TongTien, TrangThai, GhiChu, MaCanHo)
VALUES ('003', '2023-08-08', 4310000, N'Chưa Thanh Toán', N'Hoá đơn tháng 07-2023', 'VIN003');
INSERT INTO HOADONTHANHTOAN(SoHoaDon, NgayLap, TongTien, TrangThai, GhiChu, MaCanHo)
VALUES ('004', '2023-02-04', 2549000, N'Chưa Thanh Toán', N'Hoá đơn tháng 01-2023', 'VIN004');
INSERT INTO HOADONTHANHTOAN(SoHoaDon, NgayLap, TongTien, TrangThai, GhiChu, MaCanHo)
VALUES ('005', '2023-02-02', 2450000, N'Chưa Thanh Toán', N'Hoá đơn tháng 01-2023', 'VIN005');
INSERT INTO HOADONTHANHTOAN(SoHoaDon, NgayLap, TongTien, TrangThai, GhiChu, MaCanHo)
VALUES ('006', '2023-09-03', 2590000, N'Chưa Thanh Toán', N'Hoá đơn tháng 08-2023', 'VIN001');
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('001','QL2PN','2023-02-03','2023-03-03', 1, 700000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('001','DIEN','2023-02-03','2023-03-03', 250, 750000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('001','NUOC','2023-02-03','2023-03-03', 30, 420000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('001','GXM','2023-02-03','2023-03-03', 1, 150000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('002','QLST','2023-03-04','2023-04-04', 1, 300000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('002','DIEN','2023-03-04','2023-04-04', 150, 450000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('002','NUOC','2023-03-04','2023-04-04', 20, 280000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('002','GXM','2023-03-04','2023-04-04', 1, 150000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('003','QL3PN','2023-07-08','2023-08-08', 1, 900000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('003','DIEN','2023-07-08','2023-08-08', 440, 13200000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('003','NUOC','2023-07-08','2023-08-08', 60, 840000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('003','GXOTO','2023-07-08','2023-08-08', 1, 1250000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('004','QL1PN','2023-01-04','2023-02-04', 1, 500000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('004','DIEN','2023-01-04','2023-02-04', 145, 435000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('004','NUOC','2023-01-04','2023-02-04', 26, 364000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('004','GXOTO','2023-01-04','2023-02-04', 1, 1250000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('005','QL2PN','2023-01-02','2023-02-02', 1, 700000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('005','DIEN','2023-01-02','2023-02-02', 300, 900000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('005','NUOC','2023-01-02','2023-02-02', 50, 700000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('005','GXM','2023-01-02','2023-02-02', 1, 150000);	
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('006','QL2PN','2023-08-03','2023-09-03', 1, 700000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('006','DIEN','2023-08-03','2023-09-03', 300, 900000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('006','NUOC','2023-08-03','2023-09-03', 60, 840000);
INSERT INTO CTHDTT(SoHoaDon, MaBangGia, TuNgay, DenNgay, SoLuong, ThanhTien)
VALUES ('006','GXM','2023-08-03','2023-09-03', 1, 150000);
INSERT INTO PHIEUPHANHOI(SoPhieuPhanHoi, NgayLap, NoiDung, TinhTrang, MaCanHo)
VALUES('PH001', '2023-01-01', N'Cư dân ở căn hộ VIN002 thường xuyên gây ồn ào sau 22h', N'Đã duyệt', 'VIN001');
INSERT INTO PHIEUPHANHOI(SoPhieuPhanHoi, NgayLap, NoiDung, TinhTrang, MaCanHo)
VALUES('PH002', '2023-03-01', N'Tường nhà có dấu hiệu nứt rạn', N'Đã duyệt', 'VIN003');
INSERT INTO PHIEUPHANHOI(SoPhieuPhanHoi, NgayLap, NoiDung, TinhTrang, MaCanHo)
VALUES('PH003', '2023-04-05', N'Nước yếu', N'Đã duyệt','VIN004');
INSERT INTO PHIEUSUACHUA(SoPhieuSuaChua, NgayLap, NoiDung, TongTien, DonViSuaChua, MaCanHo)
VALUES('SC001', '2023-03-04', N'Trám tường', 10000000, N'cty Xây dựng An Tâm', 'VIN003');
INSERT INTO PHIEUSUACHUA(SoPhieuSuaChua, NgayLap, NoiDung, TongTien, DonViSuaChua, MaCanHo)
VALUES('SC002', '2023-04-07', N'Thay vòi nước', 500000, N'cty Xây dựng An Tâm', 'VIN004');
INSERT INTO PHIEUPHAT(SoPhieuPhat, NgayLap, NoiDung, ThanhTien, MaCanHo)
VALUES ('P001', '2023-01-05', N'Gây ồn ào sau 22h nhiều lần dù đã lập biên bản và nhắc nhở', 2000000, 'VIN002');
INSERT INTO PHIEUCHUYENDO(SoPhieuChuyenDo, NgayLap, NoiDung, TrangThai, BDChuyen, KTChuyen, MaCanHo)
VALUES ('CD001', '2023-01-08', N'Chuyển ghế sofa qua cổng chính, thang máy số 1', N'Đã Duyệt', '2023-01-09 09:00:00', '2023-01-09 11:00:00', 'VIN001');
INSERT INTO PHIEUCHUYENDO(SoPhieuChuyenDo, NgayLap, NoiDung, TrangThai, BDChuyen, KTChuyen, MaCanHo)
VALUES ('CD002', '2022-12-03', N'Chuyển bàn ghế qua cổng chính, thang máy số 3', N'Đã Duyệt', '2022-12-04 13:00:00', '2022-12-04 15:00:00', 'VIN002');
INSERT INTO PHIEUCHUYENDO(SoPhieuChuyenDo, NgayLap, NoiDung, TrangThai, BDChuyen, KTChuyen, MaCanHo)
VALUES ('CD003', '2023-07-06', N'Chuyển giường ngủ và tủ quần áo qua cổng chính, thang máy số 2', N'Đã Duyệt', '2023-07-07 07:00:00', '2023-07-07 10:00:00', 'VIN003');
INSERT INTO PHIEUTHICONG(SoPhieuThiCong, NgayLap, NoiDung, TinhTrang, BDThiCong, KTThiCong, MaCanHo)
VALUES ('TC001', '2023-02-08', N'Lắp mạng wifi', N'Đã duyệt', '2023-02-09 09:00:00',  '2023-02-09 12:00:00', 'VIN004');
INSERT INTO PHIEUTHICONG(SoPhieuThiCong, NgayLap, NoiDung, TinhTrang, BDThiCong, KTThiCong, MaCanHo)
VALUES ('TC002', '2022-11-08', N'Trám lại tường', N'Đã duyệt', '2022-11-09 08:00:00',  '2022-11-09 14:00:00', 'VIN005');

-- Drop DB
DROP TABLE XE
go
DROP TABLE USERS
go
DROP TABLE THEXE
go
DROP TABLE THECUDAN
go
DROP TABLE PHIEUTHICONG
go
DROP TABLE PHIEUSUACHUA
go
DROP TABLE PHIEUCHUYENDO
go
DROP TABLE PHIEUPHANHOI
go
DROP TABLE PHIEUPHAT
go
DROP TABLE ADMINS
go
DROP TABLE BANQUANLY
go
DROP TABLE CHUCVU
go
DROP TABLE CTHDTT
go
DROP TABLE HOADONTHANHTOAN
go
DROP TABLE BANGGIA
go
DROP TABLE DANHSACHNHANKHAU
go
DROP TABLE HOPDONGTHUE
go
DROP TABLE CANHO
go
DROP TABLE CTNTCB
go
DROP TABLE NOITHATCOBAN
go
DROP TABLE LOAICANHO
go
DROP TABLE TANG
go
DROP TABLE NGUOITHUE
go
DROP TABLE CHUSOHUU
go