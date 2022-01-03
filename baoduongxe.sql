USE [master]
GO
/****** Object:  Database [baoduongxe]    Script Date: 1/3/2022 3:46:51 PM ******/
CREATE DATABASE [baoduongxe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'baoduongxe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\baoduongxe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'baoduongxe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\baoduongxe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [baoduongxe] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [baoduongxe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [baoduongxe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [baoduongxe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [baoduongxe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [baoduongxe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [baoduongxe] SET ARITHABORT OFF 
GO
ALTER DATABASE [baoduongxe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [baoduongxe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [baoduongxe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [baoduongxe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [baoduongxe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [baoduongxe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [baoduongxe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [baoduongxe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [baoduongxe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [baoduongxe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [baoduongxe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [baoduongxe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [baoduongxe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [baoduongxe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [baoduongxe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [baoduongxe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [baoduongxe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [baoduongxe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [baoduongxe] SET  MULTI_USER 
GO
ALTER DATABASE [baoduongxe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [baoduongxe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [baoduongxe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [baoduongxe] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [baoduongxe] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [baoduongxe] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [baoduongxe] SET QUERY_STORE = OFF
GO
USE [baoduongxe]
GO
/****** Object:  Table [dbo].[BAODUONG]    Script Date: 1/3/2022 3:46:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAODUONG](
	[MABD] [varchar](20) NOT NULL,
	[NGAYGIONHAN] [varchar](40) NULL,
	[NGAYGIOTRA] [varchar](40) NULL,
	[SOKM] [int] NULL,
	[NOIDUNG] [varchar](50) NULL,
	[SOXE] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MABD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONGVIEC]    Script Date: 1/3/2022 3:46:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONGVIEC](
	[MACV] [varchar](40) NOT NULL,
	[TENCV] [nvarchar](40) NOT NULL,
	[DONGIA] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MACV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_BD]    Script Date: 1/3/2022 3:46:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_BD](
	[MABD] [varchar](20) NOT NULL,
	[MACV] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MABD] ASC,
	[MACV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 1/3/2022 3:46:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [varchar](20) NOT NULL,
	[TENKH] [varchar](40) NOT NULL,
	[DIACHI] [varchar](50) NULL,
	[SDT] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XE]    Script Date: 1/3/2022 3:46:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XE](
	[SOXE] [varchar](20) NOT NULL,
	[HANGXE] [varchar](40) NOT NULL,
	[NAMSX] [varchar](10) NULL,
	[MAKH] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SOXE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BAODUONG] ([MABD], [NGAYGIONHAN], [NGAYGIOTRA], [SOKM], [NOIDUNG], [SOXE]) VALUES (N'BD001', N'2021-12-30', N'2022-01-03', 20000, N'gà vl', N'MNXX001')
INSERT [dbo].[BAODUONG] ([MABD], [NGAYGIONHAN], [NGAYGIOTRA], [SOKM], [NOIDUNG], [SOXE]) VALUES (N'BD002', N'2021-12-30', N'2022-01-05', 20000, N'scam vl', N'MNXX002')
GO
INSERT [dbo].[CONGVIEC] ([MACV], [TENCV], [DONGIA]) VALUES (N'CV001', N'Thay nh?t', 200000)
INSERT [dbo].[CONGVIEC] ([MACV], [TENCV], [DONGIA]) VALUES (N'CV002', N'Thay th?ng', 200000)
INSERT [dbo].[CONGVIEC] ([MACV], [TENCV], [DONGIA]) VALUES (N'CV003', N'Ki?m tra v?', 100000)
INSERT [dbo].[CONGVIEC] ([MACV], [TENCV], [DONGIA]) VALUES (N'cv1', N'suaxe', 990000)
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT]) VALUES (N'KH001', N'khoa', N'd?a ch? gì dó ? dây k ', N'0336773624')
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [DIACHI], [SDT]) VALUES (N'KH002', N'long', N'ko co dia chi', N'0333777222')
GO
INSERT [dbo].[XE] ([SOXE], [HANGXE], [NAMSX], [MAKH]) VALUES (N'MNXX001', N'Toyota', N'2021', N'KH001')
INSERT [dbo].[XE] ([SOXE], [HANGXE], [NAMSX], [MAKH]) VALUES (N'MNXX002', N'Toyota', N'2021', N'KH002')
GO
ALTER TABLE [dbo].[BAODUONG]  WITH CHECK ADD  CONSTRAINT [FK_SOXE] FOREIGN KEY([SOXE])
REFERENCES [dbo].[XE] ([SOXE])
GO
ALTER TABLE [dbo].[BAODUONG] CHECK CONSTRAINT [FK_SOXE]
GO
ALTER TABLE [dbo].[CT_BD]  WITH CHECK ADD  CONSTRAINT [FK_MABD] FOREIGN KEY([MABD])
REFERENCES [dbo].[BAODUONG] ([MABD])
GO
ALTER TABLE [dbo].[CT_BD] CHECK CONSTRAINT [FK_MABD]
GO
ALTER TABLE [dbo].[CT_BD]  WITH CHECK ADD  CONSTRAINT [FK_MACV] FOREIGN KEY([MACV])
REFERENCES [dbo].[CONGVIEC] ([MACV])
GO
ALTER TABLE [dbo].[CT_BD] CHECK CONSTRAINT [FK_MACV]
GO
ALTER TABLE [dbo].[XE]  WITH CHECK ADD  CONSTRAINT [FK_MAKH] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[XE] CHECK CONSTRAINT [FK_MAKH]
GO
USE [master]
GO
ALTER DATABASE [baoduongxe] SET  READ_WRITE 
GO
