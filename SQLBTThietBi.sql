USE [chungcu]
GO
/****** Object:  Table [dbo].[canho]    Script Date: 1/1/2022 9:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[canho](
	[MaCanHo] [nvarchar](20) NOT NULL,
	[TenChuHo] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCanHo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 1/1/2022 9:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[MaNhanVien] [nvarchar](20) NOT NULL,
	[TenNhanVien] [nvarchar](50) NOT NULL,
	[SoDienThoai] [varchar](12) NULL,
	[GioiTinh] [int] NOT NULL,
 CONSTRAINT [PK__nhanvien__77B2CA47A98D1846] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NV_BT]    Script Date: 1/1/2022 9:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NV_BT](
	[MaNhanVien] [nvarchar](20) NOT NULL,
	[MaThietBi] [nvarchar](20) NOT NULL,
	[MaCanHo] [nvarchar](20) NOT NULL,
	[LanThu] [int] NOT NULL,
	[NgayBaoTri] [smalldatetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[thietbi]    Script Date: 1/1/2022 9:07:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[thietbi](
	[MaThietBi] [nvarchar](20) NOT NULL,
	[TenThietBi] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThietBi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NV_BT]  WITH CHECK ADD  CONSTRAINT [fk_canho_nvbt] FOREIGN KEY([MaCanHo])
REFERENCES [dbo].[canho] ([MaCanHo])
GO
ALTER TABLE [dbo].[NV_BT] CHECK CONSTRAINT [fk_canho_nvbt]
GO
ALTER TABLE [dbo].[NV_BT]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien_nvbt] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[nhanvien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[NV_BT] CHECK CONSTRAINT [fk_nhanvien_nvbt]
GO
ALTER TABLE [dbo].[NV_BT]  WITH CHECK ADD  CONSTRAINT [fk_thietbi_nvbt] FOREIGN KEY([MaThietBi])
REFERENCES [dbo].[thietbi] ([MaThietBi])
GO
ALTER TABLE [dbo].[NV_BT] CHECK CONSTRAINT [fk_thietbi_nvbt]
GO
