CREATE DATABASE QLQuanCaFe
--DROP DATABASE QLQuanCaFe
USE	QLQuanCaFe
GO

CREATE TABLE NHANVIEN(
	MaNhanVien INT IDENTITY(1, 1),
	TenNhanVien NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(200) NOT NULL,
	SoDienThoai VARCHAR(15),
	ChucVu TINYINT NOT NULL, -- 1 la ADMIN , 0 la NhanVien
	Email VARCHAR(100) NOT NULL,
	MatKhau VARCHAR(max) default '13012420314234138112108765216110414524878123',
	PRIMARY KEY(MaNhanVien)
);
CREATE TABLE SANPHAM(
	MaSanPham INT IDENTITY(1, 1) NOT NULL,
	MaLoai VARCHAR(5) NOT NULL,
	TenSanPham NVARCHAR(50) NOT NULL,
	SoLuongCon INT NOT NULL,
	GiaBan MONEY NOT NULL,
	HinhAnh NVARCHAR(400),
	MoTa NVARCHAR(MAX),
	MaNhanVien INT,
	PRIMARY KEY(MaSanPham)
);
CREATE TABLE LOAISANPHAM(
	MaLoai VARCHAR(5) NOT NULL,
	TenLoai NVARCHAR(50) NOT NULL,
	PRIMARY KEY(MaLoai)
)
CREATE TABLE KHACHHANG(
	SoDienThoai VARCHAR(15) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	TenKhachHang NVARCHAR(100) NOT NULL,
	NgaySinh DATETIME NOT NULL,
	MaNhanVien INT NOT NULL,
	PRIMARY KEY(SoDienThoai)
);
CREATE TABLE HOADON(
	MaHoaDon INT IDENTITY(1, 1) NOT NULL,
	ThoiGian DATETIME,
	TongGiaTien MONEY NOT NULL,
	MaNhanVien INT NOT NULL,
	PRIMARY KEY(MaHoaDon)
);
CREATE TABLE CHITIETHOADON(
	MaHoaDon INT NOT NULL,
	MaSanPham INT NOT NULL,
	SoLuongMua INT NOT NULL,
	PRIMARY KEY(MaHoaDon, MaSanPham)
);
CREATE TABLE DANHSACHMONAN(
	MaLoai VARCHAR(5) NOT NULL,
	MaMonAn INT NOT NULL IDENTITY(1, 1),
	TenMonAn NVARCHAR(50) NOT NULL,
	DonGia MONEY NOT NULL
	PRIMARY KEY(MaLoai)
);

ALTER TABLE dbo.KHACHHANG ADD FOREIGN KEY(MaNhanVien) REFERENCES dbo.NHANVIEN(MaNhanVien);
ALTER TABLE dbo.SANPHAM ADD FOREIGN KEY(MaNhanVien) REFERENCES dbo.NHANVIEN(MaNhanVien);
ALTER TABLE dbo.SANPHAM ADD FOREIGN KEY(MaLoai) REFERENCES dbo.LOAISANPHAM(MaLoai);
ALTER TABLE dbo.HOADON ADD FOREIGN KEY(MaNhanVien) REFERENCES dbo.NHANVIEN(MaNhanVien);
ALTER TABLE dbo.CHITIETHOADON ADD FOREIGN KEY(MaHoaDon) REFERENCES dbo.HOADON(MaHoaDon);
ALTER TABLE dbo.CHITIETHOADON ADD FOREIGN KEY(MaSanPham) REFERENCES dbo.SANPHAM(MaSanPham);
ALTER TABLE dbo.DANHSACHMONAN ADD FOREIGN KEY(MaLoai) REFERENCES dbo.LOAISANPHAM(MaLoai);
GO


 -----------------------------------

CREATE PROCEDURE [dbo].[DangNhap] @email varchar(100),@matKhau nvarchar(300)
AS
BEGIN
      declare @status int
if exists(select * from dbo.NHANVIEN where Email = @email and MatKhau = @matKhau)
       set @status=1
else
       set @status=0
select @status
END
GO

CREATE PROCEDURE QuenMatKhau @email varchar(100)
AS
BEGIN
      declare @status int
if exists(select MaNhanVien from dbo.NHANVIEN where Email = @email )
       set @status=1
else
       set @status=0
select @status
END
GO

CREATE PROCEDURE TaoMatKhauMoi
	@email nvarchar(100),
	@matkhau nvarchar(300)
AS
BEGIN
	UPDATE dbo.NHANVIEN SET MatKhau = @matkhau
	WHERE Email =  @email
END
GO

CREATE PROCEDURE [dbo].[DanhSachNV]
AS
BEGIN
      SELECT Email, TenNhanVien, DiaChi, ChucVu, SoDienThoai FROM dbo.NHANVIEN
END
GO

CREATE PROC [dbo].[chgpwd]
(
	@email Varchar(100),
	@opwd nVarchar(300),
	@npwd nVarchar(300)
)
AS
declare @op varchar(300)
select @op = MatKhau from dbo.NHANVIEN where Email = @email
if @op=@opwd
begin
	UPDATE dbo.NHANVIEN set MatKhau = @npwd where Email = @email
	RETURN 1
end
else
return -1
GO

Create PROCEDURE [dbo].[LayVaiTroNV] @email varchar(50)
AS
BEGIN
      SELECT ChucVu FROM dbo.NHANVIEN
	  where Email = @email
END
GO

CREATE PROCEDURE [dbo].[InsertDataIntoNhanVien]
	@email nvarchar(100),
	@tennv nvarchar(50),
	@diachi nvarchar(100),
	@chucVu tinyint,
	@sodienthoai VARCHAR(15)
AS
BEGIN
	INSERT INTO NHANVIEN( Email, TenNhanVien, DiaChi, ChucVu, SoDienThoai) 
	VALUES (@email, @tennv, @diachi,@chucvu, @sodienthoai) 
END
GO

CREATE PROCEDURE [dbo].[DeleteDataFromtblNhanVien]
	@email varchar(100)
AS
BEGIN
	DELETE FROM dbo.NHANVIEN
	WHERE Email = @email
END
GO

CREATE PROCEDURE [dbo].[UpdateDataIntoTblNhanVien]
	@email nvarchar(100),
	@tenNv nvarchar(50),
	@diaChi nvarchar(200),
	@chucVu TINYINT,
	@sodienthoai VARCHAR(15)
AS
BEGIN
	UPDATE dbo.NHANVIEN SET TenNhanVien = @tenNv, DiaChi = @diaChi, ChucVu = @chucVu, SoDienThoai = @sodienthoai
	where Email  =  @email
END
GO

CREATE PROCEDURE [dbo].[SearchNhanVien]
	@tenNv nvarchar(100)
AS
BEGIN
      SET NOCOUNT ON;
      SELECT Email, TenNhanVien, DiaChi, SoDienThoai, ChucVu
      FROM dbo.NHANVIEN where TenNhanVien like '%' + @tenNv + '%'
END
GO

----- Procedure DAL_Khách

CREATE PROCEDURE [dbo].[DanhSachKhach]
AS
BEGIN
      SET NOCOUNT ON;
      SELECT *
      FROM dbo.KHACHHANG
END
GO

CREATE PROCEDURE [dbo].[InsertDataIntoTblKhach]
@dienThoai varchar(15),@tenKhach nvarchar(100), @email varchar(100), @ngaysinh DATETIME
AS
BEGIN
DECLARE @Manv VARCHAR(20);
select @Manv = MaNhanVien from dbo.NHANVIEN where Email = @email
INSERT INTO KHACHHANG (SoDienThoai, TenKhachHang, NgaySinh,MaNhanVien) 
VALUES ( @dienThoai,@tenKhach, @ngaysinh,@Manv)
END
GO

CREATE PROCEDURE [dbo].[DeleteDataFromtblKhach]
@dienthoai varchar(15)
AS
BEGIN
DELETE FROM dbo.KHACHHANG
WHERE SoDienThoai = @dienthoai
END
GO

CREATE PROCEDURE [dbo].[SearchKhach]
@dienthoai varchar(15)
AS
BEGIN
      SET NOCOUNT ON;
      SELECT *
      FROM dbo.KHACHHANG where SoDienThoai like + '%' + @dienthoai + '%'
END
GO

-- PROCEDURE HÀNG HÓA
CREATE PROCEDURE DanhSachSanPham
AS
BEGIN
      SET NOCOUNT ON;
      SELECT *
      FROM dbo.SANPHAM
END
GO

CREATE PROCEDURE [dbo].[InsertDataIntoTblSanPham]
@tenSanPham nvarchar(50),
@soLuongCon int,
@giaBan MONEY,
@hinhAnh nvarchar(400),
@moTa nvarchar(max),
@email varchar(20)
AS
BEGIN
DECLARE @Manv VARCHAR(20);
select @Manv = MaNhanVien from dbo.NHANVIEN where Email = @email
INSERT INTO SANPHAM (TenSanPham, SoLuongCon, GiaBan, HinhAnh,MoTa, MaNhanVien) 
VALUES ( @tenSanPham, @soLuongCon, @GiaBan, @hinhAnh, @moTa, @Manv) 
END
GO

CREATE PROCEDURE DeleteDataFromtblSanPham
@maSanPham int
AS
BEGIN
DELETE FROM dbo.SANPHAM
WHERE MaSanPham = @maSanPham
END
GO

CREATE PROCEDURE [dbo].[UpdateDataIntoTblSanPham]
@maSanPham int,
@tenSanPham nvarchar(50),
@soLuong int,
@giaBan float,
@hinhAnh nvarchar(400),
@moTa nvarchar(MAX)
AS
BEGIN
UPDATE dbo.SANPHAM SET TenSanPham = @tenSanPham, SoLuongCon = @soLuong,
GiaBan = @giaBan, HinhAnh=@hinhAnh,MoTa = @moTa
where MaSanPham = @maSanPham
END
GO

CREATE PROCEDURE [dbo].[SearchSanPham]
@tenSanPham nvarchar(50)
AS
BEGIN
      SET NOCOUNT ON;
      SELECT TenSanPham, SoLuongCon, GiaBan,HinhAnh, MoTa
      FROM dbo.SANPHAM where TenSanPham like '%' + @tenSanPham + '%'
END
GO

------ Procedure Thong Ke

CREATE PROC ThongKeDoanhThu
AS
BEGIN
	SELECT MaHoaDon, ThoiGian, TongGiaTien FROM dbo.HOADON
END
GO

CREATE PROC ThongKeNguyenLieuConLai
AS
BEGIN
	SELECT MaLoai, MaSanPham, SoLuongCon FROM dbo.SANPHAM
END
GO
exec InsertDataIntoNhanVien @email = 'thanhhoangok2309@gmail.com' ,
							@tennv = N'Hoang' ,
							@diachi = N'Quan 12',
							@chucvu = 1,
							@sodienthoai = '0939674893'
