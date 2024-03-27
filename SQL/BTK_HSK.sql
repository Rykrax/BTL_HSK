CREATE DATABASE BTL_HSK COLLATE Vietnamese_CI_AS;
GO

USE BTL_HSK
GO

CREATE TABLE tblSanPham (
	sMaSP VARCHAR(30) PRIMARY KEY,
	sTenSP NVARCHAR(50),
	sLoaiHang VARCHAR(30),
	sDonViTinh NVARCHAR(50),
	iSoLuong INT DEFAULT 0,
	fGiaTien FLOAT DEFAULT 0.0
)
GO


CREATE TABLE tblLoaiHang (
	sLoaiHang VARCHAR(30) PRIMARY KEY,
	sTenHang NVARCHAR(50)
)
GO

CREATE TABLE tblKhachHang (
	sMaKH VARCHAR(30) PRIMARY KEY,
	sHoTen NVARCHAR(70),
	bGioiTinh BIT,
	sDiaChi NVARCHAR(70),
	sDienThoai VARCHAR(20),
	fTongTienHang FLOAT DEFAULT 0.0,
	CONSTRAINT UC_sDienThoai UNIQUE(sDienThoai)
)
GO

CREATE TABLE tblNhanVien (
	sMaNV VARCHAR(30) PRIMARY KEY,
	sHoTen NVARCHAR(70),
	bGioiTinh BIT,
	dNgayVaoLam SMALLDATETIME,
	fLuongCoBan FLOAT DEFAULT 3000000,
)
GO

CREATE TABLE tblDonDatHang (
	sMaHDDH VARCHAR(30) PRIMARY KEY,
	sMaNV VARCHAR(30), 
	sMaKH VARCHAR(30), 
	dNgayDatHang SMALLDATETIME,
	dNgayGiaoHang SMALLDATETIME,
	sDiaChiGiaoHang NVARCHAR(70),
	fTongTienHang FLOAT DEFAULT 0.0
)
GO

CREATE TABLE tblChiTietDDH (
	sMaHDDH VARCHAR(30) NOT NULL,
	sMaSP VARCHAR(30) NOT NULL,
	iSoLuong INT,
	sDonViTinh NVARCHAR(50)
)
GO

CREATE TABLE tblNhaCungCap (
	sMaNCC VARCHAR(30) PRIMARY KEY,
	sTenNCC NVARCHAR(50),
)
GO

CREATE TABLE tblDonNhapHang (
	sMaHDNH VARCHAR(30) PRIMARY KEY,
	sMaNV VARCHAR(30),	
	sMaNCC VARCHAR(30),
	dNgayNhapHang SMALLDATETIME,
	fTongTienHang FLOAT DEFAULT 0.0
)
GO

CREATE TABLE tblChiTietDNH (
	sMaHDNH VARCHAR(30) NOT NULL,
	sMaSP VARCHAR(30) NOT NULL,
	iSoLuong INT,
	sDonViTinh NVARCHAR(50),
	fGiaTien FLOAT
)
GO

CREATE TABLE Account (
	sTaiKhoan VARCHAR(50) PRIMARY KEY,
	sMatKhau VARCHAR(50),
	sEmail VARCHAR(100)
)

INSERT INTO Account VALUES ('admin', 'admin', 'admin@gmail.com')
--Ràng buộc-------------------------------------------------------------------------------------------------------
ALTER TABLE tblSanPham ADD CONSTRAINT FK_SP_LH FOREIGN KEY(sLoaiHang) REFERENCES tblLoaiHang(sLoaiHang);
ALTER TABLE tblSanPham ADD CONSTRAINT FK_SP_DVT FOREIGN KEY(sMaDVT) REFERENCES tblDonViTinh(sMaDVT);
ALTER TABLE tblDonNhapHang ADD CONSTRAINT FK_DNH_NCC FOREIGN KEY(sMaNCC) REFERENCES tblNhaCungCap(sMaNCC);
ALTER TABLE tblDonNhapHang ADD CONSTRAINT FK_DNH_NV FOREIGN KEY(sMaNV) REFERENCES tblNhanVien(sMaNV);
ALTER TABLE tblChiTietDNH ADD CONSTRAINT PK_NhapHang PRIMARY KEY (sMaHDNH,sMaSP);
ALTER TABLE tblChiTietDNH ADD CONSTRAINT FK_CTDNH_SP FOREIGN KEY (sMaSP) REFERENCES tblSanPham(sMaSP);
ALTER TABLE tblChiTietDNH ADD CONSTRAINT FK_CTDNH_DNH FOREIGN KEY(sMaHDNH) REFERENCES tblDonNhapHang(sMaHDNH);
ALTER TABLE tblDonDatHang ADD CONSTRAINT FK_DDH_NV FOREIGN KEY(sMaNV) REFERENCES tblNhanVien(sMaNV);
ALTER TABLE tblDonDatHang ADD CONSTRAINT FK_DDH_KH FOREIGN KEY(sMaKH) REFERENCES tblKhachHang(sMaKH);
ALTER TABLE tblChiTietDDH ADD CONSTRAINT PK_DatHang PRIMARY KEY (sMaHDDH,sMaSP);
ALTER TABLE tblChiTietDDH ADD CONSTRAINT FK_CTDDH_DDH FOREIGN KEY(sMaHDDH) REFERENCES tblDonDatHang(sMaHDDH);
ALTER TABLE tblChiTietDDH ADD CONSTRAINT FK_CTDDH_SP FOREIGN KEY (sMaSP) REFERENCES tblSanPham(sMaSP);
------------------------------------------------------------------------------------------------------------------



--Thêm dữ liệu----------------------------------------------------------------------------------------------------
INSERT INTO tblKhachHang VALUES
('KH001',N'Nguyễn Thành Công',1,N'255 Định Công Hạ, Hoàng Mai','0983486644',0),
('KH002',N'Nguyễn Tuấn Long',1,N'23 Láng Hạ, Hà Nội','0974863548',0),
('KH003',N'Dương Thành Long',1,N'240 Nguyễn Văn Trỗi, Thị Trấn An Lão','0963876548',0),
('KH004',N'Trương Vũ Lan',0,N'12 Hoàng Xá, Thị Trấn An Lão','0983564634',0),
('KH005',N'Nguyễn Ngọc Linh',0,N'112 Quyết Thắng, Thị Trấn Trường Sơn','0876845754',0),
('KH006',N'Phạm Thành Vinh',1,N'255 Hồng Bàng, Điện Biến Phủ','0878765474',0),
('KH007',N'Phạm Ngọc Lan',0,N'65 Thái Sơn, Thị Trấn An Lão','0872687254',0),
('KH008',N'Hà Thảo Linh',0,N'45 Giải Phóng, Hà Nội','0983495876',0),
('KH009',N'Nguyễn Ngọc Sơn',1,N'96 Định Công, Hoàng Mai','0983404587',0),
('KH010',N'Lê Thảo Linh',0,N'193 Vĩnh Hưng, Hai Bà Trưng','0273676482',0)

/*
SELECT 
    sHoTen AS [Họ tên],
    CASE 
        WHEN bGioiTinh = 1 THEN N'Nam'
        ELSE N'Nữ'
    END AS [Giới tính]
FROM tblKhachHang;


CREATE PROCEDURE [Nhập hàng]
	@TenHang NVARCHAR(50),
	@DonViTinh NVARCHAR(50)
AS
BEGIN
	DECLARE @MaSP VARCHAR(30)
	IF EXISTS (SELECT * FROM tblSanPham WHERE sTenSP = @TenHang AND sDonViTinh = @DonViTinh)
	BEGIN
		SELECT @MaSP = sMaSP FROM tblSanPham WHERE sTenSP = @TenHang AND sDonViTinh = @DonViTinh
	END
END
*/


