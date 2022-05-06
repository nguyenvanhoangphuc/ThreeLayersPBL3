USE [pbl3]
GO
/****** Object:  Table [dbo].[LoaiThietBi]    Script Date: 5/6/2022 2:46:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThietBi](
	[ID Loại thiết bị] [nchar](10) NOT NULL,
	[Tên thiết bị] [nvarchar](50) NOT NULL,
	[Giá] [decimal](10, 3) NULL,
	[Số lượng] [smallint] NOT NULL,
 CONSTRAINT [PK_LoaiThietBi] PRIMARY KEY CLUSTERED 
(
	[ID Loại thiết bị] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phong]    Script Date: 5/6/2022 2:46:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phong](
	[ID Phòng] [nchar](10) NOT NULL,
	[Tên Phòng] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[ID Phòng] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 5/6/2022 2:46:14 PM ******/
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
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'1         ', N'Giường ngủ', CAST(3800.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'10        ', N'Sofa', CAST(1200.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'11        ', N'Chậu rửa mật', CAST(500.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'12        ', N'Gương soi', CAST(200.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'13        ', N'Vòi sen', CAST(200.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'14        ', N'Bồn cầu', CAST(2000.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'15        ', N'Tủ lạnh', CAST(2500.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'16        ', N'Bếp điện từ', CAST(3400.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'2         ', N'Tủ quần áo', CAST(290.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'3         ', N'Điều hòa', CAST(4800.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'4         ', N'Bàn trang điểm', CAST(600.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'5         ', N'Tivi', CAST(6000.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'6         ', N'Đèn', CAST(200.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'7         ', N'Quạt trần', CAST(1000.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'8         ', N'Tủ bếp', CAST(1600.000 AS Decimal(10, 3)), 0)
INSERT [dbo].[LoaiThietBi] ([ID Loại thiết bị], [Tên thiết bị], [Giá], [Số lượng]) VALUES (N'9         ', N'Bộ bàn ăn', CAST(1800.000 AS Decimal(10, 3)), 0)
GO
INSERT [dbo].[Phong] ([ID Phòng], [Tên Phòng]) VALUES (N'1         ', N'101       ')
INSERT [dbo].[Phong] ([ID Phòng], [Tên Phòng]) VALUES (N'2         ', N'102       ')
INSERT [dbo].[Phong] ([ID Phòng], [Tên Phòng]) VALUES (N'3         ', N'103       ')
INSERT [dbo].[Phong] ([ID Phòng], [Tên Phòng]) VALUES (N'4         ', N'104       ')
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
ALTER TABLE [dbo].[ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_ThietBi_LoaiThietBi] FOREIGN KEY([ID Phòng])
REFERENCES [dbo].[LoaiThietBi] ([ID Loại thiết bị])
GO
ALTER TABLE [dbo].[ThietBi] CHECK CONSTRAINT [FK_ThietBi_LoaiThietBi]
GO
ALTER TABLE [dbo].[ThietBi]  WITH CHECK ADD  CONSTRAINT [FK_ThietBi_Phong] FOREIGN KEY([ID Phòng])
REFERENCES [dbo].[Phong] ([ID Phòng])
GO
ALTER TABLE [dbo].[ThietBi] CHECK CONSTRAINT [FK_ThietBi_Phong]
GO
