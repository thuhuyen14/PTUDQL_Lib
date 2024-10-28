--tạo database qlthuvien
create database qltv_ptud
go
use qltv_ptud
go
-- bảng nxb
create table nxb (
ma_nxb  char(20) 	primary key,
ten_nxb nvarchar(50) not null,
email   char(50),
)

 --bảng thể loại
create table the_loai (
ma_tl char(20) primary key,
ten_tl nvarchar(50) not null,
)
 
-- bảng chủ đề
create table chu_de (
ma_chu_de  char(20) 	primary key ,
ten_chu_de nvarchar(50) not null,
)
 
-- bảng kệ sách
create table ke_sach(
ma_ke  char(20) 	primary key ,
ten_ke nvarchar(50) not null,
)

-- bảng tác giả
create table tac_gia(
ma_tac_gia  char(20) 	primary key ,
ten_tac_gia nvarchar(50) not null default N'Chưa rõ',
nam_sinh int default N'Chưa rõ',
) 

-- bảng đầu sách
create table dau_sach(
ma_dau_sach  char(20) primary key ,
ten_dau_sach nvarchar(80) not null,
so_trang      	int,
ma_tac_gia  	char(20) foreign key references tac_gia(ma_tac_gia),
ma_tl    	char(20) foreign key references the_loai(ma_tl),
ma_nxb   	char(20) foreign key references nxb(ma_nxb),
ma_chu_de	char(20) foreign key references chu_de (ma_chu_de),
gia_bia  	money default 0,
)
--
	


 
-- bảng sách
create table sach (
ma_sach   	char(10) primary key ,
tinh_trang nvarchar(20)  check (tinh_trang in(N'Có sẵn', N'Mất', N'Đã mượn')) not null,
ma_dau_sach   char(20) foreign key references dau_sach(ma_dau_sach)	not null,
 ma_ke   	char(20) foreign key references ke_sach (ma_ke) not null,
)
 
-- bảng khoa viện
create table khoa_vien(
ma_khoa_vien  char(20) 	primary key ,
ten_khoa_vien nvarchar(50) not null,
)
 
-- bảng lớp chuyên ngành
create table lop_chuyen_nganh (
ma_lop  char(15) 	primary key ,
ten_lop nvarchar(50) not null,
ma_khoa_vien char(20) foreign key references khoa_vien (ma_khoa_vien)	not null,
)
 
-- bảng độc giả
create table doc_gia (
ma_doc_gia   char(20) primary key not null,
ten_doc_gia 	nvarchar(80) not null,
ma_lop   	char(15) foreign key references lop_chuyen_nganh (ma_lop),
sdt      	char(20),
chuc_vu  	char(2)  check (chuc_vu in(N'SV', N'GV')) not null,
)
 
-- bảng thủ thư
create table thu_thu (
ma_thu_thu  char(20) 	primary key ,
ten_thu_thu nvarchar(50) not null,
sdt     	char(20),
email nvarchar(50),
)
 
-- bảng kiểu mượn
create table kieu_muon (
ma_kieu_muon  char(2) primary key check (ma_kieu_muon in (N'MV', N'TP')),
ten_kieu_muon nvarchar(20) not null,
)
 
-- bảng phiếu mượn sách
create table phieu_muon (
ma_phieu_muon char(20) primary key not null,
ma_doc_gia	char(20) foreign key references doc_gia(ma_doc_gia) not null,
ma_kieu_muon  char(2) not null foreign key references kieu_muon (ma_kieu_muon),
ngay_muon 	date not null default getdate() ,
ngay_hen_tra as (
case
    	when ma_kieu_muon =N'MV' then dateadd (day,7,ngay_muon)
when ma_kieu_muon =N'TP' then ngay_muon
end
),
ngay_thuc_tra date,
constraint check_ngthuctra check (ngay_thuc_tra >= ngay_muon),
ma_thu_thu	char(20) foreign key references thu_thu(ma_thu_thu) not null,
)

-- bảng chi tiết phiếu mượn
create table ct_phieu_muon (
ma_phieu_muon char(20) not null foreign key (ma_phieu_muon) references phieu_muon(ma_phieu_muon),
ma_sach   	char(10) not null foreign key (ma_sach) references sach (ma_sach),
so_luong int,
constraint pk_ctphmt primary key(ma_phieu_muon,ma_sach)
)
 
--bảng vi phạm
create table vi_pham(
ma_vi_pham 	char(20) primary key not null,
ten_vi_pham	nvarchar (50) not null,
phat nvarchar(120) not null,
)
 
--bảng phiếu phạt
create table phieu_phat (
ma_phieu_phat char(20) primary key not null,
ma_phieu_muon char(20) foreign key references phieu_muon(ma_phieu_muon) not null,
ma_thu_thu	char(20) foreign key references thu_thu (ma_thu_thu) not null,
ngay_phat 	date not null,
)

-- bảng chi tiết phiếu phạt
create table ct_phieu_phat (
ma_phieu_phat char (20) foreign key references phieu_phat(ma_phieu_phat) not null,
ma_vi_pham	char(20) foreign key references vi_pham(ma_vi_pham) not null,
ma_sach char(10) foreign key references sach (ma_sach) not null,
nop_phat money,
mo_ta nvarchar(120),
)
 
 --------------
 create table account ( 
	username nvarchar (50) not null primary key,
	displayname nvarchar(50) not null default N'TV_KTQD', 
	password nvarchar (50) not null default 0
)
go

CREATE PROC USP_Login
@username nvarchar (100), @password nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.account WHERE username = @username AND password = @password
END 
GO


 ----------------
select* from account

--tạo ràng buộc độc giả không được mượn khi chưa trả sách
create trigger check_docgiatrasachchua
on phieu_muon
after insert
as
begin
declare @ngaytra_gannhat date, @ma_doc_gia char(20);
select @ma_doc_gia = ma_doc_gia from inserted
 
	select @ngaytra_gannhat = max(ngay_thuc_tra)
	from phieu_muon
	where ma_doc_gia = @ma_doc_gia;
	if @ngaytra_gannhat is null
begin
    	print N'Độc giả chưa trả sách';
    	rollback transaction;
end;
end;
 
---tạo ràng buộc kiểm tra giới hạn sách khi mượn
create trigger check_gioihansachmuon
on ct_phieu_muon
after insert, update
as
begin
	declare @ma_phieu_muon char(10), @ma_kieu_muon char(2), @soluongmuon int;
 
	select @ma_phieu_muon = ma_phieu_muon from inserted;
 
	select @ma_kieu_muon = ma_kieu_muon from phieu_muon where ma_phieu_muon = @ma_phieu_muon;
 
	select @soluongmuon = count(ma_sach)
	from ct_phieu_muon
	where ma_phieu_muon = @ma_phieu_muon;
 
	if (@ma_kieu_muon = N'MV' and @soluongmuon > 3) or (@ma_kieu_muon = N'TP' and @soluongmuon > 2)
	begin
    	print N'Số lượng sách mượn vượt quá giới hạn.';
    	rollback transaction;
	end;
end;


----
select * from dau_sach, tac_gia, sach, the_loai, nxb, chu_de 
where dau_sach.ma_tac_gia=tac_gia.ma_tac_gia 
and dau_sach.ma_dau_sach = sach.ma_dau_sach 
and the_loai.ma_tl=dau_sach.ma_tl 
and nxb.ma_nxb = dau_sach.ma_nxb
and chu_de.ma_chu_de = dau_sach.ma_chu_de
order by dau_sach.ma_dau_sach
----
-- Xóa bảng chi tiết phiếu phạt trước
drop table if exists ct_phieu_phat;

-- Xóa bảng phiếu phạt
drop table if exists phieu_phat;

-- Xóa bảng chi tiết phiếu mượn trước
drop table if exists ct_phieu_muon;

-- Xóa bảng phiếu mượn
drop table if exists phieu_muon;

-- Xóa bảng vi phạm
drop table if exists vi_pham;

-- Xóa bảng kiểu mượn
drop table if exists kieu_muon;

-- Xóa bảng sách
drop table if exists sach;

-- Xóa bảng đầu sách
drop table if exists dau_sach;

-- Xóa bảng kệ sách
drop table if exists ke_sach;

-- Xóa bảng thủ thư
drop table if exists thu_thu;

-- Xóa bảng độc giả
drop table if exists doc_gia;

-- Xóa bảng lớp chuyên ngành
drop table if exists lop_chuyen_nganh;

-- Xóa bảng khoa viện
drop table if exists khoa_vien;

-- Xóa bảng tác giả
drop table if exists tac_gia;

-- Xóa bảng chủ đề
drop table if exists chu_de;

-- Xóa bảng thể loại
drop table if exists the_loai;

-- Xóa bảng nhà xuất bản
drop table if exists nxb;

-- Xóa bảng account
drop table if exists account;

-- Xóa trigger nếu cần (nếu tồn tại)
drop trigger if exists check_docgiatrasachchua;
drop trigger if exists check_gioihansachmuon;
