create database QLSV_DA
use QLSV_DA
create table SINHVIEN
(
	MaSoSinhVien char(10) primary key,
	HoTen nvarchar(50),
	NoiSinh nvarchar(50),
	SoDienThoai varchar(11),
)

select * from SINHVIEN