﻿/*======================Tạo DATABASE======================*/

USE MASTER
GO
CREATE DATABASE QL_NhaSach
USE QL_NhaSach
GO

/*======================Tạo TABLE======================*/

CREATE TABLE DANGNHAP
(
	TenDangNhap nvarchar(20),
	MatKhau char(20),
	Quyen char(20)

	Constraint PK_DANGNHAP primary key(TenDangNhap)
)

CREATE TABLE NHACUNGCAP
(
	STT int unique,
	MaNhaCungCap char(10),
	TenNhaCungCap nvarchar(50) unique,
	DiaChi nvarchar(30),
	DienThoai char(15),
	Email char(30),	
	Anh nchar(200)

	Constraint PK_NHACUNGCAP primary key(MaNhaCungCap)
)

CREATE TABLE NHAXUATBAN
(
	STT int unique,
	MaNhaXuatBan char(10),
	TenNXB nvarchar(100) unique,
	DiaChi nvarchar(30),
	DienThoai char(15),
	Email char(30),

	Constraint PK_NHAXUATBAN primary key(MaNhaXuatBan)
)

CREATE TABLE LOAISACH
(
	STT int unique,
	MaLoai char(10),
	TenLoai nvarchar(30) unique,

	Constraint PK_LOAISACH primary key(MaLoai)
)

CREATE TABLE SACH
(
	STT int unique,
	MaSach char(10),
	TenSach nvarchar(100),
	MaLoai char(10),
	TacGia nvarchar(100),
	GiaNhap int,
	GiaBan int,
	SL int,
	NamXuatBan char(4),
	NhaCungCap char(10),
	MaNhaXuatBan char(10),
	Anh nchar(200)

	Constraint PK_SACH primary key(MaSach),
	Constraint FK_SACH_LOAISACH foreign key(MaLoai) references LOAISACH(MaLoai),
	Constraint FK_SACH_NHACUNGCAP foreign key(NhaCungCap) references NHACUNGCAP(MaNhaCungCap),
	Constraint FK_SACH_NHAXUATBAN foreign key(MaNhaXuatBan) references NHAXUATBAN(MaNhaXuatBan)
)

CREATE TABLE KHACHHANG
(
	STT int unique,
	MaKH char(10),
	TenKH nvarchar(30),
	NgaySinh date,
	GT nvarchar(10),
	DiaChi nvarchar(30),
	SĐT char(12),

	Constraint PK_KHACHHANG primary key(MaKH)
)

CREATE TABLE NHANVIEN
(
	TenDangNhap nvarchar(20),
	STT int unique,
	MaNV char(10),
	TenNV nvarchar(30),
	NgaySinh date,
	GT nvarchar(10),
	SĐT char(10),
	DiaChi nvarchar(30),
	ChucVu nvarchar(20),

	Constraint PK_NHANVIEN primary key(MaNV),
	Constraint FK_NHANVIEN_DANGNHAP foreign key(TenDangNhap) references DANGNHAP(TenDangNhap)
)

CREATE TABLE PHIEUNHAP
(
	MaPN int unique,
	MaNV char(10),
	MaNhaCungCap char(10),
	NgayNhap date,
	TongTien int

	Constraint PK_PHIEUNHAP primary key(MaPN),
	Constraint FK_PHIEUNHAP foreign key(MaNV) references NHANVIEN(MaNV),
	Constraint FK_PHIEUNHAP_NHACUNGCAP foreign key(MaNhaCungCap) references NHACUNGCAP(MaNhaCungCap)
)

CREATE TABLE CHITIETPHIEUNHAP
(
	MaPN int unique,
	MaSach char(10),
	DonGia int,
	SL int,
	ThanhTien int,

	Constraint PK_CHITIETPHIEUNHAP primary key(MaPN, MaSach),
	Constraint FK_CHITIETPHIEUNHAP_PHIEUNHAP foreign key(MaPN) references PHIEUNHAP(MaPN),
	Constraint FK_CHITIETPHIEUNHAP_SACH foreign key(MaSach) references SACH(MaSach)

)

CREATE TABLE HOADON
(
	MaHD char(10),
	MaKH char(10),
	MaNV char(10),
	NgayBan date,
	TongTien int,

	Constraint PK_HOADON primary key(MaHD),
	Constraint FK_HOADON_KHACHHANG foreign key(MaKH) references KHACHHANG(MaKH),
	Constraint FK_HOADON_NHANVIEN foreign key(MaNV) references NHANVIEN(MaNV)
)

CREATE TABLE CHITIETHOADON
(
	MaHD char(10),
	MaSach char(10),
	DonGia int,
	SL int,

	Constraint PK_CHITIETHOADON primary key(MaHD, MaSach),
	Constraint FK_CHITIETHOADON_SACH foreign key(MaSach) references SACH(MaSach),
	Constraint FK_CHITIETHOADON_HOADON foreign key(MaHD) references HOADON(MaHD)
)

/*======================Nhập liệu======================*/
 
SET DATEFORMAT DMY

INSERT INTO DANGNHAP VALUES ('admin', '10101999', 'admin')
INSERT INTO DANGNHAP VALUES ('nhanvien', '123456', 'staff')
INSERT INTO DANGNHAP VALUES ('kiemsach', '123456', 'bookstaff')

INSERT INTO NHANVIEN(TenDangNhap, STT,MaNV, TenNV, NgaySinh, GT, SĐT, DiaChi, ChucVu) 
VALUES ('nhanvien', 1,'NV001', N'Nguyễn Huy Hoàng', '12/02/1999', N'Nam', '0121782556', N'Tây Ninh', 'Thu ngân'),
('kiemsach', 2, 'NV02', N'Ngô Duy Thái', '09/11/1999', N'Nam','121782655', N'Hà Nội', N'Kiểm sách'),
('nhanvien', 3, 'NV03', N'Nguyễn Văn Thiện', '12/05/1996', N'Nam','078299065', N'TP.HCM', N'Thu ngân'),
('nhanvien', 4, 'NV04', N'Lê Bảo Ngọc', '28/05/1997', N'Nữ', '0965888911', N'TP.HCM', N'Thu ngân'),
('nhanvien', 5, 'NV05', N'Võ Hoàng Phương Anh', '12/07/2001', N'Nữ', '0121782999', N'TP.HCM', N'Thu Ngân')
INSERT INTO NHANVIEN( STT,MaNV, TenNV, NgaySinh, GT, SĐT, DiaChi, ChucVu) VALUES
(6, 'NV06', N'Phùng Thanh Độ', '11/09/1989', N'Nam', '0997787792', N'Cao Bằng', N'Bảo vệ')

INSERT INTO NHACUNGCAP VALUES (1,'NCC01', N'Công ty Dịch vụ & Văn hóa MinhLong', N'Hà Nội', '0121782561', 'minhlongbook@gmail.com', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\ncc1.jpg')
INSERT INTO NHACUNGCAP VALUES (2,'NCC02', N'Công ty TNHH TM & DV Văn Hóa Định Tị', N'TP.HCM', '078962355', 'dinhtibooks@gmail.com', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\ncc2.jpg')
INSERT INTO NHACUNGCAP VALUES (3,'NCC03', N'Công ty TNHH Sách PandaBooks', N'TP.HCM', '0942755998', 'pandabooks@gmail.com', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\ncc3.jpg')
INSERT INTO NHACUNGCAP VALUES (4,'NCC04', N'Công ty Cổ Phần Văn Hóa Huy Hoàng JSC', N'TP.HCM', '0946855195', 'huyhoangjsc@gmail.com', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\ncc4.jpg')
INSERT INTO NHACUNGCAP VALUES (5,'NCC05', N'Nhà Xuất Bản Hoa Học Trò ', N'Hà Nội', '0985412228', 'hoahoctrotphcm@gmail.com', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\ncc5.jpg')
INSERT INTO NHACUNGCAP VALUES (6,'NCC06', N'Nhà Xuất Bản Kim Đồng', N'Hà Nội', '0797839005', 'kimdonghn@gmail.com', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\ncc6.jpg')
INSERT INTO NHACUNGCAP VALUES (7,'NCC07', N'Công ty văn hóa & truyền thông AZ', N'TP.HCM', '09798782959', 'minhlongbook@gmail.com', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\ncc7.jpg')
INSERT INTO NHACUNGCAP VALUES (8,'NCC08', N'Công ty TNHH Văn Hóa & Truyền Thông Lệ Chi', N'Hà Nội', '0962855558', 'minhlongbook@gmail.com', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\ncc8.jpg')

INSERT INTO NHAXUATBAN VALUES (1, 'NXB01', N'Nhà Xuất Bản Dân Trí', N'TP.HCM', '0121782656', 'nxbdt@gmail.com')
INSERT INTO NHAXUATBAN VALUES (2, 'NXB02', N'Nhà Xuất Bản Phụ Nữ', N'TP.HCM', '0962757855', 'nxbpnnxbdt@gmail.com')
INSERT INTO NHAXUATBAN VALUES (3, 'NXB03', N'Nhà Xuất Bản Lao Động', N'Hà Nội', '0949865318', 'nxbldnxbdt@gmail.com')
INSERT INTO NHAXUATBAN VALUES (4, 'NXB04', N'Nhà Xuất Bản Thông Tin Và Truyền Thông', N'Hà Nội', '0585413355', 'ttvattnxbdt@gmail.com')
INSERT INTO NHAXUATBAN VALUES (5, 'NXB05', N'Nhà Xuất Bản Văn Hóa - Văn Nghệ', N'Hà Nội', '062378264', 'vhvnhnnxbdt@gmail.com')
INSERT INTO NHAXUATBAN VALUES (6, 'NXB06', N'Nhà Xuất Bản Thời Đại', N'TP.HCM', '0325869158', 'nxbtdnxbdt@gmail.com')
INSERT INTO NHAXUATBAN VALUES (7, 'NXB07', N'Nhà Xuất Bản Lao Động', N'TP.HCM', '0979825696', 'nxbldnxbdt@gmail.com')
INSERT INTO NHAXUATBAN VALUES (8, 'NXB08', N'Nhà Xuất Bản Tổng hợp TP.HCM', N'TP.HCM', '0356785623', 'nxbthnxbdt@gmail.com')

INSERT INTO LOAISACH VALUES (1,'TN', N'Thiếu nhi')
INSERT INTO LOAISACH VALUES (2,'TTT', N'Truyện, tiểu thuyết')
INSERT INTO LOAISACH VALUES (3,'CTPL', N'Chính trị - pháp luật')
INSERT INTO LOAISACH VALUES (4,'GT', N'Giáo trình')
INSERT INTO LOAISACH VALUES (5,'KHCNKT', N'Khoa học công nghệ - Kinh tế')
INSERT INTO LOAISACH VALUES (6,'VHNT', N'Văn học nghệ thuật')
INSERT INTO LOAISACH VALUES (7,'TLTLTG', N'Tâm lý, tâm linh, tôn giáo')
INSERT INTO LOAISACH VALUES (8,'VHXHLS', N'Văn hóa xã hội - Lịch sử ')
INSERT INTO LOAISACH VALUES (9,'YHTD', N'Y học - Thực dưỡng')

--Theo thứ tự: STT, mã sách, tên sách, mã loại, tác giả, giá bán, số lượng, năm xuất bản, nhà xuất bản, file ảnh
--Sách thiếu nhi: 
INSERT INTO SACH VALUES (1,'SH01', N'Từ Điển Nhí Nhố Của Metti Và Otti', 'TN', N'Urushi Kagijou', 53000, 52, '2019', N'Nhà Xuất Bản Dân Trí', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH01.jpg')
INSERT INTO SACH VALUES (2,'SH02', N'Bà Ơi, Cháu Rất Muốn Gặp Bà!', 'TN', N'Gomi Taro', 33000, 100, '2019', N'Nhà Xuất Bản Phụ Nữ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH02.jpg')
INSERT INTO SACH VALUES (3,'SH03', N'Đêm Đom Đóm - It’s Firefly Night', 'TN', N'Dianne Ochiltree, Betsy Snyder', 33000, 70, '2019', N'Nhà Xuất Bản Phụ Nữ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH03.jpg')
INSERT INTO SACH VALUES (4,'SH04', N'Ánh Mặt Trời Lấp Lóa Ngón Tay', 'TN', N'Gabriele Clima', 45000, 32, '2019', N'Nhà Xuất Bản Kim Đồng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH04.jpg')
INSERT INTO SACH VALUES (5,'SH05', N'Kĩ Năng Vàng Cho Học Sinh Tiểu Học - Thói Quen Tốt Trong Sinh Hoạt', 'TN', N'Ngôi nhà Ốc Sên - Nguyễn Thanh Vân', 80000, 70, '2019', N'Nhà Xuất Bản Kim Đồng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH05.jpg')
INSERT INTO SACH VALUES (6,'SH06', N'Thằng Tơ Tưởng', 'TN', N'Nguyễn Công Kiệt', 45000, 42, '2019', N'Nhà Xuất Bản Kim Đồng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH06.jpg')
INSERT INTO SACH VALUES (7,'SH07', N'Tranh Truyện Dân Gian Việt Nam - Nàng Tiên Hổ', 'TN', N'Huy Tuấn, Lê Thanh Nga', 15000, 100, '2019', N'Nhà Xuất Bản Kim Đồng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH07.jpg')
INSERT INTO SACH VALUES (8,'SH08', N'Không Sao Đâu Con! - Thất Bại Là Chuyện Nhỏ', 'TN', N'Shen Nuan - Yang Shou Ning', 30000, 10, '2019', N'Nhà Xuất Bản Kim Đồng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH08.jpg')
INSERT INTO SACH VALUES (9,'SH09', N'Tủ Sách Văn Học Thiếu Nhi - Chuyện Kể Ở Lớp Cây Me', 'TN', N'Nguyễn Thị Kim Hòa', 58000, 100, '2019', N'Nhà Xuất Bản Kim Đồng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH09.jpg')
INSERT INTO SACH VALUES (10,'SH10', N'Hoàng Tử Bé', 'TN', N'Antoine de Saint – Exupéry', 78000, 95, '2019', N'Nhà Xuất Bản Dân Trí', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH10.jpg')

--Truyện, tiểu thuyết:
INSERT INTO SACH VALUES (11,'SH11', N'Đến Lượt Em Tỏ Tình', 'TTT', N'Dương Thùy', 71000, 50, '2019', N'Nhà Xuất Bản Lao Động', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH11.jpg')
INSERT INTO SACH VALUES (12,'SH12', N'Trà Hoa', 'TTT', N'Furin', 79000, 60, '2019', N'Nhà Xuất Bản Thế Giới', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH12.jpg')
INSERT INTO SACH VALUES (13,'SH13', N'Phương Bắc, Phương Nam - Tình Yêu Không Biên Giới', 'TTT', N'Giác', 54000, 52, '2019', N'Nhà Xuất Bản Kim Đồng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH13.jpg')
INSERT INTO SACH VALUES (14,'SH14', N'Những Nẻo Đường Yêu', 'TTT', N'Hoàng Yến Anh', 64000, 70, '2019', N'Nhà Xuất Bản Thanh Hóa', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH14.jpg')
INSERT INTO SACH VALUES (15,'SH15', N'Berlin Và Những Mùa Ru Ký Ức', 'TTT', N'Hoàng Yến Anh', 77000, 52, '2019', N'Nhà Xuất Bản Thanh Hóa', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH15.jpg')
INSERT INTO SACH VALUES (16,'SH16', N'Làm Bạn Với Bầu Trời', 'TTT', N'Nguyễn Nhật Ánh', 88000, 100, '2019', N'NXB Trẻ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH16.jpg')
INSERT INTO SACH VALUES (17,'SH17', N'Biết Khi Nào Mới Gặp Lại Nhau', 'TTT', N'Hoàng Khánh Duy', 67000, 30, '2019', N'Nhà Xuất Bản Lao Động', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH17.jpg')
INSERT INTO SACH VALUES (18,'SH18', N'Ngày Tôi Đưa Tang Mình', 'TTT', N'Nguyễn Thị Kim Ngân', 40000, 100, '2019', N'Nhà Xuất Bản Tổng hợp TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH18.jpg')
INSERT INTO SACH VALUES (19,'SH19', N'Ngày Hôm Qua… Đã Từng, My Angel', 'TTT', N'Nguyễn Mon', 96000, 40, '2019', N'Nhà Xuất Bản Dân Trí', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH19.jpg')
INSERT INTO SACH VALUES (20,'SH20', N'Vì Ta Còn Chờ Nhau', 'TTT', N'Lê Hữu Nam', 98000, 52, '2019', N'Nhà Xuất Bản Văn Hóa - Văn Nghệ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH20.jpg')

--Chính trị, pháp luật:
INSERT INTO SACH VALUES (21,'SH21', N'21 Bài Học Cho Thế Kỷ 21', 'CTPL', N'Yuval Noah Harari', 167000, 100, '2019', N'Nhà Xuất Bản Thế Giới', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH21.jpg')
INSERT INTO SACH VALUES (22,'SH22', N'Trí Tuệ Siêu Việt Của Người Do Thái', 'CTPL', N'Hòa Thổ', 108000, 60, '2019', N'Nhà Xuất Bản Thanh Hóa', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH22.jpg')
INSERT INTO SACH VALUES (23,'SH23', N'Nước Mỹ Dưới Thời Donald Trump', 'CTPL', N'David Clay Johnston', 143000, 52, '2019', N'Nhà Xuất Bản Thông Tin Và Truyền Thông', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH23.jpg')
INSERT INTO SACH VALUES (24,'SH24', N'Biển Việt Nam Và Các Mối Giao Thương Biển', 'CTPL', N'Nguyễn Văn Kim', 171000, 100, '2019', N'Nhà Xuất Bản Đại Học Quốc Gia Hà Nội', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH24.jpg')
INSERT INTO SACH VALUES (25,'SH25', N'Địa Chính Trị', 'CTPL', N'Klaus Dodds', 72000, 100, '2019', N'Nhà Xuất Bản Tri Thức', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH25.jpg')
INSERT INTO SACH VALUES (26,'SH26', N'Xây dựng đất nước phồn vinh theo di chúc của Chủ tịch Hồ Chí Minh', 'CTPL', N'Bùi Đình Phong', 72000, 52, '2006', N'Nhà Xuất Bản Tổng hợp TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH26.jpg')
INSERT INTO SACH VALUES (27,'SH27', N'Thế Giới 100 Năm Sau', 'CTPL', N'George Friedman', 50000, 80, '2013', N'Nhà Xuất Bản Thời Đại', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH27.jpg')
INSERT INTO SACH VALUES (28,'SH28', N'Võ Nguyên Giáp - Hào Khí Trăm Năm', 'CTPL', N'Trần Thái Bình', 128000, 100, '2017', N'NXB Trẻ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH28.jpg')
INSERT INTO SACH VALUES (29,'SH29', N'Nhà Trắng - Những Chuyện Chưa Kể', 'CTPL', N'Kate Andersen Brower', 100000, 50, '2018', N'NXB Trẻ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH29.jpg')
INSERT INTO SACH VALUES (30,'SH30', N'Đường Đến Nhà Trắng 2016', 'CTPL', N'Roger Stone', 167000, 124, '2017', N'Nhà Xuất Bản Thế Giới', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH30.jpg')

--Giáo trình:
INSERT INTO SACH VALUES (31,'SH31', N'Kế Toán Tài Chính (Tái Bản 2018)', 'GT', N'Nhiều Tác Giả', 249000, 100, '2018', N'NXB Tài Chính', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH31.jpg')
INSERT INTO SACH VALUES (32,'SH32', N'Tái Thiết Kế Doanh Nghiệp', 'GT', N'Nguyễn Văn Dung', 30000, 100, '2015', N'NXB Giao thông vận tải', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH32.jpg')
INSERT INTO SACH VALUES (33,'SH33', N'Hệ Thống Văn Bản Pháp Luật Về Thuế Thu Nhập Doanh Nghiệp - Tái bản 03/2007', 'GT', N'Nhiều Tác Giả', 66000, 52, '2006', N'NXB Tài Chính', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH33.jpg')
INSERT INTO SACH VALUES (34,'SH34', N'Quản Trị Học - Bài Tập Và Nghiên Cứu Tình Huống', 'GT', N'Nhiều Tác Giả', 71000, 100, '2015', N'NXB Lao động', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH34.jpg')
INSERT INTO SACH VALUES (35,'SH35', N'Giáo Trình Lập & Thẩm Định Dự Án Đầu Tư (Tái Bản Lần 1)', 'GT', N'Đỗ Phú Trần Tình', 75000, 70, '2015', N'NXB Giao thông vận tải', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH35.jpg')
INSERT INTO SACH VALUES (36,'SH36', N'Pháp Luật Đại Cương (Tái Bản 6/2009)', 'GT', N'Lê Học Lâm', 100000, 100, '2009', N'NXB Giao thông vận tải', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH36.jpg')
INSERT INTO SACH VALUES (37,'SH37', N'Đầu Tư Quốc Tế', 'GT', N'Lê Quang Huy', 85000, 100, '20015', N'NXB Kinh Tế TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH37.jpg')
INSERT INTO SACH VALUES (38,'SH38', N'Phân Tích Hoạt Động Trong Kinh Doanh', 'GT', N'Nhiều Tác Giả', 64000, 100, '2015', N'NXB Kinh Tế TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH38.jpg')
INSERT INTO SACH VALUES (39,'SH39', N'Nghề Giám Đốc Kinh Doanh', 'GT', N'Lê Quốc Sử', 22000, 100, '2015', N'NXB Tổng Hợp TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH39.jpg')
INSERT INTO SACH VALUES (40,'SH40', N'Thương Mại Điện Tử - Cẩm Nang (Tập 1)', 'GT', N'Nhiều Tác Giả', 140000, 100, '2015', N'NXB Kinh Tế TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH40.jpg')


--Khoa học công nghệ, kinh tế:
INSERT INTO SACH VALUES (41,'SH41', N'Thời Đại Công Nghệ 4.0', 'KHCNKT', N'Nhiều Tác Giả', 74000, 70, '2019', N'Nhà Xuất Bản Hồng Đức', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH41.jpg')
INSERT INTO SACH VALUES (42,'SH42', N'Nền Tảng Công Nghệ - Hướng Đi Mới Cho Doanh Nghiệp Trong Thời Đại 4.0', 'KHCNKT', N'TAnthony Stevens, Louis Straussui', 119000, 85, '2019', N'Nhà Xuất Bản Công Thương', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH42.jpg')
INSERT INTO SACH VALUES (43,'SH43', N'Cách Mạng Công Nghệ 4.0', 'KHCNKT', N'Nhiều Tác Giả', 36000, 100, '2019', N'Nhà Xuất Bản Thanh Niên', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH43.jpg')
INSERT INTO SACH VALUES (44,'SH44', N'Cuộc Chiến Công Nghệ Số', 'KHCNKT', N'Charles Arthur', 114000, 80, '2019', N'Nhà Xuất Bản Dân Trí', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH44.jpg')
INSERT INTO SACH VALUES (45,'SH45', N'Ngân hàng số: Từ đổi mới đến cách mạng', 'KHCNKT', N' PGS. TS Hoàng Công Gia Khánh', 142000, 100, '2019', N'Nhà Xuất Bản Đại Học Quốc Gia TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH45.jpg')
INSERT INTO SACH VALUES (46,'SH46', N'Mặt Trái Của Công Nghệ', 'KHCNKT', N'Peter Townsend', 173000, 70, '2019', N'Nhà Xuất Bản Chính Trị Quốc Gia Sự Thật', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH46.jpg')
INSERT INTO SACH VALUES (47,'SH47', N'12 Xu Hướng Công Nghệ Trong Thời Đại 4.0', 'KHCNKT', N'Kevin Kelly', 135000, 82, '2019', N'Nhà Xuất Bản Đại Học Kinh Tế Quốc Dân', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH47.jpg')
INSERT INTO SACH VALUES (48,'SH48', N'Bộ sách Khởi Nghiệp Công Nghệ', 'KHCNKT', N'Chưa cập nhật', 485000, 100, '2019', N'Chưa cập nhật', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH48.jpg')
INSERT INTO SACH VALUES (49,'SH49', N'Kinh Tế Trong Cuộc Cách Mạng Công Nghệ 4.0', 'KHCNKT', N'Saifedean Ammous', 151000, 102, '2019', N'Nhà Xuất Bản Đại Học Kinh Tế Quốc Dân', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH49.jpg')
INSERT INTO SACH VALUES (50,'SH50', N'Stem Quanh Em – Công Nghệ Siêu Thông Minh', 'KHCNKT', N'Catherine Bruzzone, Vicky Barker', 47000, 122, '2017', N'Nhà Xuất Bản Dân Trí', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH50.jpg')


--Văn học nghệ thuật:
INSERT INTO SACH VALUES (51,'SH51', N'Đêm Gành Hào Nghe Điệu Hoài Lang - Trăm Khúc Tình Ca', 'VHNT', N'Vũ Đức Sao Biển', 48000, 27, '2019', N'NXB Trẻ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH51.jpg')
INSERT INTO SACH VALUES (52,'SH52', N'Phố Cổ Hà Nội - Kí Họa & Hồi Ức (Hanois Old Quarter - Sketches And Memories)', 'VHNT', N'Nhiều Tác Giả', 315000, 20, '2019', N'Nhà Xuất Bản Kim Đồng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH52.jpg')
INSERT INTO SACH VALUES (53,'SH53', N'Học Đàn Piano', 'VHNT', N'Brad Hill', 84000, 52, '2019', N'Nhà Xuất Bản Hồng Đức', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH53.jpg')
INSERT INTO SACH VALUES (54,'SH54', N'Học Vẽ Tranh Màu Nước', 'VHNT', N'David Sanmiguel', 92000, 50, '2019', N'Nhà Xuất Bản Thanh Hóa', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH54.jpg')
INSERT INTO SACH VALUES (55,'SH55', N'Ức Trai Di Tập Dư Địa Chí', 'VHNT', N'Nguyễn Trãi, Phan Duy Tiếp dịch, Hà Văn Tấn hiệu đính và chú thích', 81000, 12, '2019', N'Nhà Xuất Bản Đại Học Quốc Gia TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH55.jpg')
INSERT INTO SACH VALUES (56,'SH56', N'Ngày Người Thương Một Người Thương Khác', 'VHNT', N'Trí', 73000, 30, '2019', N' Nhà Xuất Bản Hội Nhà Văn', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH56.jpg')
INSERT INTO SACH VALUES (57,'SH57', N'Lên Đồi Hái Sim', 'VHNT', N'Thảo Nguyên', 55000, 27, '2019', N'Nhà Xuất Bản Đà Nẵng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH57.jpg')
INSERT INTO SACH VALUES (58,'SH58', N'Biết Ơn Mình', 'VHNT', N' Đỗ Hồng Ngọc', 72000, 30, '2019', N'Nhà Xuất Bản Văn Hóa - Văn Nghệ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH58.jpg')
INSERT INTO SACH VALUES (59,'SH59', N'Mình Gọi Nhau Là Cưng', 'VHNT', N'Trúc Thiên', 68000, 24, '2019', N'Nhà Xuất Bản Văn Hóa - Văn Nghệ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH59.jpg')
INSERT INTO SACH VALUES (60,'SH60', N'Người Khách Kì Dị', 'VHNT', N'Ma Văn Kháng', 68000, 10, '2019', N'Nhà Xuất Bản Phụ Nữ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH60.jpg')


--Tâm lý, tâm linh, tôn giáo:
INSERT INTO SACH VALUES (61,'SH61', N'Chữa Lành Bằng Tâm Thức', 'TLTLTG', N'Newton Kondaveti', 90000, 30, '2019', N'Nhà Xuất Bản Hồng Đức', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH61.jpg')
INSERT INTO SACH VALUES (62,'SH62', N'Trở Về Từ Xứ Tuyết - Tái Bản', 'TLTLTG', N'Nguyên Phong', 74000, 25, '2019', N'Nhà Xuất Bản Tổng hợp TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH62.jpg')
INSERT INTO SACH VALUES (63,'SH63', N'Anh Ngữ Phật Học Giản Dị', 'TLTLTG', N'Nguyễn Mạnh Thảo', 56000, 30, '2019', N'Nhà Xuất Bản Tổng hợp TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH63.jpg')
INSERT INTO SACH VALUES (64,'SH64', N'Bên Rặng Tuyết Sơn (Tái Bản)', 'TLTLTG', N'Swami Amar Jyoti', 70000, 52, '2019', N'Nhà Xuất Bản Hồng Đức', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH64.jpg')
INSERT INTO SACH VALUES (65,'SH65', N'Quyển Sách Của Cuộc Đời', 'TLTLTG', N'Krishnamurti', 126000, 30, '2019', N'Nhà Xuất Bản Hồng Đức', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH65.jpg')
INSERT INTO SACH VALUES (66,'SH66', N'Hoa Sen Trên Tuyết', 'TLTLTG', N'Nguyên Phong', 62000, 50, '2019', N'Nhà Xuất Bản Tổng hợp TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH66.jpg')
INSERT INTO SACH VALUES (67,'SH67', N'Sen Nở Trời Phương Ngoại', 'TLTLTG', N'Thích Nhất Hạnh', 95000, 40, '2019', N'Nhà Xuất Bản Văn Hóa - Văn Nghệ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH67.jpg')
INSERT INTO SACH VALUES (68,'SH68', N'Pháp Hoa Kinh Thông Nghĩa (Bộ 3 tập)', 'TLTLTG', N'Đại sư Đức Thanh', 270000, 100, '2019', N'Nhà Xuất Bản Hồng Đức', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH68.jpg')
INSERT INTO SACH VALUES (69,'SH69', N'Suối Nguồn Trí Tuệ', 'TLTLTG', N'Huy Sanh', 91000, 10, '2019', N'Nhà Xuất Bản Thanh Niên', 'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH69.jpg')
INSERT INTO SACH VALUES (70,'SH70', N'Ngã - Pháp', 'TLTLTG', N'Hồng Dương Nguyễn Văn Hai', 80000, 20, '2019', N'Nhà Xuất Bản Hồng Đức', 'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH70.jpg')


--Văn hóa xã hội, lịch sử:
INSERT INTO SACH VALUES (71,'SH71', N'Combo Các Thầy Giáo Việt Nam Xưa & Những Thầy Giáo Nổi Tiếng Trong Lịch Sử', 'VHXHLS', N'Phạm Khang, Nguyễn Ngọc Thanh', 148000, 42, '2019', N'Nhà Xuất Bản Thanh Niên', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH71.jpg')
INSERT INTO SACH VALUES (72,'SH72', N'Phong Trào Minh Tân Ở Nam Kỳ Đầu Thế Kỷ XX', 'VHXHLS', N'Phạm Phúc Vĩnh', 80000, 30, '2019', N'Nhà Xuất Bản Hồng Đức', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH72.jpg')
INSERT INTO SACH VALUES (73,'SH73', N'Kinh Tế Và Xã Hội Việt Nam Dưới Các Vua Triều Nguyễn', 'VHXHLS', N'Nguyễn Thế Anh', 115000, 60, '2019', N' Nhà Xuất Bản Hội Nhà Văn', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH73.jpg')
INSERT INTO SACH VALUES (74,'SH74', N'Xứ Ủy Nam Bộ Và Trung Ương Cục Miền Nam (1945-1954)', 'VHXHLS', N'Đoàn Thị Hương', 73000, 100, '2019', N'Nhà Xuất Bản Tổng hợp TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH74.jpg')
INSERT INTO SACH VALUES (75,'SH75', N'Việt Nam Sử Lược (Bản Đặc Biệt - Ấn Bản Kỉ Niệm 60 Năm NXB Kim Đồng)', 'VHXHLS', N'Trần Trọng Kim', 179000, 150, '2019', N'Nhà Xuất Bản Kim Đồng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH75.jpg')
INSERT INTO SACH VALUES (76,'SH76', N'Nhật Bản Qua Lăng Kính Người Việt Đầu Thế Kỷ XX', 'VHXHLS', N'Nguyễn Mạnh Sơn', 183000, 50, '2019', N'Nhà Xuất Bản Lao Động', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH76.jpg')
INSERT INTO SACH VALUES (77,'SH77', N'Vùng đất Nam bộ dưới triều Minh Mạng (1820-1841)', 'VHXHLS', N'Choi Byung Wook, Nguyễn Thừa Hỷ và Lê Nguyễn hiệu đính', 143000, 50, '2019', N'Nhà Xuất Bản Hà Nội', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH77.jpg')
INSERT INTO SACH VALUES (78,'SH78', N'Các Triều Đại Việt Nam', 'VHXHLS', N'Quỳnh Cư, Đỗ Đức Hùng', 78000, 30, '2019', N'Nhà Xuất Bản Thanh Niên', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH78.jpg')
INSERT INTO SACH VALUES (79,'SH79', N'Lễ Thành Hầu Nguyễn Hữu Cảnh Từ Danh Tướng Đến Tôn Thần', 'VHXHLS', N'Trần Hoàng Vũ', 76000, 70, '2019', N'Nhà Xuất Bản Tổng hợp TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH79.jpg')
INSERT INTO SACH VALUES (80,'SH80', N'Sài Gòn Chợ Lớn đời sống xã hội và chính trị qua tư liệu báo chí (1925-1945)','VHXHLS', N'Nguyễn Đức Hiệp', 144000, 18, '2019', N' Nhà Xuất Bản Tổng hợp TP.HCM', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH80.jpg')


--Y học, thực dưỡng:
INSERT INTO SACH VALUES (81,'SH81', N'AI - Bước Tiến Đột Phá Trong Chăm Sóc Sức Khỏe', 'YHTD', N'Eric Topol', 199000, 50, '2019', N'Nhà Xuất Bản Dân Trí', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH81.jpg')
INSERT INTO SACH VALUES (82,'SH82', N'Thiền: Nghệ Thuật Nhập Định', 'YHTD', N'Osho', 108000, 20, '2019', N'Nhà Xuất Bản Hồng Đức', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH82.jpg')
INSERT INTO SACH VALUES (83,'SH83', N'Combo Dinh Dưỡng Xanh - Thần dược xanh', 'YHTD', N'Ryu Seung-SunVictoria Boutenko', 208000, 27, '2019', N'Nhà Xuất Bản Dân Trí', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH83.jpg')
INSERT INTO SACH VALUES (84,'SH84', N'Thiền Tông Phú', 'YHTD', N'Thiền Sinh Hải Thuần', 128000, 30, '2019', N'Nhà Xuất Bản Đà Nẵng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH84.jpg')
INSERT INTO SACH VALUES (85,'SH85', N'Y Khoa Và Cuộc Sống', 'YHTD', N'BS Phạm Thị Minh Dung', 100000, 100, '2019', N'Nhà Xuất Bản Đà Nẵng', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH85.jpg')
INSERT INTO SACH VALUES (86,'SH86', N'Ung Thư Không Phải Là Bệnh, Mà Là Cơ Chế Chữa Lành', 'YHTD', N'Andreas Moritz', 135000, 10, '2019', N'Nhà Xuất Bản Thế Giới', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH86.jpg')
INSERT INTO SACH VALUES (87,'SH87', N'Bệnh Tim Không Đáng Lo', 'YHTD', N'Nicolas Aubineau', 101000, 37, '2019', N'Nhà Xuất Bản Thế Giới', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH87.jpg')
INSERT INTO SACH VALUES (88,'SH88', N'Thực Dưỡng Tiện Dụng Cho Người Bận Rộn', 'YHTD', N'Minh Thanh, Thanh Nguyên', 84000, 50, '2019', N'Nhà Xuất Bản Phụ Nữ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH88.jpg')
INSERT INTO SACH VALUES (89,'SH89', N'Bác Sĩ Tốt Nhất Là Chính Mình Tập 9: Cao Huyết Áp - Sát Thủ Thầm Lặng', 'YHTD', N'Nhiều Tác Giả', 40000, 100, '2019', N'NXB Trẻ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH89.jpg')
INSERT INTO SACH VALUES (90,'SH90', N'Phòng Và Chữa Bệnh Loãng Xương', 'YHTD', N'PGS.TS Bác Sĩ Đoàn Văn Đệ', 41000, 70, '2018', N'Nhà Xuất Bản Phụ Nữ', N'C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\img\SH90.jpg')

INSERT INTO KHACHHANG VALUES (1, 'KH01', N'Nguyễn Huy Hoàng', '12/12/1999', N'Nam', N'Tây Ninh','0964412851'),
                             (2, 'KH02', N'Nguyễn Hoàng Huy', '09/10/1999', N'Nam', N'TP.HCM','0964412852'),
							 (3, 'KH03', N'Nguyễn Tuấn Anh', '05/10/1996', N'Nam', N'Thái Bình','0964412853'),
							 (4, 'KH04', N'Lương Xuân Trường', '20/10/1995', N'Nam', N'Tuyên Quang','0964412854'),
							 (5, 'KH05', N'Nguyễn Công Phượng', '03/05/1997', N'Nam', N'Nghệ An','0964412855'),
							 (6, 'KH06', N'Nguyễn Phong Hồng Duy', '06/10/1994', N'Nam', N'Bình Phước','0964412856'),
							 (7, 'KH07', N'Nguyễn Văn Toàn', '07/11/1993', N'Nam', N'Hải Dương','0964412857'),
							 (8, 'KH08', N'Nguyễn Tiến Linh', '01/12/1998', N'Nam', N'Bình Dương','0964412858'),
							 (9, 'KH09', N'Đỗ Duy Mạnh', '01/01/1997', N'Nam', N'Hà Nội','0964412859'),
							 (10, 'KH10', N'Đỗ Hùng Dũng', '11/11/1996', N'Nam', N'Hà Nội','0964412850'),
							 (11, 'KH11', N'Nguyễn Anh Đức', '05/05/1999', N'Nam', N'Bình Dương','0964412812'),
							 (12, 'KH12', N'Võ Thị Ngọc Trâm', '01/02/2000', N'Nữ', N'Cà Mau','0964412811'),
							 (13, 'KH13', N'Đinh Thị Hồng Ngọc', '01/03/1999', N'Nữ', N'Phú Yên','0964412813'),
							 (14, 'KH14', N'Nguyễn Thị Nở', '04/11/2001', N'Nữ', N'Bạc Liêu','0964412814'),
							 (15, 'KH15', N'Nguyễn Phương Như Ý', '08/08/1998', N'Nữ', N'An Giang','0964412815'),
							 (16, 'KH16', N'Nguyễn Thị Mai Vy', '18/04/1999', N'Nữ', N'Hậu Giang','0964412816'),
							 (17, 'KH17', N'Phạm Tuyết Huỳnh', '08/10/1999', N'Nữ', N'Tây Ninh','0964412817'),
							 (18, 'KH18', N'Cao Thị Huỳnh Như', '24/04/1999', N'Nữ', N'Tây Ninh','0964412818'),
							 (19, 'KH19', N'Lê Minh Thư', '18/10/2000', N'Nữ', N'Tây Ninh','0964412819'),
							 (20, 'KH20', N'Cao Thị Anh Thư', '25/10/2002', N'Nữ', N'Tây Ninh','0964412810'),
							 (21, 'KH21', N'Ngô Tiến Thanh', '01/01/1999', N'Nam', N'Kiên Giang','0964412821'),
							 (22, 'KH22', N'Trần Văn Cường', '09/03/1996', N'Nam', N'An Giang','0964412822'),
							 (23, 'KH23', N'Đỗ Duy Khánh', '02/02/1997', N'Nam', N'Hải Phòng','0964412823'),
							 (24, 'KH24', N'Phan Công Minh', '09/04/1997', N'Nam', N'Đà Nẵng','0964412824'),
							 (25, 'KH25', N'Lê Quang Duy', '03/05/1997', N'Nam', N'Cần Thơ','0964412825'),
							 (26, 'KH26', N'Phan Tấn Trung', '09/05/1994', N'Nam', N'Đồng Tháp','0964412826'),
							 (27, 'KH27', N'Lê Công Vinh', '09/09/1993', N'Nam', N'TP.HCM','0964412827'),
							 (28, 'KH28', N'Phan Văn Tài Em', '12/10/1997', N'Nam', N'Vĩnh Long','0964412828'),
							 (29, 'KH29', N'Trần Minh Thùy', '09/01/1999', N'Nữ', N'Tiền Giang','0964412829'),
							 (30, 'KH30', N'Nguyễn Như Hoàng', '11/06/1999', N'Nam', N'Long An','0964412831'),
							 (31, 'KH31', N'Ngân Văn Đại', '06/10/1999', N'Nam', N'Vũng Tàu','0964412832'),
							 (32, 'KH32', N'Nguyễn Hoàng Phúc', '09/10/1999', N'Nam', N'Bình Thuận','09644128533'),
							 (33, 'KH33', N'Nguyễn Văn Tùng', '01/11/1999', N'Nam', N'Đồng Nai','0964412834'),
							 (34, 'KH34', N'Đào Trần Thanh Đông', '11/12/1995', N'Nam', N'Lâm Đồng','0964412835'),
							 (35, 'KH35', N'Nguyễn Quốc Nhiên', '02/03/1999', N'Nam', N'Bến Tre','0964412836'),
							 (36, 'KH36', N'Tèo Em', '06/07/1999', N'Nam', N'Sóc Trăng','0964412837'),
							 (37, 'KH37', N'Đặng Ngọc Linh', '03/03/2000', N'Nữ', N'Bình Định','0964412838'),
							 (38, 'KH38', N'Trần Minh Hồng', '09/09/2000', N'Nữ', N'Trà Vinh','0964412839'),
							 (39, 'KH39', N'Trần Nhân Kiệt', '01/11/1999', N'Nam', N'Gia Lai','0964412830'),
							 (40, 'KH40', N'Trần Văn Lặc', '03/01/1999', N'Nam', N'Đăk Lăk','0964412840'),
							 (41, 'KH41', N'Nguyễn Văn Minh', '02/02/1999', N'Nam', N'Kon Tum','0964412841'),
							 (42, 'KH42', N'Nguyễn Tấn Công', '18/08/1998', N'Nam', N'Đắc Nông','0964412842'),
							 (43, 'KH43', N'Đoàn Văn Bơ', '09/10/1999', N'Nam', N'Ninh Thuận','0964412843'),
							 (44, 'KH44', N'Đoàn Văn Phòng Thủ', '07/10/1999', N'Nam', N'Thanh Hóa','0964412844'),
							 (45, 'KH45', N'Phan Tại Thắng', '04/06/1999', N'Nam', N'Khánh Hòa','0964412845'),
							 (46, 'KH46', N'Nguyễn Ngọc Hiền', '09/10/1999', N'Nam', N'Quãng Ngãi','0964412846'),
							 (47, 'KH47', N'Lê Vĩnh Khiêm', '19/10/1999', N'Nam', N'Quảng Trị','0964412847'),
							 (48, 'KH48', N'Tư Mã Ý', '05/10/2003', N'Nam', N'Quảng Bình','0964412848'),
							 (49, 'KH49', N'Triệu Tử Long', '02/10/1990', N'Nam', N'Nam Định','0964412849'),
							 (50, 'KH50', N'Điêu Thuyền', '11/01/1999', N'Nữ', N'Bắc Ninh','0964412850'),
							 (51, 'KH51', N'Dương Quá', '20/10/1999', N'Nam', N'Hà Tĩnh','0964412851'),
							 (52, 'KH52', N'Đoàn Văn Hậu', '09/10/1999', N'Nam', N'Thái Bình','0964412853'),
							 (53, 'KH53', N'Nguyễn Trọng Hoàng', '05/05/1995', N'Nam', N'Nghệ An','0964412854'),
							 (54, 'KH54', N'Lê Tông Lào', '04/04/1999', N'Nam', N'Lào Cai','0964412855'),
							 (55, 'KH55', N'Lê Văn Châu', '03/03/1999', N'Nam', N'Lai Châu','0964412856'),
							 (56, 'KH56', N'Trần Thọ', '05/10/1995', N'Nam', N'Phú Thọ','0964412857'),
							 (57, 'KH57', N'Nguyễn Như', '11/06/1999', N'Nữ', N'TP.HCM','0964412859'),
							 (58, 'KH58', N'Nguyễn  Huy Công', '10/10/1998', N'Nam', N'Thanh Hóa','0964412121'),
							 (59, 'KH59', N'Hoàng Xuân Vinh', '09/11/1997', N'Nam', N'Nghệ An','096441223')

INSERT INTO NHANVIEN VALUES (1, 'NV01', N'Nguyễn Huy Hoàng', '15/06/1999', N'Nam', '0942655127', N'Tây Ninh', N'Quản lý')


INSERT INTO HOADON VALUES ('HD01', 'KH01', 'NV02', '26-02-2015', 100)





