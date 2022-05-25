USE [18_5_2022]
GO
/****** Object:  Table [dbo].[TienThang]    Script Date: 5/25/2022 3:11:57 PM ******/
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
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'2         ', CAST(N'2020-08-12' AS Date), 0.0000, 0, 0.0000, 0.0000, 0, 0.0000, 0.0000, 0.0000, 1)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'1         ', CAST(N'2021-09-18' AS Date), 0.0000, 0, 0.0000, 0.0000, 0, 0.0000, 0.0000, 0.0000, 1)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'3         ', CAST(N'2021-12-06' AS Date), 0.0000, 0, 0.0000, 0.0000, 0, 0.0000, 0.0000, 0.0000, 1)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'1         ', CAST(N'2022-03-31' AS Date), 6258064.5161, 1, 3000.0000, 3000.0000, 1, 500.0000, 500.0000, 6261564.5161, 1)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'1         ', CAST(N'2022-04-30' AS Date), 967741.9355, 100, 3000.0000, 297000.0000, 60, 500.0000, 29500.0000, 1294241.9355, 0)
INSERT [dbo].[TienThang] ([IdPhong], [NgayThu], [TienPhong], [ChuDien], [TienMotChuDien], [TienDien], [ChuNuoc], [TienMotChuNuoc], [TienNuoc], [TongTien], [DaNop]) VALUES (N'1         ', CAST(N'2022-05-31' AS Date), 1000000.0000, 150, 3000.0000, 150000.0000, 90, 500.0000, 15000.0000, 1165000.0000, 0)
GO
