﻿USE MASTER
GO

CREATE DATABASE QLKS_TKPM1
go

use QLKS_TKPM1
CREATE TABLE LOAIPHONG(
 MaLoaiPhong nvarchar(12) PRIMARY KEY NOT NULL,
 TenLoaiPhong nvarchar(12),
 SoLuong int,
 HoTroDV bit
)

CREATE TABLE PHONG(
 MaPhong nvarchar(12) PRIMARY KEY NOT NULL,
 TenPhong nvarchar(12),
 LoaiPhong nvarchar(12),
 GiaThue int,
 SoNguoi int,
 TrangThai nvarchar(12),
 TinhTrang bit
)

CREATE TABLE PHIEUTHUEPHONG (
 MaPhieuThue nvarchar(12) PRIMARY KEY NOT NULL,
 MaKH nvarchar(12),
 MaPhongThue nvarchar(12),
 NgayBD date,
 NgayKT date,
 TongTien int
)

CREATE TABLE HOADON (
 MaHD nvarchar(12) PRIMARY KEY NOT NULL,
 MaNV nvarchar(12),
 PhieuThuePhong nvarchar(12),
 SoTien int,
 NgayThanhToan date
)

CREATE TABLE DANGKYDV (
 MaPhieuPhong nvarchar(12) NOT NULL,
 MaDichVu nvarchar (12) NOT NULL,
 NgayDangKy date,
 SoLuong int,
 PRIMARY KEY(MaPhieuPhong,MaDichVu)
)

CREATE TABLE DICHVU(
 MaDV nvarchar(12) PRIMARY KEY NOT NULL,
 TenDV nvarchar(12),
 DonGia int,
 SoNguoiSD int
)

CREATE TABLE SANPHAM(
 MaSP nvarchar(12) PRIMARY KEY NOT NULL,
 TenSP nvarchar(12),
 DonGiaSP int
)

CREATE TABLE LICHSUMUASP (
 MaPhieuPhong nvarchar(12) NOT NULL,
 MaSanPham nvarchar(12) NOT NULL,
 SoLuong int,
 NgayMua date
 PRIMARY KEY(MaPhieuPhong,MaSanPham)
)

CREATE TABLE ACCOUNT (
 MaTK nvarchar(12) primary key, 
 LoaiTK nvarchar(12) not null,
 MaNV nvarchar(12) not null,
 Usrname nvarchar(20) not null,
 Pwd nvarchar(20) not null
)

CREATE TABLE NHANVIEN (
 MaNV Nvarchar(12) primary key, 
 TenNV Nvarchar(20) not null,
 CMND Nvarchar(20) not null,
 DiaChi Nvarchar(50) not null,
)

CREATE TABLE KHACHHANG(
  MaKH Nvarchar(12) primary key,
  TenKH Nvarchar(20) not null,
  NgaySinh date not null,
  CMND Nvarchar(20) not null,
  DiaChi Nvarchar(50) not null
)

CREATE TABLE LICHSUDUNGDV (
 MaPhieuThue nvarchar(12),
 MaDV nvarchar(12),
 ThoiGianSuDung date,
 CaSuDung time
 PRIMARY KEY (MaKH,MaPhieuThue,MaDV)
)

ALTER TABLE PHONG ADD CONSTRAINT fk_phong_loaiphong FOREIGN KEY (LoaiPhong) REFERENCES LOAIPHONG(MaLoaiPhong)

ALTER TABLE LICHSUMUASP ADD CONSTRAINT fk_MuaSP_SanPham FOREIGN KEY (MaSanPham) REFERENCES SANPHAM(MaSP)
ALTER TABLE LICHSUMUASP ADD CONSTRAINT fk_MuaSP_ThuePhong FOREIGN KEY (MaPhieuPhong) REFERENCES PhIEUTHUEPHONG(MaPhieuThue)

ALTER TABLE PHIEUTHUEPHONG ADD CONSTRAINT fk_ThuePhong_phong FOREIGN KEY (MaPhongThue) REFERENCES PHONG(MaPhong)
ALTER TABLE PHIEUTHUEPHONG ADD CONSTRAINT fk_ThuePhong_KhachHang FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH)

ALTER TABLE DANGKYDV ADD CONSTRAINT fk_DKDV_ThuePhong FOREIGN KEY (MaPhieuPhong) REFERENCES PHIEUTHUEPHONG(MaPhieuThue)
ALTER TABLE DANGKYDV ADD CONSTRAINT fk_DKDV_DV FOREIGN KEY (MaDichVu) REFERENCES DICHVU(MaDV)

ALTER TABLE LICHSUDUNGDV ADD CONSTRAINT fk_LichSDDV_DKDV FOREIGN KEY (MaPhieuThue, MaDV) REFERENCES DANGKYDV(MaPhieuPhong,MaDichVu)

ALTER TABLE ACCOUNT ADD CONSTRAINT fk_account_nhanvien FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)

ALTER TABLE HOADON ADD CONSTRAINT fk_hoadon_nhanvien FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
ALTER TABLE HOADON ADD CONSTRAINT fk_hoadon_thuephong FOREIGN KEY (PhieuThuePhong) REFERENCES PHIEUTHUEPHONG(MaPhieuThue)

INSERT INTO NHANVIEN( MaNV,TenNV,CMND,DiaChi) VALUES (N'NV01', N'Gam',N'18203',N'hcm')
INSERT INTO NHANVIEN( MaNV,TenNV,CMND,DiaChi) VALUES (N'TK02', N'SE',N'18202',N'hcm')

INSERT INTO ACCOUNT ( MaTK,LoaiTK,MaNV,Usrname,Pwd) VALUES (N'TK01', N'AD',N'NV01',N'admin',N'admin')
INSERT INTO ACCOUNT ( MaTK,LoaiTK,MaNV,Usrname,Pwd) VALUES (N'TK02', N'LT',N'NV02',N'duy',N'123')

INSERT INTO LOAIPHONG( MaLoaiPhong,TenLoaiPhong,SoLuong,HoTroDV) VALUES (N'LP01',N'Phòng Đơn',30,0)
INSERT INTO LOAIPHONG( MaLoaiPhong,TenLoaiPhong,SoLuong,HoTroDV) VALUES (N'LP02',N'Phòng Đôi',20,0)
INSERT INTO LOAIPHONG( MaLoaiPhong,TenLoaiPhong,SoLuong,HoTroDV) VALUES (N'LP03',N'Phòng VIP',30,1)

INSERT INTO PHONG(MaPhong,TenPhong,LoaiPhong,GiaThue,SoNguoi,TrangThai,TinhTrang) VALUES (N'P101',N'Phòng 101',N'LP01',200000,3,N'Bảo trì',1)
INSERT INTO PHONG(MaPhong,TenPhong,LoaiPhong,GiaThue,SoNguoi,TrangThai,TinhTrang) VALUES (N'P102',N'Phòng 102',N'LP02',300000,3,N'Chưa dọn',1)
INSERT INTO PHONG(MaPhong,TenPhong,LoaiPhong,GiaThue,SoNguoi,TrangThai,TinhTrang) VALUES (N'P103',N'Phòng 103',N'LP03',2000000,6,N'Đã dọn',0)


create procedure sp_Login
(
 @userid nvarchar(20),
 @pwd nvarchar(20)
)
as 
begin
	select * from ACCOUNT where Usrname=@userid and Pwd=@pwd
end