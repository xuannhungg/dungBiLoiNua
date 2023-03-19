use project_LTWD;
CREATE TABLE CongDan (
 hoTen varchar(100),
 ngayThangNamSinh varchar(255),
 gioiTinh varchar(100),
 cmnd varchar(100) PRIMARY KEY,
 danToc varchar(255),
 tinhTrangHonNhan varchar(100),
 noiDangKiKhaiSinh varchar(100),
 queQuan varchar(255),
 noiThuongTru varchar(100),
 trinhDoHocVan varchar(255),
 ngheNghiep varchar(100),
 luong nvarchar(20)
);
INSERT INTO CongDan (hoTen, ngayThangNamSinh, gioiTinh,cmnd,danToc,tinhTrangHonNhan,noiDangKiKhaiSinh,queQuan,noiThuongTru,trinhDoHocVan,ngheNghiep, luong)
VALUES ('nva', '25/12/2003', 'nam','1800456','kinh','chua ket hon','nghe an','nghe an','nghe an','dai hoc','sinh vien', '0');
INSERT INTO CongDan (hoTen, ngayThangNamSinh, gioiTinh,cmnd,danToc,tinhTrangHonNhan,noiDangKiKhaiSinh,queQuan,noiThuongTru,trinhDoHocVan,ngheNghiep, luong)
VALUES ('nva1', '25/12/2003', 'nam','1800457','kinh','chua ket hon','nghe an','nghe an','nghe an','dai hoc','sinh vien', '0');
INSERT INTO CongDan (hoTen, ngayThangNamSinh, gioiTinh,cmnd,danToc,tinhTrangHonNhan,noiDangKiKhaiSinh,queQuan,noiThuongTru,trinhDoHocVan,ngheNghiep, luong)
VALUES ('nva2', '25/12/2003', 'nam','1800458','kinh','chua ket hon','nghe an','nghe an','nghe an','dai hoc','sinh vien', '0');

select * from CongDan


