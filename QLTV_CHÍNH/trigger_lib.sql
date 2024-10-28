-- Cập nhật tình trạng sách
create trigger update_book_status
on ct_phieu_muon
after insert
as begin
declare @ngaythuctra date, @Ma_sach char(20);
select @Ma_sach = Ma_Sach  FROM inserted
select @ngaythuctra = Ngay_Thuc_Tra from PHIEU_MUON
   if @ngaythuctra is null
   begin
   update SACH
   set Tinh_Trang=N'Đã mượn'
   where Ma_Sach = @Ma_sach;
   end
   else 
   begin
   update SACH
   set Tinh_Trang=N'Có sẵn'
   where Ma_Sach = @Ma_sach;
   end
end;

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

--tạo ràng buộc kiểm tra giới hạn sách khi mượn
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
 
	if (@ma_kieu_muon = 'MV' and @soluongmuon > 3) or (@ma_kieu_muon = 'TP' and @soluongmuon > 2)
	begin
    	print N'Số lượng sách mượn vượt quá giới hạn.';
    	rollback transaction;
	end;
end;


-- Test
INSERT INTO KE_SACH VALUES
('KS001','Sách Việt văn')
INSERT INTO NXB VALUES
('NXB001',N'Nhà Xuất Bản Trẻ','info@nxbtre.com.vn')
INSERT INTO TAC_GIA VALUES
('TG001',N'Nguyễn Du','1766')
INSERT INTO THE_LOAI VALUES
('TL001',N'Báo')
INSERT INTO CHU_DE VALUES
('CD001',N'Thơ')
INSERT INTO KHOA_VIEN VALUES
('HTTTQL',N'Hệ thống thông tin quản lý')
INSERT INTO DAU_SACH VALUES
('DS001',N'Chí Phèo','200','TG001','TL001','NXB001','CD001','120000')
INSERT INTO SACH VALUES
--('S001',N'Có sẵn',N'DS001',N'KS001')
('S002',N'Đã mượn',N'DS001',N'KS001')
INSERT INTO LOP_CHUYEN_NGANH VALUES
('HTQL64','HỆ THỐNG THÔNG TIN QUẢN LÝ 64','HTTTQL')
insert into THU_THU values
('TT001','Đào Phương Hoa','0123487321','dphtt@gmail.com')
insert into KIEU_MUON values 
('MV','Mượn về'),
('TP','Tại phòng')
INSERT INTO DOC_GIA VALUES
('DG001','Nguyễn Văn An','HTQL64','HTTTQL','901234567','SV')
insert into PHIEU_MUON VALUES
('PM00002','DG001','MV','2024-10-16',null,'TT001')
--('PM00001','DG001','MV','2024-08-16','2024-08-31','TT001')
insert into CT_PHIEU_MUON values
('PM00002','S002',null,null),
('PM00002','S001',null,null)


select * from chu_de
select * from dau_sach
select * from ke_sach
select * from khoa_vien
select * from lop_chuyen_nganh
select * from kieu_muon
select * from nxb
select * from phieu_phat 
select * from ct_phieu_phat
select * from phieu_muon
select * from ct_phieu_muon
select * from sach
select * from doc_gia
select * from thu_thu

-- Danh mục độc giả
select d.ma_doc_gia, d.ten_doc_gia, l.ten_lop, k.ten_khoa_vien
from lop_chuyen_nganh l inner join khoa_vien k 
on l.ma_khoa_vien = k.ma_khoa_vien
inner join doc_gia d 
on d.ma_lop = l.ma_lop 


SELECT doc_gia.ma_doc_gia, doc_gia.ten_doc_gia, lop_chuyen_nganh.ten_lop, khoa_vien.ten_khoa_vien
FROM   lop_chuyen_nganh INNER JOIN
             khoa_vien ON lop_chuyen_nganh.ma_khoa_vien = khoa_vien.ma_khoa_vien INNER JOIN
             doc_gia ON lop_chuyen_nganh.ma_lop = doc_gia.ma_lop AND khoa_vien.ma_khoa_vien = doc_gia.ma_khoa_vien


