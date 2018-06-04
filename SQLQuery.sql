create database QuanLyHocSinh
use QuanLyHocSinh

create table HOCSINH
(
	MaHS		int	identity(1, 1) primary key,
	HoTen		nvarchar(50)		not null,
	GioiTinh	nvarchar(4)			not null,
	NgaySinh	smalldatetime,
	DiaChi		nvarchar(50),
	SoDT		varchar(20),
	MaLop		varchar(20)	
);

alter table HOCSINH
	add constraint FK_MaLop_HOCSINH_LOP 
	foreign key (MaLop) references LOP(MaLop);

--ALTER TABLE HOCPHAN
--DROP CONSTRAINT FK_MaHS_HOCPHAN_HOCSINH;   

--alter table HOCSINH
--alter column MaHS identity(1, 1);

--drop table HOCSINH

create table LOP
(
	MaLop		varchar(20)		primary key,
	TenLop		nvarchar(20)	not null,
	SiSo		tinyint			not null,
	MaKhoi		varchar(20)		not null
);
alter table LOP
	add constraint FK_MaKhoi_LOP_KHOI
	foreign key (MaKhoi) references KHOI(MaKhoi);

create table KHOI
(
	MaKhoi		varchar(20)		primary key,
	TenKhoi		nvarchar(20)	not null,
	SoLop		tinyint			not null
);

create table MONHOC
(
	MaMH		varchar(20)		primary key,
	TenMH		nvarchar(20)	not null
);

create table HOCKY
(
	MaHK		varchar(20)		primary key,
	TenHK		nvarchar(20)	not null
);
--alter table HOCKY alter column TenHK nvarchar(40) not null

create table LOAIKIEMTRA
(
	MaLKT		varchar(20)		primary key,
	TenLKT		nvarchar(20)	not null
);

create table HOCPHAN
(
	MaHP		int				identity(1, 1) primary key,
	DiemTB		float			,
	MaHS		int				not null,
	MaMH		varchar(20)		not null,
	MaHK		varchar(20)		not null,
);
--alter table HOCPHAN
--alter column MaHS int not null

alter table HOCPHAN
	add constraint FK_MaHS_HOCPHAN_HOCSINH
	foreign key (MaHS) references HOCSINH(MaHS);
alter table HOCPHAN
	add constraint FK_MaMH_HOCPHAN_MONHOC
	foreign key (MaMH) references MONHOC(MaMH);
alter table HOCPHAN
	add constraint FK_MaHK_HOCPHAN_HOCKY
	foreign key (MaHK) references HOCKY(MaHK);

create table CHITIETDIEM
(
	MaCTD		int				identity(1, 1) primary key,
	Diem		float			not null,
	MaLKT		varchar(20)		not null,
	MaHP		int				not null
);
alter table CHITIETDIEM
	add constraint FK_MaLKT_CHITIETDIEM_LOAIKIEMTRA
	foreign key (MaLKT) references LOAIKIEMTRA(MaLKT);
alter table CHITIETDIEM
	add constraint FK_MaHP_CHITIETDIEM_HOCPHAN
	foreign key (MaHP) references HOCPHAN(MaHP);


--------------------------------------------------------------------
--Add data

SET DATEFORMAT dmy;

INSERT INTO HOCSINH (MaHS, Hoten, GioiTinh, NgaySinh, DiaChi, SoDT) VALUES
(1, N'Lê Bảo Cường',		'Nam',	'01-02-2011', N'Bình Định',	'0988153183'),
(1, N'Nguyễn Thị Lệ Thu',	'Nữ',	'04-04-2010', N'Bình Định',	'01692631290'),
(3, N'Đặng Hồng Đông',		'Nam',	'04-07-2017', N'Gia lai',	'0919183350'),
(4, N'Tuấn',				'Nam',	'01-01-2010', N'Gia lai',	'0913817931'),
(5, N'Đặng Tuấn Cường',		'Nam',	'04-06-2017', N'Việt Nam',	'01689129331')

--delete from HOCSINH

--INSERT INTO HOCKY (MaHK, TenHK) VALUES
--('HK120172018', N'Học kỳ 1 Năm học 2017-2018'),
--('HK220172018', N'Học kỳ 2 Năm học 2017-2018')


CREATE PROCEDURE ThemHS
	@MaHS		int = null,
	@Hoten		nvarchar(50),
	@GioiTinh	nvarchar(4),
	@NgaySinh	smalldatetime,
	@DiaChi		nvarchar(50),
	@SoDT		varchar(20),
	@MaLop		varchar(20)
AS
BEGIN
	INSERT INTO HOCSINH (HoTen, GioiTinh, NgaySinh, DiaChi, SoDT)
	VALUES(@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SoDT);
END
GO