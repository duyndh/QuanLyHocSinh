create database QuanLyHocSinh
use QuanLyHocSinh

create table HOCSINH
(
	MaHS		int	identity(1, 1)	primary key,	-- 1, 2, 3,...
	HoTen		nvarchar(50)		not null,		-- 'Nguyen Van A',...
	GioiTinh	nvarchar(3)			not null,		-- 'Nam', 'Nữ'
	NgaySinh	smalldatetime,						-- '21/12/1998',...
	DiaChi		nvarchar(100),						-- '10 Phạm Văn Đồng, ...'
	SoDT		varchar(25),						-- '0919191119'
	MaLop		int
);

create table LOP
(
	MaLop		int	identity(1, 1)	primary key,	-- 1, 2, 3,...
	TenLop		nvarchar(20)		not null,		-- '10 Toán Tin', 11A1, 12/2,...
	SiSo		int					not null,		-- 30, 40, 45,...
	MaKhoi		int					not null
);

create table KHOI
(
	MaKhoi		int					primary key,	-- 10, 11, 12,...
	TenKhoi		varchar(2)			not null,		-- '10', '11', '12',... 
	SoLop		int					not null		-- 8, 9, 10,...
);

create table HOCPHAN
(
	MaHP		int	identity(1, 1)	primary key,	-- 1, 2, 3,...
	DiemTB		float				,				-- 8.2
	MaHS		int					not null,		
	MaMH		varchar(10)			not null,
	MaHK		int					not null,
);

create table MONHOC
(
	MaMH		varchar(10)			primary key,	-- 'TOAN10', 'VAN11', 'TIN12',...
	TenMH		nvarchar(20)		not null		-- 'Toán 10', 'Ngữ văn 11', 'Tin học 12',...
);

create table HOCKY
(
	MaHK		int identity(1, 1)	primary key,	-- 1, 2, 3,...
	TenHK		nvarchar(20)		not null		-- 'Học kỳ 1 (2017-2018)',...
);

create table CHITIETDIEM
(
	MaCTD		int	identity(1, 1)	primary key,	-- 1, 2, 3,...
	Diem		float				not null,		-- 8.5
	MaLKT		varchar(5)			not null,
	MaHP		int					not null
);

create table LOAIKIEMTRA
(
	MaLKT		varchar(5)			primary key,	-- 'M', '5p', '15P', '1T', 'HK',...
	TenLKT		nvarchar(10)		not null		-- 'Miệng', '5 phút', '15 phút', '1 tiết', 'Học kỳ',...
);

alter table HOCSINH
	add constraint FK_MaLop_HOCSINH_LOP 
	foreign key (MaLop) references LOP(MaLop);

alter table LOP
	add constraint FK_MaKhoi_LOP_KHOI
	foreign key (MaKhoi) references KHOI(MaKhoi);

alter table HOCPHAN
	add constraint FK_MaHS_HOCPHAN_HOCSINH
	foreign key (MaHS) references HOCSINH(MaHS);

alter table HOCPHAN
	add constraint FK_MaMH_HOCPHAN_MONHOC
	foreign key (MaMH) references MONHOC(MaMH);

alter table HOCPHAN
	add constraint FK_MaHK_HOCPHAN_HOCKY
	foreign key (MaHK) references HOCKY(MaHK);

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

CREATE PROCEDURE ThemHocSinh
	--@MaHS		int,	
	@HoTen		nvarchar(50),
	@GioiTinh	nvarchar(3),
	@NgaySinh	smalldatetime,
	@DiaChi		nvarchar(100),
	@SoDT		varchar(25),
	@MaLop		int
AS
BEGIN
	INSERT INTO HOCSINH (HoTen, GioiTinh, NgaySinh, DiaChi, SoDT, MaLop)
	VALUES(@HoTen, @GioiTinh, @NgaySinh, @DiaChi, @SoDT, @MaLop);
END
GO

CREATE PROCEDURE LayMaHocSinhMoi
	@ID int OUTPUT
AS
BEGIN
	SELECT @ID = MAX(MaHS) FROM HOCSINH
GO

CREATE PROCEDURE LayDuLieuKhoi
AS
BEGIN
	SELECT * FROM KHOI
END
GO

CREATE PROCEDURE LayDuLieuLopTuKhoi
	@MaKhoi int
AS
BEGIN
	SELECT * FROM LOP WHERE MaKhoi = @MaKhoi
END
GO

CREATE PROCEDURE KiemTraLopHopLe
	@MaLop int
AS
BEGIN
	SELECT * FROM LOP WHERE MaLop = @MaLop;
END
GO