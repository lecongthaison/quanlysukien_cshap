Create DATABASE QUANLYSUKIEN
USE QUANLYSUKIEN

GO
--Tạo bảng Tham số
CREATE TABLE [THAMSO]
(
	[TenThamSo] [nvarchar](40) NOT NULL,
	[GiaTri] [int] NULL,
 CONSTRAINT [PK_THAMSO] PRIMARY KEY (TenThamSo)
)
GO
--Tạo bảng Đăng nhập
CREATE TABLE [DANGNHAP]
(
	[MaID] int Identity(1,1),
	[TenDangNhap] [nvarchar] (50) NULL,
	[TaiKhoan] [varchar] (50) NULL,
	[MaDangKy] [varchar] (20) NULL,
	[MatKhau] [varchar] (50) NULL,
 CONSTRAINT [PK_DANGNHAP] PRIMARY KEY (MaID)
)
GO
--Tạo bảng Bằng cấp
CREATE TABLE [CHUCVU]
(
	[MaChucVu] int Identity(1,1),
	[TenChucVu] [nvarchar](40) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY (MaChucVu)
)
GO
--Tạo bảng Nhân viên
CREATE TABLE [NHANVIEN]
(
	[MaNhanVien] int Identity(1,1),
	[HoTenNhanVien] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar] (20) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](15) NULL,
	[MaChucVu] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY (MaNhanVien)
)
GO
--Tạo bảng Khách hàng
CREATE TABLE [KHACHHANG]
(
	[MaKhachHang] int Identity(1,1),
	[HoTenKhachHang] [nvarchar](40) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar] (20) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](30) NULL,
	[NgayLapSuKien] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
	[DienThoai] [nvarchar](15) NULL,
 CONSTRAINT [PK_KHACHHANG_1] PRIMARY KEY (MaKhachHang)
)

GO	
--Tạo bảng Phiếu thu tiền
CREATE TABLE [PHIEUTHUTIEN]
(
	[MaPhieuThuTien] int Identity(1,1),
	[SoTienNo] [float] NULL,
	[SoTienThu] [float] NULL,
	[MaKhachHang] [int] NULL,
	[MaNhanVien] [int] NULL,
 CONSTRAINT [PK_PHIEUTHUTIEN] PRIMARY KEY (MaPhieuThuTien)
)
GO
--Tạo bảng Sự Kiện
CREATE TABLE [SUKIEN]
(
	[MaSuKien] int Identity(1,1),
	[TenSuKien] [nvarchar](40) NULL,
	[NguoiPhuTrach] [nvarchar](30) NULL,
	[TriGia] [float] NULL,
	[NgayLapSuKien] [datetime] NULL,
 CONSTRAINT [PK_SUKIEN] PRIMARY KEY (MaSuKien)
)

GO
--Tạo bảng Phiếu Lập Sự Kiện
CREATE TABLE [PHIEULAPSUKIEN]
(
	[MaPhieuLapSuKien] int Identity(1,1),
	[NgayLap] [datetime] NOT NULL,
	[MaKhachHang] [int] NULL,
 CONSTRAINT [PK_PHIEULAPSUKIEN] PRIMARY KEY (MaPhieuLapSuKien)
)
GO
--Tạo bảng Chi tiết phiếu lập Sự kiện
CREATE TABLE [CHITIETPHIEULAPSUKIEN]
(
	[MaSuKien] [int] NOT NULL,
	[MaPhieuLapSuKien] [int] NOT NULL,
 CONSTRAINT [PK_CHITIETPHIEULAPSUKIEN] PRIMARY KEY (MaSuKien,MaPhieuLapSuKien)
)
GO
--Tạo khoá ngoại
GO
ALTER TABLE [NHANVIEN]  WITH NOCHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([MaChucVu])
REFERENCES [CHUCVU] ([MaChucVu])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUVU]
GO
ALTER TABLE [PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_KHACHHANG]
GO
ALTER TABLE [PHIEUTHUTIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUTIEN_NHANVIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [NHANVIEN] ([MaNhanVien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [PHIEUTHUTIEN] CHECK CONSTRAINT [FK_PHIEUTHUTIEN_NHANVIEN]
GO
ALTER TABLE [PHIEULAPSUKIEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEULAPSUKIEN_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [KHACHHANG] ([MaKhachHang])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [PHIEULAPSUKIEN] CHECK CONSTRAINT [FK_PHIEULAPSUKIEN_KHACHHANG]
GO
ALTER TABLE [CHITIETPHIEULAPSUKIEN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEULAPSUKIEN_PHIEULAPSUKIEN] FOREIGN KEY([MaPhieuLapSuKien])
REFERENCES [PHIEULAPSUKIEN] ([MaPhieuLapSuKien])
GO
ALTER TABLE [CHITIETPHIEULAPSUKIEN] CHECK CONSTRAINT [FK_CHITIETPHIEULAPSUKIEN_PHIEULAPSUKIEN]
GO
ALTER TABLE [CHITIETPHIEULAPSUKIEN]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEULAPSUKIEN_SUKIEN] FOREIGN KEY([MaSuKien])
REFERENCES [SUKIEN] ([MaSuKien])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [CHITIETPHIEULAPSUKIEN] CHECK CONSTRAINT [FK_CHITIETPHIEULAPSUKIEN_SUKIEN]
---Nhap lieu
insert into CHUCVU values(N'Quản Lý')
insert into CHUCVU values(N'Điều Hành')
insert into CHUCVU values(N'Kỹ Thuật')
insert into CHUCVU values(N'Thiết Kế')
insert into CHUCVU values(N'Phục Vụ')

insert into NHANVIEN values(N'Nguyễn Bá Anh','06/01/1994',N'Nam',N'163/30 Thành Thái F.14 Q.10 TPHCM','01636342427',1)
insert into NHANVIEN values(N'Cao Tiến Dũng','04/05/1997',N'Nam',N'41/4 CALMETTE Q1 TPHCM','0969986067',2)
insert into NHANVIEN values(N'Phạm Thành Công','04/13/1997',N'Nam',N'178 NAM KỲ KHỞI NGHĨA Q4 TPHCM','0908783474',3)
insert into NHANVIEN values(N'Nguyễn Thành Vinh','02/18/1997',N'Nam',N'Ngã 4 Hàng Xanh Q.Bình Thạnh TPHCM','0908383274',4)
insert into NHANVIEN values(N'Tô Trường Thịnh','04/23/1995',N'Nam',N'178 NAM KỲ KHỞI NGHĨA Q4 TPHCM','0908732272',5)
select *from NHANVIEN

insert into KHACHHANG values(N'Nguyễn Hoàng Minh','02/23/1990',N'Nam',N'41/4 CALMETTE Q1 TPHCM',N'hoangminh@yahoo.com','12/30/2000','12/30/2012','0934222109')
insert into KHACHHANG values(N'Trần Văn Châu','08/29/1992',N'Nam',N'TRẦN HƯNG ĐẠO Q1 TPHCM',N'vanchau@yahoo.com','11/22/2001','11/22/2013','01666532321')
insert into KHACHHANG values(N'Nguyễn Hoàng Nam','02/21/1980',N'Nam',N'4 TRẦN ĐÌNH HƯNG Q1 TPHCM',N'hoangmNAM@yahoo.com','12/22/2001','12/30/2012','01623421201')
insert into KHACHHANG values(N'Trần Thanh Phúc','08/19/1993',N'Nam',N'TRƯƠNG ĐỊNH Qtb TPHCM',N'thanhphuc@yahoo.com','08/09/2001','11/22/2013','01663121298')
insert into KHACHHANG values(N'Trần Thị Minh Yến','03/29/1994',N'Nữ',N'QUẢNG BÌNH',N'minhyentran@yahoo.com','08/09/2001','11/22/2017','01662341298')
select *from KHACHHANG

insert into SUKIEN values(N'Tổ Chức Đám Cưới',N'Nguyễn Bá Anh',7000000,'12/18/2017')
insert into SUKIEN values(N'Tổ Chức Sinh Nhật ',N'Trần Thị Lệ Thu',5000000,'02/12/2016')
insert into SUKIEN values(N'Tổ Chức Dã Ngoại',N'Nguyễn Khánh Toàn',90000,'12/01/2018')
select *from SUKIEN

insert into DANGNHAP values(N'Lê Công Thái Sơn','thaison','1511061319','23121994')
insert into DANGNHAP values(N'Phạm Nguyễn Đạt Thành','datthanh','1933231298','admin')
select *from DANGNHAP
