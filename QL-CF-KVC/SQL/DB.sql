/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2019 (15.0.2000)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2019
    Target Database Engine Edition : Microsoft SQL Server Express Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [QL_CF_KVC]
GO
/****** Object:  Table [dbo].[books]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[ma_sach] [varchar](256) NOT NULL,
	[ten_sach] [varchar](256) NULL,
	[ma_loai_sach] [varchar](256) NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK__books__097905C69D6BB6CC] PRIMARY KEY CLUSTERED 
(
	[ma_sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[booktypes]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[booktypes](
	[ma_loai_sach] [varchar](256) NOT NULL,
	[ten_loai_sach] [varchar](256) NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK__booktype__2F94219D39AEBD7E] PRIMARY KEY CLUSTERED 
(
	[ma_loai_sach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[brokens]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brokens](
	[ma_ph] [bigint] IDENTITY(1,1) NOT NULL,
	[ngay_lap] [date] NULL,
	[ghi_chu] [nvarchar](512) NULL,
	[so_luong] [bigint] NULL,
	[tong_tien] [bigint] NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK__brokens__0FE0AF884631A956] PRIMARY KEY CLUSTERED 
(
	[ma_ph] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[brokensdetail]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brokensdetail](
	[ma_ph] [bigint] NOT NULL,
	[stt] [int] NOT NULL,
	[ma_vt] [varchar](32) NULL,
	[so_luong] [bigint] NULL,
	[ly_do] [nvarchar](512) NULL,
	[ghi_chu] [nvarchar](512) NULL,
	[tong_tien] [bigint] NULL,
 CONSTRAINT [PK__brokensd__F23D5CA0256B62B4] PRIMARY KEY CLUSTERED 
(
	[ma_ph] ASC,
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[checks]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[checks](
	[ma_ph] [bigint] IDENTITY(1,1) NOT NULL,
	[ngay_lap] [date] NULL,
	[ghi_chu] [nvarchar](512) NULL,
	[so_luong1] [bigint] NULL,
	[tong_tien1] [bigint] NULL,
	[so_luong2] [bigint] NULL,
	[tong_tien2] [bigint] NULL,
	[so_luong3] [bigint] NULL,
	[tong_tien3] [bigint] NULL,
	[so_luong4] [bigint] NULL,
	[tong_tien4] [bigint] NULL,
	[full_quality] [int] NULL,
	[poor_quality] [int] NULL,
	[loss_quality] [int] NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK_checks] PRIMARY KEY CLUSTERED 
(
	[ma_ph] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[checksdetail]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[checksdetail](
	[ma_ph] [bigint] NOT NULL,
	[stt] [int] NOT NULL,
	[ma_vt] [varchar](32) NULL,
	[so_luong1] [bigint] NULL,
	[tong_tien1] [bigint] NULL,
	[so_luong2] [bigint] NULL,
	[tong_tien2] [bigint] NULL,
	[so_luong3] [bigint] NULL,
	[tong_tien3] [bigint] NULL,
	[so_luong4] [bigint] NULL,
	[tong_tien4] [bigint] NULL,
	[full_quality] [int] NULL,
	[poor_quality] [int] NULL,
	[loss_quality] [int] NULL,
 CONSTRAINT [PK_checksdetail] PRIMARY KEY CLUSTERED 
(
	[ma_ph] ASC,
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[ma_nv] [varchar](32) NOT NULL,
	[ten_nv] [varchar](256) NULL,
	[ngay_sinh] [date] NULL,
	[ngay_bd] [date] NULL,
	[gioi_tinh] [char](1) NULL,
	[muc_luong] [bigint] NULL,
	[nsd] [int] NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[ma_nv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[items]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[items](
	[ma_vt] [varchar](32) NOT NULL,
	[ten_vt] [varchar](256) NULL,
	[mo_ta] [nvarchar](512) NULL,
	[sl_ton] [int] NULL,
	[gia_ban] [bigint] NULL,
	[ma_ncc] [varchar](32) NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK_items] PRIMARY KEY CLUSTERED 
(
	[ma_vt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materials]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materials](
	[ma_vl] [varchar](32) NOT NULL,
	[ten_vl] [varchar](256) NULL,
	[ma_ncc] [varchar](32) NULL,
	[sl_ton] [int] NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK_materials] PRIMARY KEY CLUSTERED 
(
	[ma_vl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[ma_dh] [bigint] IDENTITY(1,1) NOT NULL,
	[ngay_lap] [date] NULL,
	[ma_ban] [varchar](32) NULL,
	[ten_khach] [nvarchar](256) NULL,
	[sdt_khach] [varchar](32) NULL,
	[ghi_chu] [nvarchar](512) NULL,
	[xtype] [char](1) NULL,
	[so_luong] [int] NULL,
	[tien_hang] [bigint] NULL,
	[khuyen_mai] [bigint] NULL,
	[tien_thue] [bigint] NULL,
	[tong_tien] [bigint] NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[ma_dh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ordersdetail]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ordersdetail](
	[ma_dh] [bigint] NOT NULL,
	[stt] [int] NOT NULL,
	[ma_vt] [varchar](32) NOT NULL,
	[so_luong] [int] NULL,
	[tien_hang] [bigint] NULL,
	[khuyen_mai] [bigint] NULL,
	[tien_thue] [bigint] NULL,
	[tong_tien] [bigint] NULL,
 CONSTRAINT [PK_ordersdetail] PRIMARY KEY CLUSTERED 
(
	[ma_dh] ASC,
	[stt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[places]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[places](
	[ma_khu] [varchar](32) NOT NULL,
	[ten_khu] [varchar](256) NULL,
	[tinh_trang] [varchar](32) NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK_places] PRIMARY KEY CLUSTERED 
(
	[ma_khu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[providers]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[providers](
	[ma_ncc] [varchar](32) NOT NULL,
	[ten_ncc] [varchar](256) NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK_providers] PRIMARY KEY CLUSTERED 
(
	[ma_ncc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tables]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tables](
	[ma_ban] [varchar](32) NOT NULL,
	[ma_khu] [varchar](32) NULL,
	[ten_ban] [varchar](256) NULL,
	[size] [int] NULL,
	[tinh_trang] [varchar](32) NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK_tables] PRIMARY KEY CLUSTERED 
(
	[ma_ban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 5/9/2022 10:08:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](256) NULL,
	[full_name] [nvarchar](128) NULL,
	[password] [varchar](32) NULL,
	[admin] [bit] NULL,
	[manager] [bit] NULL,
	[trang_thai] [char](1) NULL,
	[ngay_tao] [datetime] NULL,
	[ngay_sua] [datetime] NULL,
	[nguoi_tao] [int] NULL,
	[nguoi_sua] [int] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[books] ([ma_sach], [ten_sach], [ma_loai_sach], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'HIC', N'hic a', N'K', N'1', CAST(N'2022-05-06T23:13:24.980' AS DateTime), CAST(N'2022-05-08T11:08:25.577' AS DateTime), 1, 1)
GO
INSERT [dbo].[books] ([ma_sach], [ten_sach], [ma_loai_sach], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'HUHU', N'huhu', N'L', N'1', CAST(N'2022-05-08T14:13:47.070' AS DateTime), CAST(N'2022-05-08T14:13:47.070' AS DateTime), 1, 1)
GO
INSERT [dbo].[books] ([ma_sach], [ten_sach], [ma_loai_sach], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'XXX', N'XXX', N'XXX', N'1', CAST(N'2022-05-08T21:03:50.360' AS DateTime), CAST(N'2022-05-08T21:04:07.737' AS DateTime), 1, 1)
GO
INSERT [dbo].[booktypes] ([ma_loai_sach], [ten_loai_sach], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'K', N'KID', N'1', CAST(N'2022-05-06T22:24:37.197' AS DateTime), CAST(N'2022-05-09T21:34:12.790' AS DateTime), 1, 1)
GO
INSERT [dbo].[booktypes] ([ma_loai_sach], [ten_loai_sach], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'L', N'LAW', N'1', CAST(N'2022-05-06T22:24:27.383' AS DateTime), CAST(N'2022-05-09T21:34:16.760' AS DateTime), 1, 1)
GO
INSERT [dbo].[booktypes] ([ma_loai_sach], [ten_loai_sach], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'XXX', N'XXXXXX', N'1', CAST(N'2022-05-08T21:03:59.720' AS DateTime), CAST(N'2022-05-09T21:34:19.210' AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[brokens] ON 
GO
INSERT [dbo].[brokens] ([ma_ph], [ngay_lap], [ghi_chu], [so_luong], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (1, CAST(N'2022-04-25' AS Date), N'AAAAA 33 3', 30, 10333330, N'0', CAST(N'2022-05-08T11:37:02.287' AS DateTime), CAST(N'2022-05-08T11:37:07.270' AS DateTime), 1, 1)
GO
INSERT [dbo].[brokens] ([ma_ph], [ngay_lap], [ghi_chu], [so_luong], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (2, CAST(N'2022-04-25' AS Date), N'XXXX', 12, 3000000, N'0', CAST(N'2022-05-08T21:07:27.017' AS DateTime), CAST(N'2022-05-08T21:07:27.017' AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[brokens] OFF
GO
INSERT [dbo].[brokensdetail] ([ma_ph], [stt], [ma_vt], [so_luong], [ly_do], [ghi_chu], [tong_tien]) VALUES (1, 1, N'VT002', 10, N'AVVC', N'CAAC', 10000000)
GO
INSERT [dbo].[brokensdetail] ([ma_ph], [stt], [ma_vt], [so_luong], [ly_do], [ghi_chu], [tong_tien]) VALUES (1, 2, N'VT002', 20, N'DQWDQWDQW', N'D2112D', 333330)
GO
INSERT [dbo].[brokensdetail] ([ma_ph], [stt], [ma_vt], [so_luong], [ly_do], [ghi_chu], [tong_tien]) VALUES (2, 1, N'XXX', 10, N'Bi đập phá', N'Cần sửa gấp', 1000000)
GO
INSERT [dbo].[brokensdetail] ([ma_ph], [stt], [ma_vt], [so_luong], [ly_do], [ghi_chu], [tong_tien]) VALUES (2, 2, N'VT004', 2, N'Mất mát', N'Cần mua gấp', 2000000)
GO
SET IDENTITY_INSERT [dbo].[checks] ON 
GO
INSERT [dbo].[checks] ([ma_ph], [ngay_lap], [ghi_chu], [so_luong1], [tong_tien1], [so_luong2], [tong_tien2], [so_luong3], [tong_tien3], [so_luong4], [tong_tien4], [full_quality], [poor_quality], [loss_quality], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (1, CAST(N'2022-04-25' AS Date), N'121212112', 12120, 12120, 1212120, 12120, 1200000, 0, 0, 0, 10, 20, 30, N'0', CAST(N'2022-05-08T14:08:34.130' AS DateTime), CAST(N'2022-05-08T14:09:14.680' AS DateTime), 1, 1)
GO
INSERT [dbo].[checks] ([ma_ph], [ngay_lap], [ghi_chu], [so_luong1], [tong_tien1], [so_luong2], [tong_tien2], [so_luong3], [tong_tien3], [so_luong4], [tong_tien4], [full_quality], [poor_quality], [loss_quality], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (2, CAST(N'2022-04-25' AS Date), N'1231212dfdd', 1124230, 2134560, 126340, 156560, 1110, 30110, 999000, 2008110, 12220, 12230, 1450, N'0', CAST(N'2022-05-08T14:09:37.727' AS DateTime), CAST(N'2022-05-08T14:09:37.727' AS DateTime), 1, 1)
GO
INSERT [dbo].[checks] ([ma_ph], [ngay_lap], [ghi_chu], [so_luong1], [tong_tien1], [so_luong2], [tong_tien2], [so_luong3], [tong_tien3], [so_luong4], [tong_tien4], [full_quality], [poor_quality], [loss_quality], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (3, CAST(N'2022-04-25' AS Date), N'XXXX', 1121, 1011110, 11119, 911110, 9999, 0, 1, 100000, 5, 2, 2, N'1', CAST(N'2022-05-08T21:06:21.407' AS DateTime), CAST(N'2022-05-08T21:06:21.407' AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[checks] OFF
GO
INSERT [dbo].[checksdetail] ([ma_ph], [stt], [ma_vt], [so_luong1], [tong_tien1], [so_luong2], [tong_tien2], [so_luong3], [tong_tien3], [so_luong4], [tong_tien4], [full_quality], [poor_quality], [loss_quality]) VALUES (1, 1, N'VT002', 12120, 12120, 1212120, 12120, 1200000, 0, 0, 0, 10, 20, 30)
GO
INSERT [dbo].[checksdetail] ([ma_ph], [stt], [ma_vt], [so_luong1], [tong_tien1], [so_luong2], [tong_tien2], [so_luong3], [tong_tien3], [so_luong4], [tong_tien4], [full_quality], [poor_quality], [loss_quality]) VALUES (2, 1, N'VT002', 1110, 3330, 2220, 33440, 1110, 30110, 0, 0, 10, 20, 30)
GO
INSERT [dbo].[checksdetail] ([ma_ph], [stt], [ma_vt], [so_luong1], [tong_tien1], [so_luong2], [tong_tien2], [so_luong3], [tong_tien3], [so_luong4], [tong_tien4], [full_quality], [poor_quality], [loss_quality]) VALUES (2, 2, N'VT002', 1123120, 2131230, 124120, 123120, 0, 0, 999000, 2008110, 12210, 12210, 1420)
GO
INSERT [dbo].[checksdetail] ([ma_ph], [stt], [ma_vt], [so_luong1], [tong_tien1], [so_luong2], [tong_tien2], [so_luong3], [tong_tien3], [so_luong4], [tong_tien4], [full_quality], [poor_quality], [loss_quality]) VALUES (3, 1, N'XXX', 10, 1000000, 9, 900000, 0, 0, 1, 100000, 5, 2, 2)
GO
INSERT [dbo].[checksdetail] ([ma_ph], [stt], [ma_vt], [so_luong1], [tong_tien1], [so_luong2], [tong_tien2], [so_luong3], [tong_tien3], [so_luong4], [tong_tien4], [full_quality], [poor_quality], [loss_quality]) VALUES (3, 2, N'VT004', 1111, 11110, 11110, 11110, 9999, 0, 0, 0, 0, 0, 0)
GO
INSERT [dbo].[employees] ([ma_nv], [ten_nv], [ngay_sinh], [ngay_bd], [gioi_tinh], [muc_luong], [nsd], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'NV001', N'AAA', CAST(N'2019-04-18' AS Date), CAST(N'2022-04-25' AS Date), N'M', 35000000, 3, N'1', CAST(N'2022-04-25T00:29:11.253' AS DateTime), CAST(N'2022-04-25T00:37:09.247' AS DateTime), 1, 1)
GO
INSERT [dbo].[employees] ([ma_nv], [ten_nv], [ngay_sinh], [ngay_bd], [gioi_tinh], [muc_luong], [nsd], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'NV003', N'12D12D', CAST(N'1990-04-25' AS Date), CAST(N'2022-04-25' AS Date), N'F', 30000000, 3, N'1', CAST(N'2022-04-25T00:36:55.620' AS DateTime), CAST(N'2022-04-25T00:37:02.277' AS DateTime), 1, 1)
GO
INSERT [dbo].[employees] ([ma_nv], [ten_nv], [ngay_sinh], [ngay_bd], [gioi_tinh], [muc_luong], [nsd], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'XXXX', N'XXXXX', CAST(N'2022-05-04' AS Date), CAST(N'2022-05-04' AS Date), N' ', 1000000, 4, N'1', CAST(N'2022-05-08T21:14:09.533' AS DateTime), CAST(N'2022-05-08T21:14:09.533' AS DateTime), 1, 1)
GO
INSERT [dbo].[items] ([ma_vt], [ten_vt], [mo_ta], [sl_ton], [gia_ban], [ma_ncc], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'VT002', N'12D12D 2', N'21D12D 2', 1234123, 124124, N'Dell', N'1', CAST(N'2022-04-24T21:23:43.847' AS DateTime), CAST(N'2022-05-04T19:37:17.933' AS DateTime), 1, 1)
GO
INSERT [dbo].[items] ([ma_vt], [ten_vt], [mo_ta], [sl_ton], [gia_ban], [ma_ncc], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'VT004', N'12D12D', N'12D1221', 21211, 1231, N'Apple', N'1', CAST(N'2022-04-24T21:26:20.470' AS DateTime), CAST(N'2022-04-24T21:26:20.470' AS DateTime), 1, 1)
GO
INSERT [dbo].[items] ([ma_vt], [ten_vt], [mo_ta], [sl_ton], [gia_ban], [ma_ncc], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'XXX', N'xxx', N'xxx YYY', 10, 100000, N'XXX', N'1', CAST(N'2022-05-08T20:59:01.910' AS DateTime), CAST(N'2022-05-08T22:31:10.010' AS DateTime), 1, 1)
GO
INSERT [dbo].[items] ([ma_vt], [ten_vt], [mo_ta], [sl_ton], [gia_ban], [ma_ncc], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'YYY', N'YYY', N'YYY', 999, 50000, N'APPLE', N'1', CAST(N'2022-05-08T22:33:37.403' AS DateTime), CAST(N'2022-05-08T22:33:37.403' AS DateTime), 1, 1)
GO
INSERT [dbo].[materials] ([ma_vl], [ten_vl], [ma_ncc], [sl_ton], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'VL001', N'UQDQWD', N'Dell', 12312, N'1', CAST(N'2022-04-24T22:45:45.313' AS DateTime), CAST(N'2022-04-24T22:45:45.313' AS DateTime), 1, 1)
GO
INSERT [dbo].[materials] ([ma_vl], [ten_vl], [ma_ncc], [sl_ton], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'XXX', N'xxxx', N'XXX', 10, N'1', CAST(N'2022-05-08T20:59:27.740' AS DateTime), CAST(N'2022-05-08T20:59:27.740' AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[orders] ON 
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (2, CAST(N'2022-05-05' AS Date), NULL, N'123', N'321', N'123', N'1', 2, 200000, 0, 0, 200000, N'2', CAST(N'2022-05-05T03:04:51.197' AS DateTime), CAST(N'2022-05-05T03:04:51.197' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (4, CAST(N'2022-05-05' AS Date), NULL, N'AAA', N'123', N'321', N'1', 22, 2200000, 0, 0, 2200000, N'2', CAST(N'2022-05-05T18:23:48.290' AS DateTime), CAST(N'2022-05-05T18:23:48.290' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (9, CAST(N'2022-04-25' AS Date), NULL, N'XXXX', N'XXXX', N'AAA 222', N'2', 10, 20, 3440, 44440, 4440, N'0', CAST(N'2022-05-08T15:29:16.980' AS DateTime), CAST(N'2022-05-08T15:30:56.577' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (10, CAST(N'2022-05-08' AS Date), NULL, N'AA', N'2122', N'222', N'1', 1, 100000, 0, 0, 100000, N'2', CAST(N'2022-05-08T15:31:10.777' AS DateTime), CAST(N'2022-05-08T15:31:10.777' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (11, CAST(N'2022-04-25' AS Date), NULL, N'AA', N'SASS', N'AA', N'0', 10, 10, 12210, 12120, 12120, N'0', CAST(N'2022-05-08T15:31:37.420' AS DateTime), CAST(N'2022-05-08T15:31:37.420' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (12, CAST(N'2022-04-25' AS Date), NULL, N'AA', N'SASS', N'AA', N'0', 10, 10, 12210, 12120, 12120, N'0', CAST(N'2022-05-08T15:32:19.090' AS DateTime), CAST(N'2022-05-08T15:32:19.090' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (13, CAST(N'2022-04-25' AS Date), NULL, N'1111', N'222', N'2222', N'0', 12310, 1231240, 4124120, 42140, 12124120, N'0', CAST(N'2022-05-08T15:34:38.237' AS DateTime), CAST(N'2022-05-08T15:34:38.237' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (14, CAST(N'2022-04-25' AS Date), NULL, N'12321', N'2312312', N'', N'2', 22, 22, 22, 22, 22, N'0', CAST(N'2022-05-08T15:44:26.737' AS DateTime), CAST(N'2022-05-08T15:44:26.737' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (15, CAST(N'2022-04-25' AS Date), NULL, N'123', N'321312', N'', N'2', 330, 0, 0, 0, 0, N'0', CAST(N'2022-05-08T15:44:48.580' AS DateTime), CAST(N'2022-05-08T15:44:48.580' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (16, CAST(N'2022-04-25' AS Date), NULL, N'xxxx', N'xxxxx', N'xxxx', N'0', 3, 1012220, 12120, 12120, 1100120, N'1', CAST(N'2022-05-08T21:01:03.673' AS DateTime), CAST(N'2022-05-08T21:48:46.443' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (17, CAST(N'2022-05-08' AS Date), NULL, N'XXX', N'XXX', N'', N'1', 10, 1000000, 0, 0, 1000000, N'2', CAST(N'2022-05-08T21:02:45.363' AS DateTime), CAST(N'2022-05-08T21:02:45.363' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (18, CAST(N'2022-04-25' AS Date), NULL, N'BAN 1', N'BAN 1', N'BAN 1', N'0', 2, 0, 0, 0, 11310, N'2', CAST(N'2022-05-08T21:54:48.270' AS DateTime), CAST(N'2022-05-08T21:54:55.427' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (19, CAST(N'2022-04-25' AS Date), N'XXX', N'YYYY', N'YYYY', N'YYYYY', N'0', 10, 0, 0, 0, 1231230, N'1', CAST(N'2022-05-08T22:24:09.290' AS DateTime), CAST(N'2022-05-08T22:24:09.290' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (20, CAST(N'2022-04-25' AS Date), N'', N'XXXX', N'XXXX', N'XXXX', N'0', 10, 1000000, 100000, 200000, 1100000, N'0', CAST(N'2022-05-08T22:32:40.590' AS DateTime), CAST(N'2022-05-08T22:32:40.590' AS DateTime), 1, 1)
GO
INSERT [dbo].[orders] ([ma_dh], [ngay_lap], [ma_ban], [ten_khach], [sdt_khach], [ghi_chu], [xtype], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (21, CAST(N'2022-04-25' AS Date), N'', N'XXX', N'XXX', N'XXXX', N'0', 1, 50000, 0, 0, 50000, N'0', CAST(N'2022-05-09T21:57:44.957' AS DateTime), CAST(N'2022-05-09T21:57:44.957' AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (0, 1, N'VT002', 10, 10, 12210, 12120, 12120)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (9, 1, N'HUHU', 10, 20, 3440, 44440, 4440)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (13, 1, N'VT002', 12310, 1231240, 4124120, 42140, 12124120)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (14, 1, N'HIC', 22, 22, 22, 22, 22)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (15, 1, N'HIC', 330, 0, 0, 0, 0)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (16, 1, N'VT002', 2, 1000010, 0, 0, 1100000)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (16, 2, N'XXX', 1, 12210, 12120, 12120, 120)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (18, 1, N'VT004', 1, 0, 0, 0, 11110)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (18, 2, N'XXX', 1, 0, 0, 0, 200)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (19, 1, N'XXX', 10, 0, 0, 0, 1231230)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (20, 1, N'XXX', 10, 1000000, 100000, 200000, 1100000)
GO
INSERT [dbo].[ordersdetail] ([ma_dh], [stt], [ma_vt], [so_luong], [tien_hang], [khuyen_mai], [tien_thue], [tong_tien]) VALUES (21, 1, N'YYY', 1, 50000, 0, 0, 50000)
GO
INSERT [dbo].[places] ([ma_khu], [ten_khu], [tinh_trang], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'K001', N'KHU A', N'0', N'1', CAST(N'2022-05-04T20:06:24.260' AS DateTime), CAST(N'2022-05-04T20:06:24.260' AS DateTime), 1, 1)
GO
INSERT [dbo].[places] ([ma_khu], [ten_khu], [tinh_trang], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'K002', N'KHU B', N'0', N'1', CAST(N'2022-05-04T20:06:29.230' AS DateTime), CAST(N'2022-05-04T20:06:29.230' AS DateTime), 1, 1)
GO
INSERT [dbo].[places] ([ma_khu], [ten_khu], [tinh_trang], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'XXX', N'XXXX', N'3', N'1', CAST(N'2022-05-08T21:03:23.953' AS DateTime), CAST(N'2022-05-08T21:03:35.190' AS DateTime), 1, 1)
GO
INSERT [dbo].[providers] ([ma_ncc], [ten_ncc], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'APPLE', N'Apple', N'1', CAST(N'2022-04-24T20:43:55.340' AS DateTime), CAST(N'2022-05-06T22:21:18.893' AS DateTime), 1, 1)
GO
INSERT [dbo].[providers] ([ma_ncc], [ten_ncc], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'Dell', N'Dell', N'1', CAST(N'2022-04-24T20:44:13.197' AS DateTime), CAST(N'2022-04-24T20:44:13.197' AS DateTime), 1, 1)
GO
INSERT [dbo].[providers] ([ma_ncc], [ten_ncc], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'Samsung', N'Samsung', N'1', CAST(N'2022-04-24T20:44:13.197' AS DateTime), CAST(N'2022-04-24T20:44:13.197' AS DateTime), 1, 1)
GO
INSERT [dbo].[providers] ([ma_ncc], [ten_ncc], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'XXX', N'XXX', N'1', CAST(N'2022-05-08T20:58:41.080' AS DateTime), CAST(N'2022-05-08T20:58:41.080' AS DateTime), 1, 1)
GO
INSERT [dbo].[tables] ([ma_ban], [ma_khu], [ten_ban], [size], [tinh_trang], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'B001', N'K001', N'12D12', 10, N'0', N'1', CAST(N'2022-05-04T20:04:17.643' AS DateTime), CAST(N'2022-05-08T22:16:46.807' AS DateTime), 1, 1)
GO
INSERT [dbo].[tables] ([ma_ban], [ma_khu], [ten_ban], [size], [tinh_trang], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (N'XXX', N'K002', N'xxxx', 10, N'3', N'1', CAST(N'2022-05-08T21:01:36.923' AS DateTime), CAST(N'2022-05-08T21:01:41.863' AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[users] ON 
GO
INSERT [dbo].[users] ([id], [username], [full_name], [password], [admin], [manager], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (1, N'ADMIN', N'Quản trị hệ thống', N'2', 1, 1, N'1', CAST(N'2022-04-24T00:32:50.477' AS DateTime), CAST(N'2022-04-24T00:32:50.477' AS DateTime), 1, 1)
GO
INSERT [dbo].[users] ([id], [username], [full_name], [password], [admin], [manager], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (2, N'MANAGER', N'Quản lý', N'2', 0, 1, N'1', CAST(N'2022-04-24T13:55:42.723' AS DateTime), CAST(N'2022-04-24T13:55:42.723' AS DateTime), 1, 1)
GO
INSERT [dbo].[users] ([id], [username], [full_name], [password], [admin], [manager], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (3, N'STAFF', N'Nhân viên', N'2', 0, 0, N'1', CAST(N'2022-04-24T13:55:42.740' AS DateTime), CAST(N'2022-04-24T13:55:42.740' AS DateTime), 1, 1)
GO
INSERT [dbo].[users] ([id], [username], [full_name], [password], [admin], [manager], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (4, N'1111', N'3333', N'2', 0, 0, N'1', CAST(N'2022-05-08T13:02:51.403' AS DateTime), CAST(N'2022-05-08T13:02:57.530' AS DateTime), 1, 1)
GO
INSERT [dbo].[users] ([id], [username], [full_name], [password], [admin], [manager], [trang_thai], [ngay_tao], [ngay_sua], [nguoi_tao], [nguoi_sua]) VALUES (5, N'XXX', N'XXXXX YYYY', N'2', 0, 0, N'1', CAST(N'2022-05-08T21:14:40.517' AS DateTime), CAST(N'2022-05-08T21:14:40.517' AS DateTime), 1, 1)
GO
SET IDENTITY_INSERT [dbo].[users] OFF
GO
