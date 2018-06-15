create database QuanLyHocSinh
use QuanLyHocSinh

create table HOCSINH
(
	MaHS		int	identity(1, 1)	primary key,
	HoTen		nvarchar(50)		not null,		-- 'Nguyen Van A',...
	GioiTinh	nvarchar(3)			not null,		-- 'Nam', 'Nữ'
	NgaySinh	date								-- '21/12/1998',...
	DiaChi		nvarchar(100),						-- '10 Phạm Văn Đồng, ...'
	SoDT		varchar(25),						-- '0919191119'
	MaLop		int
);

alter table HOCSINH
	alter column NgaySinh date

create table LOP
(
	MaLop		int	identity(1, 1)	primary key,
	TenLop		nvarchar(20)		not null,		-- '10 Toán Tin', 11A1, 12/2,...
	SiSo		int					not null,		-- 30, 40, 45,...
	MaKhoi		int					not null
);

create table KHOI
(
	MaKhoi		int					primary key,
	TenKhoi		varchar(2)			not null,		-- '10', '11', '12',... 
	SoLop		int					not null		-- 8, 9, 10,...
);

create table HOCPHAN
(
	MaHP		int	identity(1, 1)	primary key,
	DiemTB		float				,				-- 8.2
	MaHS		int					not null,		
	MaMH		int					not null,
	MaHK		int					not null,
);

create table MONHOC
(
	MaMH		int identity(1, 1)	primary key,
	TenMH		nvarchar(20)		not null		-- 'Toán 10', 'Ngữ văn 11', 'Tin học 12',...
);

create table HOCKY
(
	MaHK		int identity(1, 1)	primary key,
	TenHK		nvarchar(20)		not null		-- 'Học kỳ 1 (2017-2018)',...
);

create table CHITIETDIEM
(
	MaCTD		int	identity(1, 1)	primary key,
	Diem		float				not null,		-- 8.5
	MaLKT		int					not null,
	MaHP		int					not null
);

create table LOAIKIEMTRA
(
	MaLKT		int identity(1, 1)	primary key,
	TenLKT		nvarchar(10)		not null		-- 'Miệng', '5 phút', '15 phút', '1 tiết', 'Học kỳ',...
);

create table THAMSO
(
	TenTS		varchar(10)			not null,
	TS1			int					not null,
	TS2			int,
	GhiChu		nvarchar(30)
);

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

	UPDATE LOP
		SET SiSo = SiSo + 1
		WHERE MaLop = @MaLop
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

CREATE PROCEDURE LayDuLieuLop
AS
BEGIN
	SELECT * FROM LOP
END
GO

CREATE PROCEDURE KiemTraLopHopLe
	@MaLop int
AS
BEGIN
	SELECT * FROM LOP WHERE MaLop = @MaLop;
END
GO

CREATE PROCEDURE LayDuLieuMonHoc
AS
BEGIN
	SELECT * FROM MONHOC
END
GO

CREATE PROCEDURE KiemTraMonHocHopLe
	@MaMH int
AS
BEGIN
	SELECT * FROM MONHOC WHERE MaMH = @MaMH;
END
GO

CREATE PROCEDURE LayDuLieuHocKy
AS
BEGIN
	SELECT * FROM HOCKY
END
GO

CREATE PROCEDURE KiemTraHocKyHopLe
	@MaHK int
AS
BEGIN
	SELECT * FROM HOCKY WHERE MaHK = @MaHK;
END
GO

CREATE PROCEDURE LayQuyDinhTuoi
	@TuoiMin int out,
	@TuoiMax int out
AS
BEGIN
	SELECT @TuoiMin = TS1, @TuoiMax = TS2 
		FROM THAMSO
		WHERE TenTS = 'Tuoi'
END
GO

CREATE PROCEDURE LuuQuyDinhTuoi
	@TuoiMin int,
	@TuoiMax int
AS
BEGIN
	UPDATE THAMSO
		SET TS1 = @TuoiMin, TS2 = @TuoiMax
		WHERE TenTS = 'Tuoi'
END
GO

CREATE PROCEDURE LayQuyDinhSiSoToiDa
	@SiSoToiDa int out
AS
BEGIN
	SELECT @SiSoToiDa = TS1 FROM THAMSO WHERE TenTS = 'SiSoToiDa'
END
GO

CREATE PROCEDURE LuuQuyDinhSiSoToiDa
	@SiSoToiDa int
AS
BEGIN
	UPDATE THAMSO
		SET TS1 = @SiSoToiDa
		WHERE TenTS = 'SiSoToiDa'
END
GO

CREATE PROCEDURE LayQuyDinhDiemDatMon
	@DiemDatMon float out
AS
BEGIN
	SELECT @DiemDatMon = TS1 FROM THAMSO WHERE TenTS = 'DiemDatMon'
END
GO

CREATE PROCEDURE LuuQuyDinhDiemDatMon
	@DiemDatMon float
AS
BEGIN
	UPDATE THAMSO
		SET TS1 = @DiemDatMon
		WHERE TenTS = 'DiemDatMon'
END
GO

CREATE PROCEDURE LayDuLieuMotLop
	@MaLop		int
AS
BEGIN
	SELECT * FROM LOP WHERE MaLop = @MaLop
END
GO

CREATE PROCEDURE LayDuLieuMotMonHoc
	@MaMH		int
AS
BEGIN
	SELECT * FROM MONHOC WHERE MaMH = @MaMH
END
GO

CREATE PROCEDURE SuaThongTinLop
	@MaLop		int,
	@TenLop		nvarchar(20),
	@SiSo		int,
	@MaKhoi		int
AS
BEGIN
	UPDATE LOP
		SET TenLop = @TenLop, SiSo = @SiSo, MaKhoi = @MaKhoi
		WHERE MaLop = @MaLop
END
GO

CREATE PROCEDURE SuaThongTinMonHoc
	@MaMH		int,
	@TenMH		nvarchar(20)
AS
BEGIN
	UPDATE MONHOC
		SET TenMH = @TenMH
		WHERE MaMH = @MaMH
END
GO

CREATE PROCEDURE LayDuLieuBaoCaoTongKetMon
	@MaMH		int,
	@MaHK		int
AS
BEGIN
	SELECT L.MaLop, L.TenLop, SiSo, ISNULL(HPHS.SoLuongDat, 0) AS 'SoLuongDat', SoLuongDat * 1.0 / SiSo AS 'TiLe'
	FROM LOP L
	LEFT JOIN (SELECT MaLop, COUNT(DiemTB) AS 'SoLuongDat'--HS.MaHS, HS.MaLop, HP.MaHP, HP.DiemTB
				FROM HOCSINH HS, HOCPHAN HP
				WHERE	HS.MaHS = HP.MaHS
						AND HP.MaMH = '1' AND HP.MaHK = '1'
						AND HP.DiemTB >= (SELECT TS1 FROM THAMSO WHERE TenTS = 'DiemDatMon')
				GROUP BY MaLop) AS HPHS 
	ON L.MaLop = HPHS.MaLop
END
GO

CREATE PROCEDURE LayDuLieuBaoCaoTongKetHocKy
	@MaHK		int
AS
BEGIN
	SELECT L.MaLop AS 'Mã lớp', L.TenLop AS 'Tên lớp', SiSo AS 'Sĩ số', ISNULL(HS.SoLuongDat, 0) AS 'Số lượng đạt', SoLuongDat * 1.0 / SiSo AS 'Tỉ lệ'
	FROM LOP L
	LEFT JOIN (SELECT HS.MaLop, COUNT(*) AS 'SoLuongDat'
					FROM HOCSINH HS, (SELECT DISTINCT MaHS
							FROM HOCPHAN HP
							WHERE	MaHK = @MaHK
									AND MaHS NOT IN (SELECT MaHS
										FROM HOCPHAN
										WHERE	MaHK = @MaHK
												AND DiemTB < (SELECT TS1 FROM THAMSO 
																	WHERE TenTS = 'DiemDatMon'))) AS HPHS
					WHERE HS.MaHS = HPHS.MaHS
					GROUP BY HS.MaLop) AS HS
	ON L.MaLop = HS.MaLop
END
GO

-- Báo cáo tổng kết môn
SELECT L.MaLop AS 'Mã lớp', L.TenLop AS 'Tên lớp', SiSo AS 'Sĩ số', ISNULL(HPHS.SoLuongDat, 0) AS 'Số lượng đạt', SoLuongDat * 1.0 / SiSo AS 'Tỉ lệ'
	FROM LOP L
	LEFT JOIN (SELECT MaLop, COUNT(DiemTB) AS 'SoLuongDat'--HS.MaHS, HS.MaLop, HP.MaHP, HP.DiemTB
				FROM HOCSINH HS, HOCPHAN HP
				WHERE	HS.MaHS = HP.MaHS
						AND HP.MaMH = '1' AND HP.MaHK = '1'
						AND HP.DiemTB >= (SELECT TS1 FROM THAMSO WHERE TenTS = 'DiemDatMon')
				GROUP BY MaLop) AS HPHS 
	ON L.MaLop = HPHS.MaLop

-- Báo cáo tổng kết học kỳ
SELECT L.MaLop AS 'Mã lớp', L.TenLop AS 'Tên lớp', SiSo AS 'Sĩ số', ISNULL(HS.SoLuongDat, 0) AS 'Số lượng đạt', SoLuongDat * 1.0 / SiSo AS 'Tỉ lệ'
	FROM LOP L
	LEFT JOIN (SELECT HS.MaLop, COUNT(*) AS 'SoLuongDat'
					FROM HOCSINH HS, (SELECT DISTINCT MaHS
							FROM HOCPHAN HP
							WHERE	MaHK = '1'
									AND MaHS NOT IN (SELECT MaHS
										FROM HOCPHAN
										WHERE	MaHK = '1'
												AND DiemTB < (SELECT TS1 FROM THAMSO 
																	WHERE TenTS = 'DiemDatMon'))) AS HPHS
					WHERE HS.MaHS = HPHS.MaHS
					GROUP BY HS.MaLop) AS HS
	ON L.MaLop = HS.MaLop