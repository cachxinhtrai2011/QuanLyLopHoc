USE [master]
GO
/****** Object:  Database [MamNonBK]    Script Date: 22/11/2019 11:43:58 CH ******/
CREATE DATABASE [MamNonBK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MamNonBK', FILENAME = N'D:\Software\SQL Server 2014\MSSQL12.MSSQLSERVER\MSSQL\DATA\MamNonBK.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MamNonBK_log', FILENAME = N'D:\Software\SQL Server 2014\MSSQL12.MSSQLSERVER\MSSQL\DATA\MamNonBK_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MamNonBK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MamNonBK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MamNonBK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MamNonBK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MamNonBK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MamNonBK] SET ARITHABORT OFF 
GO
ALTER DATABASE [MamNonBK] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MamNonBK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MamNonBK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MamNonBK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MamNonBK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MamNonBK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MamNonBK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MamNonBK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MamNonBK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MamNonBK] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MamNonBK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MamNonBK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MamNonBK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MamNonBK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MamNonBK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MamNonBK] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MamNonBK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MamNonBK] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MamNonBK] SET  MULTI_USER 
GO
ALTER DATABASE [MamNonBK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MamNonBK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MamNonBK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MamNonBK] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MamNonBK', N'ON'
GO
USE [MamNonBK]
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDCLB]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDCLB]()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaCLB) FROM CLB) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaCLB, 3)) FROM CLB
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'CLB00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'CLB0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDGV]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDGV]()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaGV) FROM GiaoVu) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaGV, 3)) FROM GiaoVu
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'GV00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'GV0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDHD]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDHD]()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaHD) FROM HoaDon) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHD, 3)) FROM HoaDon
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDHS]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDHS]()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaHS) FROM HocSinh) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHS, 3)) FROM HocSinh
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HS00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HS0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDLOPDANGKY]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDLOPDANGKY]()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaLopDangKy) FROM LopDangKy) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaLopDangKy, 3)) FROM LopDangKy
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'LDK00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'LDK0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_IDLopHanhChinh]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_IDLopHanhChinh]()
RETURNS VARCHAR(6)
AS
BEGIN
	DECLARE @ID VARCHAR(6)
	IF (SELECT COUNT(MaLopHC) FROM LopHanhChinh) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaLopHC, 3)) FROM LopHanhChinh
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'LHC00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'LHC0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

GO
/****** Object:  Table [dbo].[CLB]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CLB](
	[MaCLB] [varchar](6) NOT NULL,
	[TenCLB] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCLB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DangKyHoc]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DangKyHoc](
	[LopDangKy] [varchar](6) NOT NULL,
	[HoaDon] [varchar](5) NOT NULL,
	[NgayDangKy] [datetime] NOT NULL,
 CONSTRAINT [PK_DangKyHoc] PRIMARY KEY CLUSTERED 
(
	[LopDangKy] ASC,
	[HoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiaoVu]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVu](
	[MaGV] [varchar](5) NOT NULL,
	[TenGiaoVu] [nvarchar](255) NOT NULL,
	[TaiKhoan] [varchar](255) NOT NULL,
	[MatKhau] [varchar](255) NOT NULL,
	[Email] [varchar](255) NOT NULL,
	[DienThoai] [varchar](16) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](5) NOT NULL,
	[XuLy] [varchar](5) NOT NULL,
	[TinhTrang] [bit] NOT NULL,
	[HocSinh] [varchar](5) NOT NULL,
	[NgayTao] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [varchar](5) NOT NULL,
	[TenHS] [nvarchar](255) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[NgayNhapHoc] [datetime] NULL,
	[TenChaMe] [nvarchar](255) NOT NULL,
	[SDTChaMe] [varchar](16) NOT NULL,
	[DiaChi] [nvarchar](255) NULL,
	[LopHC] [varchar](6) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LopDangKy]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopDangKy](
	[MaLopDangKy] [varchar](6) NOT NULL,
	[TenLopDangKy] [nvarchar](255) NOT NULL,
	[CLB] [varchar](6) NOT NULL,
	[NamHoc] [varchar](4) NOT NULL,
	[HocPhi] [decimal](7, 3) NOT NULL,
	[LichHoc] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLopDangKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LopHanhChinh]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopHanhChinh](
	[MaLopHC] [varchar](6) NOT NULL,
	[TenLopHC] [nvarchar](255) NOT NULL,
	[NienKhoa] [varchar](9) NULL,
	[TenGiaoVienChuNhiem] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLopHC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CLB] ([MaCLB], [TenCLB]) VALUES (N'CLB001', N'Nhạc Nghệ')
INSERT [dbo].[CLB] ([MaCLB], [TenCLB]) VALUES (N'CLB002', N'Tiếng Anh')
INSERT [dbo].[CLB] ([MaCLB], [TenCLB]) VALUES (N'CLB003', N'Vẽ')
INSERT [dbo].[CLB] ([MaCLB], [TenCLB]) VALUES (N'CLB004', N'Sáng Tạo')
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD002', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD004', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD006', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD009', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD010', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD011', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD013', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD015', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD017', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD018', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD019', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD020', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD027', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD028', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD032', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD035', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD037', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD040', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD044', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD046', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD047', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD049', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD050', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD051', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD052', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD055', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD061', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD065', CAST(N'2019-11-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD067', CAST(N'2019-11-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD068', CAST(N'2019-11-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD070', CAST(N'2019-11-08 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK001', N'HD073', CAST(N'2019-11-11 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD003', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD004', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD010', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD013', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD017', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD018', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD019', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD021', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD040', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD043', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD044', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD046', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK002', N'HD056', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD001', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD005', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD006', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD007', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD008', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD012', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD015', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD016', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD023', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD024', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD026', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD027', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD028', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD029', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD032', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD034', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD035', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD037', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD038', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD039', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD042', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD045', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD048', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD050', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD051', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD052', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD057', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD058', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD059', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD060', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD062', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD063', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD064', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD070', CAST(N'2019-11-08 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD071', CAST(N'2019-11-08 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK003', N'HD073', CAST(N'2019-11-11 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD001', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD002', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD003', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD007', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD008', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD012', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD013', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD014', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD022', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD023', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD024', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD025', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD031', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD032', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD034', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD036', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD039', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD041', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD043', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD047', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD048', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD049', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD051', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD053', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD054', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD056', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD058', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD059', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD061', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD062', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD063', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD064', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD069', CAST(N'2019-11-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD071', CAST(N'2019-11-08 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK004', N'HD072', CAST(N'2019-11-08 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD001', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD003', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD005', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD007', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD013', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD014', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD015', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD016', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD018', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD022', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD023', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD025', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD026', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD029', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD030', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD031', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD032', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD036', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD038', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD041', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD042', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD043', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD044', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD045', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD047', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD048', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD049', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD051', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD053', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD054', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD055', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD057', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD059', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD060', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD061', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD062', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD064', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK005', N'HD074', CAST(N'2019-11-22 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD002', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD003', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD008', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD010', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD014', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD015', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD017', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD021', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD022', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD025', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD026', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD029', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD030', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD034', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD036', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD038', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD041', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD043', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD045', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD046', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD049', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD053', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD054', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD055', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD058', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD065', CAST(N'2019-11-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK006', N'HD074', CAST(N'2019-11-22 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK007', N'HD016', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK007', N'HD027', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK007', N'HD028', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK007', N'HD033', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK007', N'HD037', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK007', N'HD052', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK007', N'HD057', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD001', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD004', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD009', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD011', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD013', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD016', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD018', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD019', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD023', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD024', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD027', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD028', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD033', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD035', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD037', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD039', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD040', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD047', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD048', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD050', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD052', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD061', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD062', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK008', N'HD063', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD004', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD006', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD009', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD010', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD011', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD017', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD018', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD019', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD021', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD030', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD035', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD040', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD044', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD046', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD050', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD065', CAST(N'2019-11-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK009', N'HD074', CAST(N'2019-11-22 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD001', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD003', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD005', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD008', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD012', CAST(N'2019-07-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD024', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD029', CAST(N'2019-08-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD033', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD034', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD039', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD042', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD043', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD045', CAST(N'2019-09-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD056', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD057', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD060', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[DangKyHoc] ([LopDangKy], [HoaDon], [NgayDangKy]) VALUES (N'LDK010', N'HD063', CAST(N'2019-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[GiaoVu] ([MaGV], [TenGiaoVu], [TaiKhoan], [MatKhau], [Email], [DienThoai]) VALUES (N'GV001', N'Trần Ngọc Nam', N'namnntt', N'qq5f8yfL9OA=', N'namnntt@gmail.com', N'0339582455')
INSERT [dbo].[GiaoVu] ([MaGV], [TenGiaoVu], [TaiKhoan], [MatKhau], [Email], [DienThoai]) VALUES (N'GV002', N'Nguyễn Văn Bắc', N'bacnt', N'po+8pLUbpMrgZKXCF/hKkw==', N'bacthao@gmail.com', N'0339514421')
INSERT [dbo].[GiaoVu] ([MaGV], [TenGiaoVu], [TaiKhoan], [MatKhau], [Email], [DienThoai]) VALUES (N'GV003', N'Đỗ văn Tùng', N'lydogi', N'CSuW73mQV62x/x3kzhdCEA==', N'tungnguyen@hotmail.com', N'0374512411')
INSERT [dbo].[GiaoVu] ([MaGV], [TenGiaoVu], [TaiKhoan], [MatKhau], [Email], [DienThoai]) VALUES (N'GV004', N'Nguyễn Quốc Hòa', N'qhoant', N'FHs/CcCtKt7UEQ8j7CR/DQ==', N'qhoant@gmail.com', N'0335323141')
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD001', N'GV001', 0, N'HS004', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD002', N'GV001', 0, N'HS007', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD003', N'GV001', 0, N'HS005', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD004', N'GV001', 0, N'HS002', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD005', N'GV001', 0, N'HS003', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD006', N'GV001', 0, N'HS006', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD007', N'GV001', 0, N'HS001', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD008', N'GV001', 0, N'HS013', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD009', N'GV001', 0, N'HS011', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD010', N'GV001', 0, N'HS009', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD011', N'GV001', 0, N'HS015', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD012', N'GV001', 0, N'HS014', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD013', N'GV001', 0, N'HS010', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD014', N'GV001', 0, N'HS008', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD015', N'GV001', 0, N'HS020', CAST(N'2019-07-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD016', N'GV001', 0, N'HS005', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD017', N'GV001', 0, N'HS002', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD018', N'GV001', 0, N'HS004', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD019', N'GV001', 0, N'HS007', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD020', N'GV001', 0, N'HS003', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD021', N'GV001', 0, N'HS006', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD022', N'GV001', 0, N'HS018', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD023', N'GV001', 0, N'HS020', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD024', N'GV001', 0, N'HS019', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD025', N'GV001', 0, N'HS015', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD026', N'GV001', 0, N'HS011', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD027', N'GV001', 0, N'HS009', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD028', N'GV001', 0, N'HS008', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD029', N'GV001', 0, N'HS017', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD030', N'GV001', 0, N'HS013', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD031', N'GV001', 0, N'HS012', CAST(N'2019-08-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD032', N'GV001', 0, N'HS005', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD033', N'GV001', 0, N'HS003', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD034', N'GV001', 0, N'HS004', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD035', N'GV001', 0, N'HS001', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD036', N'GV001', 0, N'HS015', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD037', N'GV001', 0, N'HS009', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD038', N'GV001', 0, N'HS011', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD039', N'GV001', 0, N'HS019', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD040', N'GV001', 0, N'HS007', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD041', N'GV001', 0, N'HS013', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD042', N'GV001', 0, N'HS010', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD043', N'GV001', 0, N'HS008', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD044', N'GV001', 0, N'HS018', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD045', N'GV001', 0, N'HS017', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD046', N'GV001', 0, N'HS002', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD047', N'GV001', 0, N'HS014', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD048', N'GV001', 0, N'HS020', CAST(N'2019-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD049', N'GV001', 0, N'HS003', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD050', N'GV001', 0, N'HS001', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD051', N'GV001', 0, N'HS005', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD052', N'GV001', 0, N'HS009', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD053', N'GV001', 0, N'HS013', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD054', N'GV001', 0, N'HS015', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD055', N'GV001', 0, N'HS006', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD056', N'GV001', 0, N'HS011', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD057', N'GV001', 0, N'HS007', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD058', N'GV001', 0, N'HS004', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD059', N'GV001', 0, N'HS002', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD060', N'GV001', 0, N'HS010', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD061', N'GV001', 0, N'HS014', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD062', N'GV001', 0, N'HS020', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD063', N'GV001', 0, N'HS018', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD064', N'GV001', 0, N'HS017', CAST(N'2019-10-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD065', N'GV001', 1, N'HS003', CAST(N'2019-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD067', N'GV001', 1, N'HS016', CAST(N'2019-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD068', N'GV001', 0, N'HS012', CAST(N'2019-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD069', N'GV001', 0, N'HS008', CAST(N'2019-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD070', N'GV001', 1, N'HS002', CAST(N'2019-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD071', N'GV001', 0, N'HS001', CAST(N'2019-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD072', N'GV001', 1, N'HS004', CAST(N'2019-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD073', N'GV001', 0, N'HS007', CAST(N'2019-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HoaDon] ([MaHD], [XuLy], [TinhTrang], [HocSinh], [NgayTao]) VALUES (N'HD074', N'GV001', 1, N'HS005', CAST(N'2019-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS001', N'Đỗ Thùy Trang', CAST(N'2015-11-07 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:04:39.013' AS DateTime), N'Đỗ văn Bắc', N'0948541254', N'25 Đường Láng Hà Nội', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS002', N'Nguyễn Văn Tiến', CAST(N'2015-08-12 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:05:38.000' AS DateTime), N'Ngô thị Thùy Dung', N'0339556231', N'63 Lò Đúc', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS003', N'Mai thị Hương', CAST(N'2015-03-16 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:06:42.177' AS DateTime), N'Mai Xuân Thắng', N'0952241211', N'96 Thanh Xuân Hà Nội', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS004', N'Nguyễn Thảo Trang', CAST(N'2015-10-26 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:07:55.783' AS DateTime), N'Trần thị Thảo', N'0944125412', N'63 Định Công Thanh Xuân hà Nội', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS005', N'Nguyễn Thùy Dương', CAST(N'2015-11-23 00:00:00.000' AS DateTime), CAST(N'2019-11-23 20:20:22.150' AS DateTime), N'Nguyễn Sơn tùng', N'0945125541', N'63 Đê la Thành Hà Nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS006', N'Nguyễn thị Hồng', CAST(N'2015-01-07 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:21:28.320' AS DateTime), N'Nguyễn văn Bắc', N'0974451252', N'Số nhà 14 Đường Nhổn Hà Nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS007', N'Văn Thị Thanh', CAST(N'2015-11-07 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:30:06.380' AS DateTime), N'Văn Tuấn', N'0382623142', N'25 Nhổn Từ Liêm Hà Nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS008', N'Đỗ thị Thúy hằng', CAST(N'2015-05-09 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:31:27.397' AS DateTime), N'Hồ thị Thanh Thúy', N'0985221241', N'Ngách 12 Số nhà 52 Quận Nam Từ liêm hà Nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS009', N'Đào thị Trang Nhung', CAST(N'2015-11-22 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:32:57.890' AS DateTime), N'Đạo Anh Tuấn', N'0352145212', N'Số 14 Tòa nhà Hashinco chung cư Linh Đàm Hà Nội', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS010', N'Võ thị Thanh Huyền', CAST(N'2015-12-22 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:35:48.113' AS DateTime), N'Võ Thái Thanh Sơn', N'0915223141', N'118 Nguyễn An Ninh Hà nội', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS011', N'Mai Tiến Tùng', CAST(N'2015-11-07 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:37:30.400' AS DateTime), N'Mai Thi Thanh Sơn', N'0332541254', N'112 Phía bắc tòa nhà CT12 khu chung cư thái sơn Hà Nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS012', N'Trần Xuân Mạnh', CAST(N'2015-11-07 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:38:51.873' AS DateTime), N'Trần Văn Tuấn', N'0952214336', N'Ngõ 15 Quận Thanh xuân hà nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS013', N'Nguyễn thị Ngân', CAST(N'2015-11-07 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:41:10.947' AS DateTime), N'Nguyễn Thanh Sơn', N'0911542251', N'91 Cầu giấy Hà Nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS014', N'Nguyễn Thanh Thanh Tùng', CAST(N'2015-05-25 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:43:07.820' AS DateTime), N'Nguyễn thị Trang', N'0932142512', N'63 Kim Mã hà nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS015', N'Đỗ thị Hồng Thơm', CAST(N'2015-11-12 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:44:25.187' AS DateTime), N'Đỗ thị Sơn', N'0974541122', N'12 Láng Hạ Hà Nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS016', N'Nguyễn Thanh Thanh Cúc', CAST(N'2015-11-07 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:45:58.177' AS DateTime), N'Nguyễn sơn Tùng', N'0915421241', N'22 Trung Kính, Trung Hoà, Cầu Giấy, Hà Nội', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS017', N'Ngộ thị Hồng', CAST(N'2015-01-12 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:47:28.873' AS DateTime), N'Ngô Thanh Tùng', N'0915223141', N'19A Nguyễn Thiện Thuật, Đồng Xuân, Hoàn Kiếm, Hà Nội', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS018', N'Chu Thiện trí', CAST(N'2015-08-17 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:48:41.237' AS DateTime), N'Chu Thiện Tùng', N'0915223122', N'33 Ngõ Giếng, Chợ Dừa, Đống Đa, Hà Nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS019', N'Trần thanh thanh Nam', CAST(N'2015-11-14 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:49:47.490' AS DateTime), N'Trần Thanh Sơn', N'0332451255', N'Tập thể nhà A8,, Phố Nam Đồng, Nam Đồng, Đống Đa, Hà Nội', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS020', N'Nguyễn Thành Nam', CAST(N'2015-01-22 00:00:00.000' AS DateTime), CAST(N'2019-11-07 20:50:51.947' AS DateTime), N'Nguyễn Thanh Thanh', N'0952315124', N'Kim Liên, Đống Đa, Hà Nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS021', N'Đỗ bảo trâm', CAST(N'2015-12-12 00:00:00.000' AS DateTime), CAST(N'2019-11-08 09:21:44.783' AS DateTime), N'Nguyễn thị thanh Sơn', N'0973114525', N'21 Nguyễn thị Minh Khai', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS022', N'Nguyễn Văn Hậu', CAST(N'2015-07-08 00:00:00.000' AS DateTime), CAST(N'2019-11-08 09:21:44.800' AS DateTime), N'Nguyễn Anh tú', N'0984200652', N'211 Nguyễn An Ninh', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS023', N'Đỗ thị Sơn', CAST(N'2015-07-14 00:00:00.000' AS DateTime), CAST(N'2019-11-08 09:21:44.800' AS DateTime), N'Nguyễn thị Thu Hằng', N'0339112411', N'khu Đô thị Hashinco ', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS024', N'Văn Sơn hào', CAST(N'2015-07-17 00:00:00.000' AS DateTime), CAST(N'2019-11-08 09:21:44.800' AS DateTime), N'Văn Hào Sinh', N'0988544123', N'96 Định công Thanh xuân Hà nội', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS025', N'Đỗ thị thảo mai', CAST(N'2015-08-12 00:00:00.000' AS DateTime), CAST(N'2019-11-08 09:21:44.800' AS DateTime), N'Đỗ văn Nghị', N'0322141241', N'Thanh hóa', N'LHC001')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS026', N'Đỗ bảo trâm', CAST(N'2015-12-12 00:00:00.000' AS DateTime), CAST(N'2019-11-22 14:23:04.837' AS DateTime), N'Nguyễn thị thanh Sơn', N'0973114525', N'21 Nguyễn thị Minh Khai', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS027', N'Nguyễn Văn Hậu', CAST(N'2015-07-08 00:00:00.000' AS DateTime), CAST(N'2019-11-22 14:23:04.847' AS DateTime), N'Nguyễn Anh tú', N'0984200652', N'211 Nguyễn An Ninh', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS028', N'Đỗ thị Sơn', CAST(N'2015-07-14 00:00:00.000' AS DateTime), CAST(N'2019-11-22 14:23:04.850' AS DateTime), N'Nguyễn thị Thu Hằng', N'0339112411', N'khu Đô thị Hashinco ', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS029', N'Văn Sơn hào', CAST(N'2015-07-17 00:00:00.000' AS DateTime), CAST(N'2019-11-22 14:23:04.850' AS DateTime), N'Văn Hào Sinh', N'0988544123', N'96 Định công Thanh xuân Hà nội', N'LHC002')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [NgayNhapHoc], [TenChaMe], [SDTChaMe], [DiaChi], [LopHC]) VALUES (N'HS030', N'Đỗ thị thảo mai', CAST(N'2015-08-12 00:00:00.000' AS DateTime), CAST(N'2019-11-22 14:23:04.850' AS DateTime), N'Đỗ văn Nghị', N'0322141241', N'Thanh hóa', N'LHC002')
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK001', N'Đàn Organ', N'CLB001', N'2019', CAST(650.000 AS Decimal(7, 3)), 2)
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK002', N'Đàn Piano', N'CLB001', N'2019', CAST(600.000 AS Decimal(7, 3)), 3)
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK003', N'Sáo truyền Thống', N'CLB001', N'2019', CAST(470.000 AS Decimal(7, 3)), 3)
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK004', N'Học Hát Tiếng Anh', N'CLB002', N'2019', CAST(520.000 AS Decimal(7, 3)), 4)
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK005', N'Học Toán bằng Tiếng Anh', N'CLB002', N'2019', CAST(630.000 AS Decimal(7, 3)), 5)
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK006', N'Vẽ máy tính', N'CLB003', N'2019', CAST(633.000 AS Decimal(7, 3)), 6)
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK007', N'Vẽ máy tính', N'CLB003', N'2019', CAST(633.000 AS Decimal(7, 3)), 4)
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK008', N'Sáng tạo Đồ Handmade', N'CLB004', N'2019', CAST(320.000 AS Decimal(7, 3)), 6)
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK009', N'Sáng Tạo Lập Trình', N'CLB004', N'2019', CAST(321.000 AS Decimal(7, 3)), 4)
INSERT [dbo].[LopDangKy] ([MaLopDangKy], [TenLopDangKy], [CLB], [NamHoc], [HocPhi], [LichHoc]) VALUES (N'LDK010', N'Sáng Tạo Lập Trình', N'CLB004', N'2019', CAST(321.000 AS Decimal(7, 3)), 2)
INSERT [dbo].[LopHanhChinh] ([MaLopHC], [TenLopHC], [NienKhoa], [TenGiaoVienChuNhiem]) VALUES (N'LHC001', N'Ban Mai', N'2019-2021', N'Nguyễn Văn nam')
INSERT [dbo].[LopHanhChinh] ([MaLopHC], [TenLopHC], [NienKhoa], [TenGiaoVienChuNhiem]) VALUES (N'LHC002', N'Hoa Cúc', N'2019-2021', N'Đỗ Văn Bảo')
ALTER TABLE [dbo].[CLB] ADD  DEFAULT ([dbo].[AUTO_IDCLB]()) FOR [MaCLB]
GO
ALTER TABLE [dbo].[DangKyHoc] ADD  CONSTRAINT [DF__DangKyHoc__NgayD__398D8EEE]  DEFAULT (CONVERT([varchar](10),getdate(),(101))) FOR [NgayDangKy]
GO
ALTER TABLE [dbo].[GiaoVu] ADD  DEFAULT ([dbo].[AUTO_IDGV]()) FOR [MaGV]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ([dbo].[AUTO_IDHD]()) FOR [MaHD]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ('GV001') FOR [XuLy]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF__HoaDon__TinhTran__2B3F6F97]  DEFAULT ((0)) FOR [TinhTrang]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[HocSinh] ADD  DEFAULT ([dbo].[AUTO_IDHS]()) FOR [MaHS]
GO
ALTER TABLE [dbo].[HocSinh] ADD  CONSTRAINT [DF__HocSinh__NgayNha__164452B1]  DEFAULT (getdate()) FOR [NgayNhapHoc]
GO
ALTER TABLE [dbo].[LopDangKy] ADD  DEFAULT ([dbo].[AUTO_IDLOPDANGKY]()) FOR [MaLopDangKy]
GO
ALTER TABLE [dbo].[LopDangKy] ADD  DEFAULT ('2019') FOR [NamHoc]
GO
ALTER TABLE [dbo].[LopHanhChinh] ADD  DEFAULT ([dbo].[AUTO_IDLopHanhChinh]()) FOR [MaLopHC]
GO
ALTER TABLE [dbo].[DangKyHoc]  WITH CHECK ADD  CONSTRAINT [FK_DangKyHoc_HoaDon] FOREIGN KEY([HoaDon])
REFERENCES [dbo].[HoaDon] ([MaHD])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKyHoc] CHECK CONSTRAINT [FK_DangKyHoc_HoaDon]
GO
ALTER TABLE [dbo].[DangKyHoc]  WITH CHECK ADD  CONSTRAINT [FK_DangKyHoc_LopDangKy] FOREIGN KEY([LopDangKy])
REFERENCES [dbo].[LopDangKy] ([MaLopDangKy])
GO
ALTER TABLE [dbo].[DangKyHoc] CHECK CONSTRAINT [FK_DangKyHoc_LopDangKy]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_GiaoVu] FOREIGN KEY([XuLy])
REFERENCES [dbo].[GiaoVu] ([MaGV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_GiaoVu]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_HocSinh] FOREIGN KEY([HocSinh])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_HocSinh]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_LopHanhChinh] FOREIGN KEY([LopHC])
REFERENCES [dbo].[LopHanhChinh] ([MaLopHC])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_LopHanhChinh]
GO
ALTER TABLE [dbo].[LopDangKy]  WITH CHECK ADD  CONSTRAINT [FK_LopDangKy_CLB] FOREIGN KEY([CLB])
REFERENCES [dbo].[CLB] ([MaCLB])
GO
ALTER TABLE [dbo].[LopDangKy] CHECK CONSTRAINT [FK_LopDangKy_CLB]
GO
ALTER TABLE [dbo].[LopDangKy]  WITH CHECK ADD CHECK  (([LichHoc]<=(7) AND [LichHoc]>=(2)))
GO
/****** Object:  StoredProcedure [dbo].[CapNhatTTLopHC]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CapNhatTTLopHC]
@MaLopHC VARCHAR(6),
@TenLopHC NVARCHAR(255),
@NienKhoa varchar(9),
@TenGiaoVienCN NVARCHAR(255)
AS
BEGIN
	UPDATE dbo.LopHanhChinh SET TenLopHC = @TenLopHC, NienKhoa = @NienKhoa, TenGiaoVienChuNhiem = @TenGiaoVienCN
	WHERE MaLopHC = @MaLopHC
END


GO
/****** Object:  StoredProcedure [dbo].[DangKyHocProc]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DangKyHocProc]
@LopDK VARCHAR(6),
@HocSinh VARCHAR(5)
AS 
BEGIN
	DECLARE @HoaDonHS VARCHAR(5)
	SELECT TOP 1 @HoaDonHS = MaHD FROM dbo.HoaDon
	WHERE dbo.HoaDon.HocSinh = @HocSinh
	ORDER BY dbo.HoaDon.NgayTao DESC
	INSERT INTO dbo.DangKyHoc
	        ( LopDangKy, HoaDon, NgayDangKy )
	VALUES  ( @LopDK, -- LopDangKy - varchar(6)
	          @HoaDonHS, -- HoaDon - varchar(5)
	          DEFAULT  -- NgayDangKy - datetime
	          )
END


GO
/****** Object:  StoredProcedure [dbo].[DoiMatKhau]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DoiMatKhau]
@MaGV VARCHAR(5),
@MatKhauMoi VARCHAR(255)
AS
BEGIN
	UPDATE dbo.GiaoVu 
	SET MatKhau = @MatKhauMoi
	WHERE MaGV = @MaGV
END


GO
/****** Object:  StoredProcedure [dbo].[HuyDangKyHoc]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[HuyDangKyHoc]
@MaHocSinh VARCHAR(5),
@LopDangKy VARCHAR(6)
AS
BEGIN
	--DECLARE @Thang INT
	--DECLARE @Nam INT
	--SELECT @Thang = MONTH(dbo.DangKyHoc.NgayDangKy), @Nam = YEAR(dbo.DangKyHoc.NgayDangKy) FROM dbo.DangKyHoc
	--INNER JOIN dbo.HoaDon ON dbo.HoaDon.MaHD = dbo.DangKyHoc.HoaDon
	--INNER JOIN dbo.HocSinh ON dbo.HoaDon.HocSinh = dbo.HocSinh.MaHS
	
	DELETE dbo.DangKyHoc FROM dbo.DangKyHoc
	INNER JOIN dbo.HoaDon ON dbo.HoaDon.MaHD = dbo.DangKyHoc.HoaDon
	INNER JOIN dbo.HocSinh ON dbo.HoaDon.HocSinh = dbo.HocSinh.MaHS
	WHERE @MaHocSinh = dbo.HocSinh.MaHS AND @LopDangKy = dbo.DangKyHoc.LopDangKy AND MONTH(HoaDon.NgayTao) = MONTH(GETDATE()) AND YEAR(HoaDon.NgayTao) = YEAR(GETDATE())
END



GO
/****** Object:  StoredProcedure [dbo].[InsertHoaDon]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertHoaDon]
@MaHocSinh VARCHAR(5)


AS
BEGIN
	DECLARE @NgayLapHoaDon DATETIME
	SELECT TOP 1 @NgayLapHoaDon = NgayTao FROM dbo.HoaDon
	WHERE dbo.HoaDon.HocSinh = @MaHocSinh
	ORDER BY dbo.HoaDon.NgayTao DESC
	IF((@NgayLapHoaDon <= DATEADD(month, DATEDIFF(month, 0, CURRENT_TIMESTAMP)-1, 0)) OR @NgayLapHoaDon IS NULL)
		BEGIN
			INSERT INTO dbo.HoaDon
					( MaHD ,
			          XuLy ,
			          TinhTrang ,
			          HocSinh ,
			          NgayTao
			        )
					VALUES  ( DEFAULT , -- MaHD - varchar(5)
					DEFAULT , -- XuLy - varchar(5)
			        DEFAULT , -- TinhTrang - bit
			          @MaHocSinh , -- HocSinh - varchar(5)
			          DATEADD(month, DATEDIFF(month, 0, CURRENT_TIMESTAMP), 0)  -- NgayCapNhat - datetime
			        )
		END

END




GO
/****** Object:  StoredProcedure [dbo].[ThemCLB]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemCLB]
@TenCLB NVARCHAR(255)
AS
BEGIN
	INSERT INTO dbo.CLB
	        ( MaCLB, TenCLB )
	VALUES  ( DEFAULT, -- MaCLB - varchar(6)
	          @TenCLB  -- TenCLB - nvarchar(255)
	          )
END



GO
/****** Object:  StoredProcedure [dbo].[ThemHocSinh]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHocSinh] 
@TenHS NVARCHAR(255),
@NgaySinh DATETIME,
@TenChaMe NVARCHAR(255),
@SDTChaMe VARCHAR(16),
@DiaChi NVARCHAR(255),
@LopHC VARCHAR(6)
AS
INSERT INTO dbo.HocSinh
        ( MaHS ,
          TenHS ,
          NgaySinh ,
          NgayNhapHoc ,
          TenChaMe ,
          SDTChaMe ,
          DiaChi ,
          LopHC
        )
VALUES  ( DEFAULT , -- MaHS - varchar(5)
          @TenHS , -- TenHS - nvarchar(255)
          @NgaySinh , -- NgaySinh - datetime
          DEFAULT , -- NgayNhapHoc - datetime
          @TenChaMe , -- TenChaMe - nvarchar(255)
          @SDTChaMe , -- SDTChaMe - varchar(16)
          @DiaChi , -- DiaChi - nvarchar(255)
          @LopHC  -- LopHC - varchar(6)
        )



GO
/****** Object:  StoredProcedure [dbo].[ThemLopDangKyMoi]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLopDangKyMoi]
@TenLopDangKy NVARCHAR(255),
@HocPhi DECIMAL(7,3),
@NamHoc VARCHAR(4),
@LichHoc INT,
@MaCLB VARCHAR(6)
AS
BEGIN
	INSERT INTO dbo.LopDangKy
	        ( MaLopDangKy ,
	          TenLopDangKy ,
	          CLB ,
	          NamHoc ,
	          HocPhi ,
	          LichHoc
	        )
	VALUES  ( DEFAULT , -- MaLopDangKy - varchar(6)
	          @TenLopDangKy , -- TenLopDangKy - nvarchar(255)
	          @MaCLB , -- CLB - varchar(6)
	          @NamHoc , -- NamHoc - varchar(4)
	          @HocPhi , -- HocPhi - decimal(7, 3)
	          @LichHoc  -- LichHoc - int
	        )
END


GO
/****** Object:  StoredProcedure [dbo].[ThemLopHC]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLopHC]
@TenLopHC NVARCHAR(255),
@NienKhoa VARCHAR(9),
@TenGiaoVienChuNhiem NVARCHAR(255)
AS
BEGIN
	INSERT INTO dbo.LopHanhChinh
	        ( MaLopHC ,
	          TenLopHC ,
	          NienKhoa ,
	          TenGiaoVienChuNhiem
	        )
	VALUES  ( DEFAULT , -- MaLopHC - varchar(6)
	          @TenLopHC , -- TenLopHC - nvarchar(255)
	          @NienKhoa , -- NienKhoa - varchar(9)
	          @TenGiaoVienChuNhiem  -- TenGiaoVienChuNhiem - nvarchar(255)
	        )
END


GO
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoanGiaoVu]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemTaiKhoanGiaoVu]
@TenGiaoVu NVARCHAR(255),
@TaiKhoan varchar(255),
@MatKhau varchar(255),
@Email varchar(255),
@SDT VARCHAR(16)
AS
BEGIN
	INSERT INTO dbo.GiaoVu
	        ( MaGV ,
	          TenGiaoVu ,
	          TaiKhoan ,
	          MatKhau ,
	          Email ,
	          DienThoai
	        )
	VALUES  ( DEFAULT , -- MaGV - varchar(5)
	          @TenGiaoVu , -- TenGiaoVu - nvarchar(255)
	          @TaiKhoan , -- TaiKhoan - varchar(255)
	          @MatKhau , -- MatKhau - varchar(255)
	          @Email , -- Email - varchar(255)
	          @SDT  -- DienThoai - varchar(16)
	        )
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateTinhTrangHoaDon]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateTinhTrangHoaDon]
@MaHD VARCHAR(5)
AS
	BEGIN
		UPDATE dbo.HoaDon 
		SET TinhTrang = 1
		WHERE MaHD = @MaHD
	END
    

GO
/****** Object:  StoredProcedure [dbo].[UpdateTTCLB]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateTTCLB]
@MaCLB VARCHAR(6),
@TenCLB NVARCHAR(255)
AS
BEGIN
	UPDATE dbo.CLB SET TenCLB = @TenCLB
	WHERE MaCLB = @MaCLB
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateTTGiaoVu]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateTTGiaoVu]
@MaGiaoVu VARCHAR(5),
@TenGiaoVu NVARCHAR(255),
@Email VARCHAR(255),
@DienThoai VARCHAR(16),
@TaiKhoan VARCHAR(255)
AS
BEGIN
	UPDATE dbo.GiaoVu SET 
	TenGiaoVu = @TenGiaoVu,
	Email = @Email,
	DienThoai = @DienThoai,
	TaiKhoan = @TaiKhoan
	WHERE MaGV = @MaGiaoVu	
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateTTHocSinh]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateTTHocSinh]
@MaHocSinh VARCHAR(5),
@TenHocSinh NVARCHAR(255),
@NgaySinh DATETIME,
@TenChaMe NVARCHAR(255),
@SDTChaMe VARCHAR(16),
@DiaChi NVARCHAR(255),
@LopHanhChinh VARCHAR(6)
AS
BEGIN
	UPDATE dbo.HocSinh SET
    TenHS = @TenHocSinh,
	NgaySinh = @NgaySinh,
	TenChaMe = @TenChaMe,
	SDTChaMe = @SDTChaMe,
	DiaChi = @DiaChi,
	LopHC = @LopHanhChinh
	WHERE MaHS = @MaHocSinh
END


GO
/****** Object:  StoredProcedure [dbo].[UpdateTTLopDangKy]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateTTLopDangKy]
@MaLopDangKy VARCHAR(6),
@TenLopDangKy NVARCHAR(255),
@MaCLB VARCHAR(6),
@NamHoc VARCHAR(4),
@HocPhi DECIMAL(7,3),
@LichHoc INT
AS
BEGIN
	UPDATE dbo.LopDangKy 
	SET TenLopDangKy = @TenLopDangKy, CLB = @MaCLB, NamHoc = @NamHoc, HocPhi = @HocPhi, LichHoc = @LichHoc
	WHERE MaLopDangKy = @MaLopDangKy
END


GO
/****** Object:  StoredProcedure [dbo].[XoaDuLieuHoaDOn]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaDuLieuHoaDOn]
@MaHoaDon VARCHAR(5)
AS
DELETE FROM dbo.HoaDon WHERE MaHD = @MaHoaDon


GO
/****** Object:  Trigger [dbo].[XoaHoaDonSauKhiHuyHetDangKyhoc]    Script Date: 22/11/2019 11:43:58 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[XoaHoaDonSauKhiHuyHetDangKyhoc] ON [dbo].[DangKyHoc]
AFTER DELETE
AS
BEGIN
	DECLARE @MaHoaDon VARCHAR(5)
	SELECT @MaHoaDon = Deleted.HoaDon FROM Deleted
	IF(@MaHoaDon NOT IN (SELECT dbo.DangKyHoc.HoaDon FROM dbo.DangKyHoc))
		BEGIN
			DELETE FROM dbo.HoaDon WHERE MaHD = @MaHoaDon
        END
        
END


GO
USE [master]
GO
ALTER DATABASE [MamNonBK] SET  READ_WRITE 
GO
