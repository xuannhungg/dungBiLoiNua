CREATE TABLE SoHoKhau(
	maKV varchar (100) primary key,
	xaPhuong varchar (100),
	quanHuyen varchar (100),
	tinhTP varchar (100),
	CMND varchar (100) FOREIGN KEY REFERENCES CongDan (cmnd),
	maSoHoKhau varchar (200),
	hoTenChuHo varchar (100),
	diaChi varchar (100),
	ngayLap varchar (100)
);
INSERT INTO SoHoKhau(maKV,xaPhuong,quanHuyen,tinhTP,CMND,maSoHoKhau,hoTenChuHo,diaChi,ngayLap)
Values('01','Thanh Phu','CoDO','CanTho','1800456','123','Nguyen van a','Ap 3','1993/2/1')
INSERT INTO SoHoKhau(maKV,xaPhuong,quanHuyen,tinhTP,CMND,maSoHoKhau,hoTenChuHo,diaChi,ngayLap)
Values('02','abc','def','DongNai','1800457','345','Nguyen van b','Ap 1','1988/12/1')
INSERT INTO SoHoKhau(maKV,xaPhuong,quanHuyen,tinhTP,CMND,maSoHoKhau,hoTenChuHo,diaChi,ngayLap)
Values('03','faf','CoDO','TPHCM','1800458','567','Nguyen van c','Ap 4','1983/2/1')
select * from SoHoKhau

