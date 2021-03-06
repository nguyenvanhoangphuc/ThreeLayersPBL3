USE [master]
GO
/****** Object:  Database [18_5_2022]    Script Date: 5/20/2022 2:51:04 PM ******/
CREATE DATABASE [18_5_2022]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'18_5_2022', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MAYAO\MSSQL\DATA\18_5_2022.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'18_5_2022_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MAYAO\MSSQL\DATA\18_5_2022_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [18_5_2022] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [18_5_2022].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [18_5_2022] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [18_5_2022] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [18_5_2022] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [18_5_2022] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [18_5_2022] SET ARITHABORT OFF 
GO
ALTER DATABASE [18_5_2022] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [18_5_2022] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [18_5_2022] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [18_5_2022] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [18_5_2022] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [18_5_2022] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [18_5_2022] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [18_5_2022] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [18_5_2022] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [18_5_2022] SET  DISABLE_BROKER 
GO
ALTER DATABASE [18_5_2022] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [18_5_2022] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [18_5_2022] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [18_5_2022] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [18_5_2022] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [18_5_2022] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [18_5_2022] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [18_5_2022] SET RECOVERY FULL 
GO
ALTER DATABASE [18_5_2022] SET  MULTI_USER 
GO
ALTER DATABASE [18_5_2022] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [18_5_2022] SET DB_CHAINING OFF 
GO
ALTER DATABASE [18_5_2022] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [18_5_2022] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [18_5_2022] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [18_5_2022] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'18_5_2022', N'ON'
GO
ALTER DATABASE [18_5_2022] SET QUERY_STORE = OFF
GO
USE [18_5_2022]
GO
/****** Object:  Table [dbo].[DanhSachIDLTB]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachIDLTB](
	[IDLoaiPhong] [nchar](10) NOT NULL,
	[IDLoaiThietBi] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_DanhSachIDLTB] PRIMARY KEY CLUSTERED 
(
	[IDLoaiPhong] ASC,
	[IDLoaiThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichSuSuaChua]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuSuaChua](
	[ID_LichSuSuaChua] [nchar](10) NOT NULL,
	[IDNhanVien] [nchar](10) NOT NULL,
	[IDPhong] [nchar](10) NOT NULL,
	[ID_LoaiThietBi] [nchar](10) NOT NULL,
	[NgaySuaChua] [date] NOT NULL,
	[SoTienSuaChua] [int] NOT NULL,
 CONSTRAINT [PK_LichSuSuaChua] PRIMARY KEY CLUSTERED 
(
	[ID_LichSuSuaChua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiPhong]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiPhong](
	[IDLoaiPhong] [nchar](10) NOT NULL,
	[TenLoaiPhong] [nvarchar](50) NOT NULL,
	[GiaThanh] [int] NOT NULL,
 CONSTRAINT [PK_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[IDLoaiPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThietBi]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThietBi](
	[IDLoaiThietBi] [nchar](10) NOT NULL,
	[TenThietBi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiThietBi] PRIMARY KEY CLUSTERED 
(
	[IDLoaiThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[ID] [nchar](10) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[CCCD] [nvarchar](15) NOT NULL,
	[TuCach] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NguoiDung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiThue]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiThue](
	[HoTen] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](15) NOT NULL,
	[QueQuan] [nvarchar](50) NOT NULL,
	[CCCD] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NguoiThue] PRIMARY KEY CLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongTro]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongTro](
	[ID] [nchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NOT NULL,
	[ID_LoaiPhong] [nchar](10) NOT NULL,
	[TinhTrang] [bit] NOT NULL,
	[NgayThue] [date] NULL,
	[SoChuDien] [int] NOT NULL,
	[TienHienTai] [int] NULL,
 CONSTRAINT [PK_PhongTro] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QLDatPhong]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLDatPhong](
	[SDT] [nvarchar](15) NOT NULL,
	[ID_Phong] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[ID] [nchar](10) NOT NULL,
	[TenTK] [nvarchar](50) NOT NULL,
	[MKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThietBi](
	[ID Phòng] [nchar](10) NOT NULL,
	[ID Loại thiết bị] [nchar](10) NOT NULL,
	[Tình trạng] [bit] NOT NULL,
 CONSTRAINT [PK_ThietBi] PRIMARY KEY CLUSTERED 
(
	[ID Phòng] ASC,
	[ID Loại thiết bị] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TienThang]    Script Date: 5/20/2022 2:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TienThang](
	[IdPhong] [nvarchar](50) NOT NULL,
	[NgayThu] [date] NOT NULL,
	[TienPhong] [money] NOT NULL,
	[ChuDien] [int] NOT NULL,
	[TienMotChuDien] [money] NOT NULL,
	[TienDien] [money] NOT NULL,
	[ChuNuoc] [int] NOT NULL,
	[TienMotChuNuoc] [money] NOT NULL,
	[TienNuoc] [money] NOT NULL,
	[TongTien] [money] NOT NULL,
	[DaNop] [bit] NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'1         ', N'1         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'1         ', N'2         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'1         ', N'3         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'2         ', N'1         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'2         ', N'2         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'2         ', N'3         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'2         ', N'4         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'2         ', N'5         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'3         ', N'1         ', 2)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'3         ', N'2         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'3         ', N'3         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'3         ', N'4         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'3         ', N'5         ', 2)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'4         ', N'1         ', 2)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'4         ', N'2         ', 2)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'4         ', N'3         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'4         ', N'4         ', 1)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'4         ', N'5         ', 2)
INSERT [dbo].[DanhSachIDLTB] ([IDLoaiPhong], [IDLoaiThietBi], [SoLuong]) VALUES (N'4         ', N'6         ', 1)
GO
INSERT [dbo].[LoaiPhong] ([IDLoaiPhong], [TenLoaiPhong], [GiaThanh]) VALUES (N'1         ', N'Phòng 1 người', 1000000)
INSERT [dbo].[LoaiPhong] ([IDLoaiPhong], [TenLoaiPhong], [GiaThanh]) VALUES (N'2         ', N'Phòng 2 người', 1700000)
INSERT [dbo].[LoaiPhong] ([IDLoaiPhong], [TenLoaiPhong], [GiaThanh]) VALUES (N'3         ', N'Phòng 4 người', 2500000)
INSERT [dbo].[LoaiPhong] ([IDLoaiPhong], [TenLoaiPhong], [GiaThanh]) VALUES (N'4         ', N'Phòng cho cả gia đình', 3800000)
GO
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'1         ', N'Giường ngủ')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'10        ', N'Sofa')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'11        ', N'Chậu rửa mật')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'12        ', N'Gương soi')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'13        ', N'Vòi sen')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'14        ', N'Bồn cầu')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'15        ', N'Tủ lạnh')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'16        ', N'Bếp điện từ')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'2         ', N'Tủ quần áo')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'3         ', N'Điều hòa')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'4         ', N'Bàn trang điểm')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'5         ', N'Tivi')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'6         ', N'Đèn')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'7         ', N'Quạt trần')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'8         ', N'Tủ bếp')
INSERT [dbo].[LoaiThietBi] ([IDLoaiThietBi], [TenThietBi]) VALUES (N'9         ', N'Bộ bàn ăn')
GO
INSERT [dbo].[NguoiDung] ([ID], [Ten], [QueQuan], [SDT], [CCCD], [TuCach]) VALUES (N'1         ', N'NVHPhuc', N'DaiLoc', N'0337689694', N'206436708', N'ChuTro')
INSERT [dbo].[NguoiDung] ([ID], [Ten], [QueQuan], [SDT], [CCCD], [TuCach]) VALUES (N'2         ', N'TTNguyen', N'CamLe', N'0905050523', N'207112113', N'NhanVien')
INSERT [dbo].[NguoiDung] ([ID], [Ten], [QueQuan], [SDT], [CCCD], [TuCach]) VALUES (N'3         ', N'NCCuong', N'TamKi', N'0122852703', N'208224115', N'ChuTro')
INSERT [dbo].[NguoiDung] ([ID], [Ten], [QueQuan], [SDT], [CCCD], [TuCach]) VALUES (N'4         ', N'TTTPhuong', N'BacCan', N'0303040401', N'209114111', N'NhanVien')
GO
INSERT [dbo].[NguoiThue] ([HoTen], [SDT], [QueQuan], [CCCD]) VALUES (N'Nguyễn Văn Hoàng Phúc', N'011111222', N'Đại Lộc', N'115')
INSERT [dbo].[NguoiThue] ([HoTen], [SDT], [QueQuan], [CCCD]) VALUES (N'Nguyễn Công Cường', N'0333333330', N'Tam Kì', N'102')
INSERT [dbo].[NguoiThue] ([HoTen], [SDT], [QueQuan], [CCCD]) VALUES (N'Trần Thanh Nguyên', N'0444444444', N'Cẩm Lệ', N'1234')
GO
INSERT [dbo].[PhongTro] ([ID], [TenPhong], [ID_LoaiPhong], [TinhTrang], [NgayThue], [SoChuDien], [TienHienTai]) VALUES (N'1         ', N'P1', N'1         ', 1, CAST(N'2021-09-18' AS Date), 100, 0)
INSERT [dbo].[PhongTro] ([ID], [TenPhong], [ID_LoaiPhong], [TinhTrang], [NgayThue], [SoChuDien], [TienHienTai]) VALUES (N'2         ', N'P2', N'2         ', 1, CAST(N'2020-08-12' AS Date), 200, 0)
INSERT [dbo].[PhongTro] ([ID], [TenPhong], [ID_LoaiPhong], [TinhTrang], [NgayThue], [SoChuDien], [TienHienTai]) VALUES (N'3         ', N'P3', N'3         ', 1, CAST(N'2021-12-06' AS Date), 500, 0)
INSERT [dbo].[PhongTro] ([ID], [TenPhong], [ID_LoaiPhong], [TinhTrang], [NgayThue], [SoChuDien], [TienHienTai]) VALUES (N'4         ', N'P4', N'4         ', 0, NULL, 0, NULL)
INSERT [dbo].[PhongTro] ([ID], [TenPhong], [ID_LoaiPhong], [TinhTrang], [NgayThue], [SoChuDien], [TienHienTai]) VALUES (N'5         ', N'P5', N'1         ', 0, NULL, 0, NULL)
INSERT [dbo].[PhongTro] ([ID], [TenPhong], [ID_LoaiPhong], [TinhTrang], [NgayThue], [SoChuDien], [TienHienTai]) VALUES (N'6         ', N'P6', N'2         ', 0, NULL, 0, NULL)
GO
INSERT [dbo].[QLDatPhong] ([SDT], [ID_Phong]) VALUES (N'011111222', N'1         ')
INSERT [dbo].[QLDatPhong] ([SDT], [ID_Phong]) VALUES (N'0333333330', N'2         ')
INSERT [dbo].[QLDatPhong] ([SDT], [ID_Phong]) VALUES (N'0444444444', N'3         ')
GO
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MKhau]) VALUES (N'1         ', N'Phuc', N'231002')
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MKhau]) VALUES (N'2         ', N'Nguyen', N'060402')
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MKhau]) VALUES (N'3         ', N'Phuong', N'120202')
INSERT [dbo].[TaiKhoan] ([ID], [TenTK], [MKhau]) VALUES (N'4         ', N'Cuong', N'280802')
GO
INSERT [dbo].[ThietBi] ([ID Phòng], [ID Loại thiết bị], [Tình trạng]) VALUES (N'1         ', N'1         ', 0)
INSERT [dbo].[ThietBi] ([ID Phòng], [ID Loại thiết bị], [Tình trạng]) VALUES (N'1         ', N'2         ', 0)
INSERT [dbo].[ThietBi] ([ID Phòng], [ID Loại thiết bị], [Tình trạng]) VALUES (N'1         ', N'4         ', 0)
INSERT [dbo].[ThietBi] ([ID Phòng], [ID Loại thiết bị], [Tình trạng]) VALUES (N'2         ', N'1         ', 0)
INSERT [dbo].[ThietBi] ([ID Phòng], [ID Loại thiết bị], [Tình trạng]) VALUES (N'2         ', N'2         ', 0)
INSERT [dbo].[ThietBi] ([ID Phòng], [ID Loại thiết bị], [Tình trạng]) VALUES (N'3         ', N'10        ', 0)
INSERT [dbo].[ThietBi] ([ID Phòng], [ID Loại thiết bị], [Tình trạng]) VALUES (N'4         ', N'1         ', 0)
INSERT [dbo].[ThietBi] ([ID Phòng], [ID Loại thiết bị], [Tình trạng]) VALUES (N'4         ', N'3         ', 0)
GO
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'1         ', CAST(N'2022-06-30' AS Date), 1322580.6452, 100, 4000.0000, 280000.0000, 70, 1000.0000, 20000.0000, 1622580.6452, 0)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'1         ', CAST(N'2022-07-31' AS Date), 1000000.0000, 150, 2500.0000, 125000.0000, 100, 500.0000, 15000.0000, 1140000.0000, 0)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'2         ', CAST(N'2020-08-12' AS Date), 0.0000, 0, 0.0000, 0.0000, 0, 0.0000, 0.0000, 0.0000, 1)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'2         ', CAST(N'2022-01-31' AS Date), 29448387.0968, 40, 2500.0000, 100000.0000, 60, 600.0000, 36000.0000, 29584387.0968, 1)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'2         ', CAST(N'2022-05-20' AS Date), 5977419.3548, 50, 2500.0000, 25000.0000, 60, 500.0000, 0.0000, 6002419.3548, 0)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'3         ', CAST(N'2022-05-31' AS Date), 14193548.3871, 70, 2500.0000, 175000.0000, 50, 500.0000, 25000.0000, 14393548.3871, 0)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'1         ', CAST(N'2021-09-18' AS Date), 0.0000, 0, 0.0000, 0.0000, 0, 0.0000, 0.0000, 0.0000, 1)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'3         ', CAST(N'2021-12-06' AS Date), 0.0000, 0, 0.0000, 0.0000, 0, 0.0000, 0.0000, 0.0000, 1)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'1         ', CAST(N'2022-05-20' AS Date), 7870967.7419, 30, 3000.0000, 90000.0000, 50, 500.0000, 25000.0000, 7985967.7419, 1)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'3         ', CAST(N'2022-08-31' AS Date), 7419354.8387, 150, 2500.0000, 252500.0000, 200, 500.0000, 61500.0000, 7733354.8387, 1)
GO
ALTER TABLE [dbo].[DanhSachIDLTB]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachIDLTB_LoaiPhong] FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([IDLoaiPhong])
GO
ALTER TABLE [dbo].[DanhSachIDLTB] CHECK CONSTRAINT [FK_DanhSachIDLTB_LoaiPhong]
GO
ALTER TABLE [dbo].[DanhSachIDLTB]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachIDLTB_LoaiThietBi] FOREIGN KEY([IDLoaiThietBi])
REFERENCES [dbo].[LoaiThietBi] ([IDLoaiThietBi])
GO
ALTER TABLE [dbo].[DanhSachIDLTB] CHECK CONSTRAINT [FK_DanhSachIDLTB_LoaiThietBi]
GO
ALTER TABLE [dbo].[LichSuSuaChua]  WITH CHECK ADD  CONSTRAINT [FK_LichSuSuaChua_NguoiDung] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NguoiDung] ([ID])
GO
ALTER TABLE [dbo].[LichSuSuaChua] CHECK CONSTRAINT [FK_LichSuSuaChua_NguoiDung]
GO
ALTER TABLE [dbo].[LichSuSuaChua]  WITH CHECK ADD  CONSTRAINT [FK_LichSuSuaChua_PhongTro] FOREIGN KEY([IDPhong])
REFERENCES [dbo].[PhongTro] ([ID])
GO
ALTER TABLE [dbo].[LichSuSuaChua] CHECK CONSTRAINT [FK_LichSuSuaChua_PhongTro]
GO
ALTER TABLE [dbo].[LichSuSuaChua]  WITH CHECK ADD  CONSTRAINT [FK_LichSuSuaChua_ThietBi] FOREIGN KEY([IDPhong], [ID_LoaiThietBi])
REFERENCES [dbo].[ThietBi] ([ID Phòng], [ID Loại thiết bị])
GO
ALTER TABLE [dbo].[LichSuSuaChua] CHECK CONSTRAINT [FK_LichSuSuaChua_ThietBi]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_TaiKhoan] FOREIGN KEY([ID])
REFERENCES [dbo].[TaiKhoan] ([ID])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_TaiKhoan]
GO
ALTER TABLE [dbo].[PhongTro]  WITH CHECK ADD  CONSTRAINT [FK_PhongTro_LoaiPhong] FOREIGN KEY([ID_LoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([IDLoaiPhong])
GO
ALTER TABLE [dbo].[PhongTro] CHECK CONSTRAINT [FK_PhongTro_LoaiPhong]
GO
ALTER TABLE [dbo].[QLDatPhong]  WITH CHECK ADD  CONSTRAINT [FK_QLDatPhong_NguoiThue] FOREIGN KEY([SDT])
REFERENCES [dbo].[NguoiThue] ([SDT])
GO
ALTER TABLE [dbo].[QLDatPhong] CHECK CONSTRAINT [FK_QLDatPhong_NguoiThue]
GO
ALTER TABLE [dbo].[QLDatPhong]  WITH CHECK ADD  CONSTRAINT [FK_QLDatPhong_PhongTro] FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[PhongTro] ([ID])
GO
ALTER TABLE [dbo].[QLDatPhong] CHECK CONSTRAINT [FK_QLDatPhong_PhongTro]
GO
ALTER TABLE [dbo].[ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_ThietBi_LoaiThietBi] FOREIGN KEY([ID Phòng])
REFERENCES [dbo].[LoaiThietBi] ([IDLoaiThietBi])
GO
ALTER TABLE [dbo].[ThietBi] CHECK CONSTRAINT [FK_ThietBi_LoaiThietBi]
GO
ALTER TABLE [dbo].[ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_ThietBi_PhongTro] FOREIGN KEY([ID Phòng])
REFERENCES [dbo].[PhongTro] ([ID])
GO
ALTER TABLE [dbo].[ThietBi] CHECK CONSTRAINT [FK_ThietBi_PhongTro]
GO
USE [master]
GO
ALTER DATABASE [18_5_2022] SET  READ_WRITE 
GO
