CREATE DATABASE BTL_HSK COLLATE Vietnamese_CI_AS;
GO

USE BTL_HSK
GO

CREATE TABLE tblSanPham (
	sMaSP VARCHAR(30) PRIMARY KEY,
	sTenSP NVARCHAR(50),
	sLoaiHang VARCHAR(30),
	sTenDVT NVARCHAR(50)
)
GO

CREATE TABLE tblDonViTinh (
	sMaSP VARCHAR(30),
	sTenDVT NVARCHAR(50),
	iSoLuong INT,
	fGiaTien FLOAT,
	CONSTRAINT PK_DVT PRIMARY KEY(sMaSP,sTenDVT)
)
GO

CREATE TABLE tblLoaiHang (
	sLoaiHang VARCHAR(30) PRIMARY KEY,
	sTenHang NVARCHAR(50)
)
GO

CREATE TABLE tblKhachHang (
	sDienThoai VARCHAR(20) NOT NULL,
	sHoTen NVARCHAR(70),
	bGioiTinh BIT,
	sDiaChi NVARCHAR(255),
	fTongTienHang FLOAT DEFAULT 0.0,
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
	sDiaChiGiaoHang NVARCHAR(70),
	fTongTienHang FLOAT DEFAULT 0.0
)
GO

CREATE TABLE tblChiTietDDH (
	sMaHDDH VARCHAR(30) NOT NULL,
	sMaSP VARCHAR(30) NOT NULL,
	iSoLuong INT,
	sDonViTinh NVARCHAR(50) NOT NULL,
	fGiaTien FLOAT DEFAULT 0.0
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
	sDonViTinh NVARCHAR(50) NOT NULL,
	fGiaTien FLOAT
)
GO

CREATE TABLE tblTiLeChuyenDoi (
	sMaSP VARCHAR(30) NOT NULL,
	sDVThuNhat NVARCHAR(50) NOT NULL,
	sDVThuHai NVARCHAR(50) NOT NULL,
	iTiLeChuyenDoi INT,
	CONSTRAINT PK_TiLe PRIMARY KEY(sMaSP, sDVThuNhat, sDVThuHai)
)
GO

CREATE TABLE Account (
	sTaiKhoan VARCHAR(50) PRIMARY KEY,
	sMatKhau VARCHAR(50),
	sEmail VARCHAR(100)
)

INSERT INTO Account VALUES ('admin', 'admin', 'admin@gmail.com')
--Ràng buộc-------------------------------------------------------------------------------------------------------
ALTER TABLE tblKhachHang ADD CONSTRAINT PK_KhachHang PRIMARY KEY(sDienThoai)
ALTER TABLE tblSanPham ADD CONSTRAINT FK_SP_LH FOREIGN KEY(sLoaiHang) REFERENCES tblLoaiHang(sLoaiHang);
ALTER TABLE tblDonViTinh ADD CONSTRAINT FK_DVT_SP FOREIGN KEY(sMaSP) REFERENCES tblSanPham(sMaSP);
ALTER TABLE tblDonNhapHang ADD CONSTRAINT FK_DNH_NCC FOREIGN KEY(sMaNCC) REFERENCES tblNhaCungCap(sMaNCC);
ALTER TABLE tblDonNhapHang ADD CONSTRAINT FK_DNH_NV FOREIGN KEY(sMaNV) REFERENCES tblNhanVien(sMaNV);
ALTER TABLE tblChiTietDNH ADD CONSTRAINT PK_NhapHang PRIMARY KEY (sMaHDNH,sMaSP,sDonViTinh);
ALTER TABLE tblChiTietDNH ADD CONSTRAINT FK_CTDNH_SP FOREIGN KEY (sMaSP) REFERENCES tblSanPham(sMaSP);
ALTER TABLE tblChiTietDNH ADD CONSTRAINT FK_CTDNH_DNH FOREIGN KEY(sMaHDNH) REFERENCES tblDonNhapHang(sMaHDNH);
ALTER TABLE tblDonDatHang ADD CONSTRAINT FK_DDH_NV FOREIGN KEY(sMaNV) REFERENCES tblNhanVien(sMaNV);
ALTER TABLE tblDonDatHang ADD CONSTRAINT FK_DDH_KH FOREIGN KEY(sDienThoai) REFERENCES tblKhachHang(sDienThoai);
ALTER TABLE tblChiTietDDH ADD CONSTRAINT PK_DatHang PRIMARY KEY (sMaHDDH,sMaSP,sDonViTinh);
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

INSERT INTO tblLoaiHang VALUES
('LH001',N'Đồ ăn'),
('LH002',N'Đồ uống'),
('LH003',N'Đồ gia dụng'),
('LH004',N'Đồ điện tử')

INSERT INTO tblSanPham VALUES
('SP0001',N'Bim bim oishi cay','LH001',''),
('SP0002',N'7up vị chanh chai 390ml','LH002',''),
('SP0003',N'Pepsi chanh không calo 330ml','LH002',''),
('SP0004',N'Pepsi không calo 330ml','LH002','')

--INSERT INTO tblDonViTinh VALUES
--('SP0001',N'Gói',500,4500),
--('SP0001',N'Thùng',20,80000),
--('SP0002',N'Chai',250,6700),
--('SP0002',N'Lốc 6 Chai',200,37500),
--('SP0002',N'Thùng',10,142000)

INSERT INTO tblNhaCungCap VALUES
('NCC284',N'Công ty TNHH Việt Nam VIFOTEX'),
('NCC937',N'Tập đoàn Tân Hiệp Phát'),
('NCC837',N'Công ty TNHH Red Bull'),
('NCC874',N'Công ty TNHH Lavie'),
('NCC746',N'Công Ty Hanoifood '),
('NCC664',N'Công ty TNHH Thực phẩm Hữu Nghị'),
('NCC346',N'Công ty Cổ phần Zin Food'),
('NCC623',N'Công Ty TNHH Tập Đoàn Vinecook'),
('NCC236',N'Công Ty TNHH FDI Kim Anh'),
('NCC772',N'Công Ty TNHH Đông Dương Sài Gòn')

INSERT INTO tblNhanVien VALUES
('NV001',N'Phạm Thành Long',1,'2023-12-03',3500000),
('NV002',N'Nguyễn Hoàng Long',1,'2022-09-21',5600000),
('NV003',N'Phạm Quỳnh Như',0,'2023-12-13',4500000),
('NV004',N'Dương Thành An',1,'2024-01-11',5500000),
('NV005',N'Nguyễn Tuấn Anh',1,'2024-02-12',4500000),
('NV006',N'Dương Quỳnh Anh',0,'2021-10-24',7830000)

INSERT INTO tblKhachHang VALUES
('0982636273',N'Nguyễn Thành Công',1,N'Trung Dũng - An Lão',0.0)
--CREATE TRIGGER [Cập nhật tổng tiền nhập hàng]
--ON tblChiTietDNH
--AFTER INSERT
--AS
--BEGIN
--    -- Cập nhật tổng tiền hàng cho mỗi hóa đơn nhập hàng được thêm vào
--    UPDATE tblDonNhapHang
--    SET fTongTienHang = (SELECT SUM(fGiaTien * iSoLuong) 
--                         FROM inserted 
--                         WHERE tblDonNhapHang.sMaHDNH = inserted.sMaHDNH)
--    WHERE tblDonNhapHang.sMaHDNH IN (SELECT sMaHDNH FROM inserted)
--END;

ALTER PROC [Danh sách sản phẩm]
AS
BEGIN	
	SELECT sMaSP, sTenSP, sTenHang
	FROM tblSanPham AS sp
	JOIN tblLoaiHang AS lh ON sp.sLoaiHang = lh.sLoaiHang
END

EXEC [Danh sách sản phẩm]

--SELECT ctnh.sMaSP, sp.sTenSP, ctnh.fGiaTien
--FROM tblChiTietDNH ctnh
--INNER JOIN tblSanPham sp ON ctnh.sMaSP = sp.sMaSP
--INNER JOIN tblDonNhapHang dnh ON ctnh.sMaHDNH = dnh.sMaHDNH
--WHERE dvt.sTenDVT = N'Chai'
--AND dnh.dNgayNhapHang = (
--    SELECT MAX(dNgayNhapHang)
--    FROM tblDonNhapHang
--)

--SELECT ctnh.sMaSP, sp.sTenSP, ctnh.fGiaTien
--FROM tblSanPham sp
--INNER JOIN tblChiTietDNH ctnh ON sp.sMaSP = ctnh.sMaSP
--INNER JOIN tblDonNhapHang dnh ON ctnh.sMaHDNH = dnh.sMaHDNH
--INNER JOIN tblDonViTinh dvt ON sp.sMaSP = dvt.sMaSP
--WHERE dvt.sTenDVT = N'lốc 6 Chai'
--AND dnh.dNgayNhapHang = (
--    SELECT MAX(dNgayNhapHang)
--    FROM tblDonNhapHang
--)
--SELECT TOP 10 c.fGiaTien
--FROM tblChiTietDNH c
--JOIN tblDonNhapHang d ON c.sMaHDNH = d.sMaHDNH
--WHERE c.sMaSP = 'SP0001' 
--AND c.sDonViTinh = N'Thùng'
--ORDER BY d.dNgayNhapHang DESC

--SELECT TOP 10 c.sMaSP, c.fGiaTien
--FROM tblChiTietDNH c
--JOIN tblDonNhapHang d ON c.sMaHDNH = d.sMaHDNH
--WHERE c.sDonViTinh = N'Thùng'
--ORDER BY d.dNgayNhapHang DESC


SELECT sp.sMaSP, sp.sTenSP, dvt.sTenDVT, lh.sTenHang
FROM tblSanPham AS sp
JOIN tblLoaiHang AS lh ON sp.sLoaiHang = lh.sLoaiHang
JOIN tblDonViTinh AS dvt ON sp.sMaSP = dvt.sMaSP

CREATE PROC [Tạo hoá đơn]
	@mahd VARCHAR(30),
	@manv VARCHAR(30),
	@sdt VARCHAR(20),
	@hoten NVARCHAR(70),
	@gioitinh BIT,
	@diachi NVARCHAR(255)
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM tblKhachHang WHERE sDienThoai = @sdt)
		BEGIN
			INSERT INTO tblKhachHang VALUES (@sdt,@hoten,@gioitinh,@diachi,0.0)
		END
	INSERT INTO tblDonDatHang VALUES (@mahd,@manv,@sdt,GETDATE(),@diachi,0.0)
END

CREATE PROC [Thêm hoá đơn]
	@mahd VARCHAR(30),
	@masp VARCHAR(30),
	@soluong INT,
	@dvt NVARCHAR(50),
	@giatien FLOAT
AS
BEGIN
	INSERT INTO tblChiTietDDH VALUES
	(@mahd,@masp,@soluong,@dvt,@giatien)
	UPDATE tblDonDatHang
	SET fTongTienHang = fTongTienHang + @giatien
END

SELECT GETDATE() AS CurrentDateTime;

CREATE PROC [Giá tiền]
	@masp VARCHAR(30),
	@dvt NVARCHAR(50)
AS
BEGIN	
	SELECT * FROM tblDonViTinh WHERE sMaSP = @masp AND sTenDVT = @dvt
END

--EXEC [Giá tiền]
--	@masp = 'SP0001',
--	@dvt = N'Thùng'
--EXEC [Tạo hoá đơn]
--@mahd = 'HDDH8018',
--@manv = 'NV003',
--@sdt = '0983404598',
--@hoten = N'Phạm Tuấn Khang',
--@gioitinh = 1,
--@diachi = N'255 Định công, Hoàng mai'