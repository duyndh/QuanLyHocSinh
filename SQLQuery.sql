create database QuanLyHocSinh
use QuanLyHocSinh

create table HOCSINH
(
	MaHS		int				identity(1, 1) primary key,
	Hoten		nvarchar(50)	not null,
	GioiTinh	bit				not null,
	NgaySinh	smalldatetime,
	DiaChi		nvarchar(50),
	SoDT		varchar(20),
	MaLop		varchar(20)		not null
);
alter table HOCSINH
	add constraint FK_MaLop_HOCSINH_LOP 
	foreign key (MaLop) references LOP(MaLop);

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

create table LOAIKIEMTRA
(
	MaLKT		varchar(20)		primary key,
	TenLKT		nvarchar(20)	not null
);

create table HOCPHAN
(
	MaHP		int				identity(1, 1) primary key,
	DiemTB		float			not null,
	MaHS		int				not null,
	MaMH		varchar(20)		not null,
	MaHK		varchar(20)		not null,
);
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

