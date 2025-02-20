USE [master]
GO
/****** Object:  Database [DoAnGUNA]    Script Date: 14/05/2024 2:19:57 CH ******/
CREATE DATABASE [DoAnGUNA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DoAnGUNA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DoAnGUNA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DoAnGUNA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\DoAnGUNA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DoAnGUNA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DoAnGUNA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DoAnGUNA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DoAnGUNA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DoAnGUNA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DoAnGUNA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DoAnGUNA] SET ARITHABORT OFF 
GO
ALTER DATABASE [DoAnGUNA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DoAnGUNA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DoAnGUNA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DoAnGUNA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DoAnGUNA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DoAnGUNA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DoAnGUNA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DoAnGUNA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DoAnGUNA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DoAnGUNA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DoAnGUNA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DoAnGUNA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DoAnGUNA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DoAnGUNA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DoAnGUNA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DoAnGUNA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DoAnGUNA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DoAnGUNA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DoAnGUNA] SET  MULTI_USER 
GO
ALTER DATABASE [DoAnGUNA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DoAnGUNA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DoAnGUNA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DoAnGUNA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DoAnGUNA] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DoAnGUNA]
GO
/****** Object:  Table [dbo].[BangDeNghiThemLuanVan]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDeNghiThemLuanVan](
	[maluanvan] [nvarchar](50) NULL,
	[tenluanvan] [nvarchar](250) NULL,
	[mota] [nvarchar](250) NULL,
	[yeucau] [nvarchar](250) NULL,
	[congnghe] [nvarchar](50) NULL,
	[tensinhvien] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[boxchat]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[boxchat](
	[magiangvien] [varchar](50) NULL,
	[masinhvien] [varchar](50) NULL,
	[manhom] [int] NOT NULL,
	[ten] [nvarchar](50) NULL,
	[noidungchat] [nvarchar](max) NULL,
	[thoigian] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DangKy]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DangKy](
	[maluanvan] [nvarchar](50) NOT NULL,
	[masinhvien] [varchar](50) NOT NULL,
	[tiendo] [nvarchar](max) NULL,
	[danhgia] [nvarchar](max) NULL,
	[chamdiem] [float] NULL,
	[manhom] [int] NULL,
	[sotask] [int] NULL,
	[sohoanthanh] [int] NULL,
	[tasktulam] [int] NULL,
	[xetduyet] [nvarchar](50) NULL,
	[phantram] [int] NULL,
 CONSTRAINT [PK_DangKy_1] PRIMARY KEY CLUSTERED 
(
	[maluanvan] ASC,
	[masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diem](
	[maluanvan] [nvarchar](50) NOT NULL,
	[masinhvien] [varchar](50) NOT NULL,
	[diemlv] [float] NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[maluanvan] ASC,
	[masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiangVien](
	[magiangvien] [varchar](50) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[ngaysinh] [datetime] NULL,
	[email] [varchar](50) NULL,
	[sdt] [varchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[nganh] [nvarchar](50) NULL,
	[matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[magiangvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuanVan]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuanVan](
	[maluanvan] [nvarchar](50) NOT NULL,
	[tenluanvan] [nvarchar](250) NOT NULL,
	[soluongdangky] [int] NULL,
	[mota] [nvarchar](250) NULL,
	[yeucau] [nvarchar](250) NULL,
	[congnghe] [nvarchar](50) NULL,
	[tengiangvien] [nvarchar](50) NULL,
	[task] [nvarchar](max) NULL,
	[xetduyet] [nvarchar](50) NULL,
 CONSTRAINT [PK_LuanVan] PRIMARY KEY CLUSTERED 
(
	[maluanvan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanTramTask]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanTramTask](
	[maluanvan] [nvarchar](50) NULL,
	[taskrieng] [nvarchar](max) NULL,
	[phantram] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SinhVien](
	[masinhvien] [varchar](50) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[email] [varchar](50) NULL,
	[sdt] [varchar](50) NULL,
	[gioitinh] [nvarchar](50) NULL,
	[nganh] [nvarchar](50) NULL,
	[matkhau] [varchar](50) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[masinhvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[taikhoan]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[taikhoan](
	[tentaikhoan] [varchar](50) NOT NULL,
	[matkhau] [varchar](50) NOT NULL,
	[quyen] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'4', N'', 11, N'', N'hello ', CAST(N'2024-05-09 19:06:50.607' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'4', N'', 11, N'', N'hello ', CAST(N'2024-05-09 19:06:51.810' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'4', N'', 11, N'', N'hello ', CAST(N'2024-05-09 19:06:52.727' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'4', N'', 11, N'', N'Ngay mai di hoc nhe ', CAST(N'2024-05-09 22:56:23.983' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'4', N'', 10, N'', N'Hello cac em', CAST(N'2024-05-09 23:01:14.450' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'4', N'', 10, N'', N'Ngay mai thu 6 ngay 10/5/2024 bao cao cuoi ki nhe ', CAST(N'2024-05-09 23:01:47.270' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'', N'19', 17, N'', N'hello nhom ', CAST(N'2024-05-14 08:47:38.620' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'', N'22', 18, N'', N'Hello moi nguoi ', CAST(N'2024-05-14 08:55:07.127' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'', N'4', 11, N'', N'Task1 nay lam nhu the nao vay thay ', CAST(N'2024-05-14 14:08:01.267' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'', N'4', 11, N'', N'Task1 nay lam nhu the nao vay thay ', CAST(N'2024-05-14 14:08:03.507' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'4', N'', 11, N'', N'Ngay mai bao cao cuoi ki nhe cac em ', CAST(N'2024-05-10 01:15:54.840' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'', N'4', 11, N'', N'Da thay ', CAST(N'2024-05-10 09:56:24.567' AS DateTime))
INSERT [dbo].[boxchat] ([magiangvien], [masinhvien], [manhom], [ten], [noidungchat], [thoigian]) VALUES (N'', N'4', 11, N'', N'Bao Cao lam nhu the nao vay a ', CAST(N'2024-05-10 10:17:39.780' AS DateTime))
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'MBA', N'4', N'Lam mo bai,than bai,uu diem,nhuoc diem,cac chuc nang,kha nang bao mat,ket noi internet,luu tru tien,ket luan va huong phat trien,A1', N'/Rát tot, co gang phat huy //Lam them file bao cao nua //Bao cao cuoi ki can co file ppt, file word va file code /', 9, 11, 12, 10, 14, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'MBA', N'5', N'Lam mo bai,than bai,uu diem,nhuoc diem,cac chuc nang,kha nang bao mat,ket noi internet,luu tru tien,ket luan va huong phat trien,A1', N'/Rát tot, co gang phat huy //Lam them file bao cao nua //Bao cao cuoi ki can co file ppt, file word va file code /', 4, 11, 12, 10, 2, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'MBA', N'6', N'Lam mo bai,than bai,uu diem,nhuoc diem,cac chuc nang,kha nang bao mat,ket noi internet,luu tru tien,ket luan va huong phat trien,A1', NULL, 7, 11, 12, 10, 3, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLCH', N'3', NULL, NULL, NULL, 2, 0, 0, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLCHTL', N'23', NULL, NULL, NULL, 20, NULL, 0, NULL, N'NY', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLCHTL', N'24', NULL, NULL, NULL, 20, NULL, 0, NULL, N'NY', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLCHTL', N'25', NULL, NULL, NULL, 20, NULL, 0, NULL, N'NY', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLHS', N'11', NULL, NULL, NULL, 12, 5, 0, NULL, N'NY', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLNV', N'10', NULL, NULL, NULL, 3, 0, 0, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLPT', N'8', NULL, NULL, NULL, 4, 0, 0, NULL, N'NY', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLPH', N'2', N'lam mo bai', NULL, NULL, 7, 5, 1, 1, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLPH', N'7', N'lam mo bai', NULL, NULL, 7, 5, 1, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLPH', N'SV001', NULL, NULL, NULL, 7, 5, 0, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLQCF', N'9', N'Len Y Tuong,Ve So Do Thiet Ke Y Tuong,Lam các Class Co Ban,Thiet Ke UI,Them Cac Chuc Nang', N'///Lam con cham//Lam bao cao cho hoan chinh //Lam cham/', NULL, 9, 8, 5, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLQCF', N'SV003', N'Len Y Tuong,Ve So Do Thiet Ke Y Tuong,Lam các Class Co Ban,Thiet Ke UI,Them Cac Chuc Nang', N'///Lam con cham//Lam bao cao cho hoan chinh //Lam cham/', NULL, 9, 8, 5, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLQCF', N'SV005', N'Len Y Tuong,Ve So Do Thiet Ke Y Tuong,Lam các Class Co Ban,Thiet Ke UI,Them Cac Chuc Nang', N'///Lam con cham//Lam bao cao cho hoan chinh //Lam cham/', NULL, 9, 8, 5, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLSB', N'SV002', N'Len Y Tuong,Ve So Do Thiet Ke Y Tuong,Lam các Class Co Ban,Thiet Ke UI,Them Cac Chuc Nang,Fix Loi,Ket Noi App Voi Internet', N'Co gang làm phần báo cáo cho tot nhé //Lam bao cao bang file word nhe /', 8, 10, 8, 7, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLSVD', N'19', N'A1,A2,A3,A4,A4,A4,A4', NULL, 9, 17, 15, 7, 14, N'Y', 100)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLSVD', N'20', N'A1,A2,A3,A4,A4,A4,A4', NULL, NULL, 17, 15, 7, 1, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLSVD', N'21', N'A1,A2,A3,A4,A4,A4,A4', NULL, NULL, 17, 15, 7, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLTV', N'12', N'Thiet Ke Y Tuong,THiet Ke Giao Dien,Tao cac class co ban,Viet cac code ham chuc nang cua ung dung,Kiem tra bug', NULL, 8, 13, 6, 5, 4, N'Y', 100)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLTV', N'13', N'Thiet Ke Y Tuong,THiet Ke Giao Dien,Tao cac class co ban,Viet cac code ham chuc nang cua ung dung,Kiem tra bug', NULL, 7, 13, 6, 5, 1, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLTV', N'15', N'Thiet Ke Y Tuong,THiet Ke Giao Dien,Tao cac class co ban,Viet cac code ham chuc nang cua ung dung,Kiem tra bug', NULL, 3, 13, 6, 5, 0, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'QLXHK', N'22', N'', NULL, NULL, 18, 6, 0, 10, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'VDT', N'16', NULL, NULL, NULL, 15, 5, 0, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'VDT', N'17', NULL, NULL, NULL, 15, 5, 0, NULL, N'Y', NULL)
INSERT [dbo].[DangKy] ([maluanvan], [masinhvien], [tiendo], [danhgia], [chamdiem], [manhom], [sotask], [sohoanthanh], [tasktulam], [xetduyet], [phantram]) VALUES (N'VDT', N'18', NULL, NULL, NULL, 15, 5, 0, NULL, N'Y', NULL)
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'1', N'Le Anh Tu', N'HCM', CAST(N'2000-01-01 00:00:00.000' AS DateTime), N'lat@gmail.com', N'0909112233', N'nam', N'cntt', N'12345')
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'10', N'Nguyễn Nam', N'HN', CAST(N'1992-12-31 00:00:00.000' AS DateTime), N'nam@gmail.com', N'0123456789', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'11', N'Trần Tuyet', N'HCM', CAST(N'1995-01-01 00:00:00.000' AS DateTime), N'tuyet@gmail.com', N'0987654321', N'Nữ', N'CNTT', N'12345')
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'12', N'Lê Lai', N'Da Lat', CAST(N'1991-02-02 00:00:00.000' AS DateTime), N'Lelai@gmail.com', N'0345678901', N'Nam', N'Quan Tri Mang', N'12345')
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'13', N'Phạm Duong', N'Ca Mau', CAST(N'1992-03-03 00:00:00.000' AS DateTime), N'PD@gmail.com', N'0456789012', N'Nữ', N'Kỹ thuật phần mềm', N'12345')
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'14', N'Vũ Trong Phung', N'Ninh Thuan', CAST(N'1993-04-04 00:00:00.000' AS DateTime), N'vuphung@gmail.com', N'0567890123', N'Nam', N'CNTT', N'12345')
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'2', N'Le Van Tu', N'HCM', CAST(N'2004-02-01 00:00:00.000' AS DateTime), N'lvt@gmail.com', N'0909112233', N'nam', N'cntt', N'12345')
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'3', N'Chu Du', N'HCM', CAST(N'1999-01-01 00:00:00.000' AS DateTime), N'cd@gmail.com', N'0909112233', N'nam', N'cntt', N'12345')
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'4', N'Gia Cat Luong', N'HCM', CAST(N'1988-01-01 00:00:00.000' AS DateTime), N'gcl@gmail.com', N'0909112233', N'nam', N'cntt', N'12345')
INSERT [dbo].[GiangVien] ([magiangvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'5', N'Luu Bi', N'HCM', CAST(N'1992-01-01 00:00:00.000' AS DateTime), N'lb@gmail.com', N'0909564622', N'nam', N'cntt', N'12345')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'MBA', N'Mobile Banking App', 4, N'Tao 1 app mobile banking', N'su dung OOP', N'C#', N'Gia Cat Luong', N'Lam mo bai, than bai, uu diem, nhuoc diem, cac chuc nang, kha nang bao mat, ket noi internet, luu tru tien, ket luan va huong phat trien ,A1, A2,A3 ', N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLCH', N'Quan ly cua hang', 5, N'tao app quan ly cua hang ', N'dung cau truc du lieu ', N'C#, Java', N'Chu Du', NULL, N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLCHTL', N'Quan Ly Cua Hang Tien Loi', 4, N'Tao app giup quan ly mua ban hang hoa o cac cua hang tien  loi', N'Dung OOP', N'C#', N'Ph?m Duong', N'Thiet Ke Y Tuong, Tao cac class co ban, Thiet ke giao dien, Viet cac code ham chuc nang cua ung dung, Kiem tra bug, Viet bao Cao', N'A')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLHS', N'Quan Ly Hoc Sinh ', 4, N'Tao App Quan Ly hoc sinh cho cac truong hoc ', N'DUNG OOP ', N'C# ', N'Gia Cat Luong', N'Lam UI, Viet cac ham chuc nang, Viet code cac Class, Lam them 1 do an tuong tu dung ENTITY, Viet bao cao ', N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLNV', N'Quan ly nhan vien ', 4, N'tao app quan ly nhan vien ', N'dung C#,...', N'NodeJs, C#', N'Chu Du', NULL, N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLPT', N'Quan Ly Phong Tro', 5, N'tao App Quan Ly phong tro ', N'dung C#', N'C#', N'Nguy?n Nam', NULL, N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLPH', N'Quan ly phong hop', 3, N'tao app', N'dung oop', N'c#', N'Chu Du', N'lam mo bai, than bai, ket bai, uu diem, nhuoc diem', N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLQCF', N'Quan Ly Quan Ca Fe', 5, N'Tao app quan ly quan Cafe', N'Dung OOP', N'C#', N'Le Van Tu', N'Len Y Tuong, Ve So Do Thiet Ke Y Tuong, Lam các Class Co Ban, Thiet Ke UI, Them Cac Chuc Nang,  Fix Loi, Ket Noi App Voi Internet, Viet Bao Cao', N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLSB', N'Quan Ly San Bong', 6, N'Tao Ung Dung quan ly san bong ', N'Dung OOP va CTDL', N'C#', N'Tr?n Tuyet', N'Len Y Tuong, Ve So Do Thiet Ke Y Tuong, Lam các Class Co Ban, Thiet Ke UI, Them Cac Chuc Nang,  Fix Loi, Ket Noi App Voi Internet, Viet Bao Cao', N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLSVD', N'Quan Ly San Van Dong', 4, N'Tao app quan ly san van dong', N'su dung OOP', N'C#', N'Gia Cat Luong', N'A1,A2,A3,A4,A5,A6,A4,A5,A6,A4,A5,A6,A4,A5,A6', N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLTV', N'Quan Ly Thu Vien ', 5, N'Tao App quan ly thu vien ', N'Dung C#, OOP', N'C#', N'Gia Cat Luong', N'Thiet Ke Y Tuong, THiet Ke Giao Dien, Tao cac class co ban, Viet cac code ham chuc nang cua ung dung, Kiem tra bug, Viet bao Cao', N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'QLXHK', N' Quan Ly Xuat Nhap Khau', 3, N'Tao App cho cac cong ty de quan ly xuat nhap khau', N'Dung OOP', N'C#', N'Chu Du', N'A1, A2, A3, A4,A5, A6', N'Y')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'TCB', N'TechcomBank', 0, N'tao app cho ngan hang Techcombank', N'Dung OOP', N'C#', N'', N'', N'A')
INSERT [dbo].[LuanVan] ([maluanvan], [tenluanvan], [soluongdangky], [mota], [yeucau], [congnghe], [tengiangvien], [task], [xetduyet]) VALUES (N'VDT', N'Vi Dien Tu', 4, N'Tao 1 App Vi Dien Tu ', N'Dung OOP', N'C#', N'Chu Du', N'Thiet ke giao dien, Dung Class co ban, Tao cac chuc nang, Kiem Tra Bugs, Viet Bao Cao ', N'Y')
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'Lam mo bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'than bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'uu diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'nhuoc diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'cac chuc nang', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'kha nang bao mat', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket noi internet', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'luu tru tien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket luan va huong phat trien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
GO
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'Lam mo bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'than bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'uu diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'nhuoc diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'cac chuc nang', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'kha nang bao mat', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket noi internet', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'luu tru tien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket luan va huong phat trien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', 85)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Len Y Tuong', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Ve So Do Thiet Ke Y Tuong', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Lam các Class Co Ban', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Thiet Ke UI', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Them Cac Chuc Nang', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Fix Loi', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Ket Noi App Voi Internet', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Viet Bao Cao', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Len Y Tuong', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Ve So Do Thiet Ke Y Tuong', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Lam các Class Co Ban', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Thiet Ke UI', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Them Cac Chuc Nang', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Fix Loi', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Ket Noi App Voi Internet', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Viet Bao Cao', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Len Y Tuong', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Ve So Do Thiet Ke Y Tuong', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Lam các Class Co Ban', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Thiet Ke UI', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Them Cac Chuc Nang', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Fix Loi', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Ket Noi App Voi Internet', 0)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSB', N'Viet Bao Cao', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A5', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLSVD', N'A6', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
GO
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A2', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A3', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A4', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A5', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'QLXHK', N'A6', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'Lam mo bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'than bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'uu diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'nhuoc diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'cac chuc nang', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'kha nang bao mat', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket noi internet', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'luu tru tien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket luan va huong phat trien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A2', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A3', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'Lam mo bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'than bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'uu diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'nhuoc diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'cac chuc nang', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'kha nang bao mat', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket noi internet', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'luu tru tien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket luan va huong phat trien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A2', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A3', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'Lam mo bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'than bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'uu diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'nhuoc diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'cac chuc nang', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'kha nang bao mat', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket noi internet', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'luu tru tien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket luan va huong phat trien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A2', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A3', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'Lam mo bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'than bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'uu diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'nhuoc diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'cac chuc nang', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'kha nang bao mat', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket noi internet', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'luu tru tien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket luan va huong phat trien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A2', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A3', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'Lam mo bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'than bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'uu diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'nhuoc diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'cac chuc nang', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'kha nang bao mat', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket noi internet', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'luu tru tien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket luan va huong phat trien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A2', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A3', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'Lam mo bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'than bai', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'uu diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'nhuoc diem', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'cac chuc nang', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'kha nang bao mat', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket noi internet', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'luu tru tien', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'ket luan va huong phat trien', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A1', 100)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A2', NULL)
INSERT [dbo].[PhanTramTask] ([maluanvan], [taskrieng], [phantram]) VALUES (N'MBA', N'A3', NULL)
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'10', N'abcd', N'HCM', CAST(N'2004-01-01' AS Date), N'abcd@gmail.com', N'01234576215', N'Nu', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'11', N'Tran Trung Quan', N'HCM', CAST(N'2005-01-02' AS Date), N'ttq@gmail.com', N'0321567899', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'12', N'Tran Tien Dai', N'HCM', CAST(N'2004-04-04' AS Date), N'ttd@gmail.com', N'0125478963', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'13', N'Ly Minh Hoang', N'HCM ', CAST(N'2005-05-04' AS Date), N'lmh@gmail.com', N'0235697451', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'14', N'Trieu Tu Long', N'HCM', CAST(N'2002-04-02' AS Date), N'ttl@gmail.com', N'0214578535', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'15', N'Vuong Nguyen Co ', N'HCM', CAST(N'2003-04-04' AS Date), N'vnc@gmail.com', N'0214578963', N'Nu', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'16', N'Nguyen Van Tung', N'HCM', CAST(N'2001-04-04' AS Date), N'nvt@gmail.com', N'0742359864', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'17', N'Ly Nguyen Dang', N'NT', CAST(N'2002-04-06' AS Date), N'lnd@gmail.com', N'0742359751', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'18', N'HUynh Nguyen ', N'NT', CAST(N'2001-04-04' AS Date), N'hn@gmail.com', N'0742375139', N'Nu', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'19', N'Le Cong Vinh', N'NT', CAST(N'2000-04-04' AS Date), N'lcv@gmail.com', N'0121546868', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'2', N'Le Van Tu', N'HCM', CAST(N'2004-02-01' AS Date), N'lvt@gmail.com', N'0909112233', N'nam', N'cntt', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'20', N'Nguyen Quang Hai ', N'HCM', CAST(N'2000-04-07' AS Date), N'nqh@gmail.com', N'0154655456', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'21', N'Nguyen Tien Linh ', N'Binh Duong', CAST(N'2000-06-07' AS Date), N'ntl@gmail.com', N'0934562487', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'22', N'Quynh Nhu', N'HCM', CAST(N'2000-04-05' AS Date), N'qn@gmail.com', N'0962888956', N'Nu', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'23', N'Dinh Bo Linh', N'Ha Noi', CAST(N'2001-04-04' AS Date), N'dbl@gmail.com', N'0898542565', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'24', N'Ma Van Loc', N'HCM', CAST(N'2005-01-04' AS Date), N'mvl@gmail.com', N'0325648997', N'Nu', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'25', N'Dieu Thuyen', N'HCM', CAST(N'2003-04-04' AS Date), N'dt@gmail.com', N'0358979456', N'Nu', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'3', N'Tao Thao', N'HCM', CAST(N'1999-01-01' AS Date), N'cd@gmail.com', N'0909112233', N'nam', N'cntt', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'4', N'Quan Vu', N'HCM', CAST(N'1988-01-01' AS Date), N'gcl@gmail.com', N'0909112233', N'nam', N'cntt', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'5', N'Truong Phi', N'HCM', CAST(N'1992-01-01' AS Date), N'lb@gmail.com', N'0909564622', N'nam', N'cntt', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'6', N'Le Tu', N'HCM', CAST(N'2006-02-01' AS Date), N'lt@gmail.com', N'09091123', N'nam', N'cntt', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'7', N'Le Thi D', N'HCM', CAST(N'2002-04-04' AS Date), N'ltd@gmail.com', N'124792', N'Nữ', N'IT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'8', N'Quan Van Truong', N'HCM', CAST(N'2005-01-01' AS Date), N'qvt@gmail.com', N'0236859855', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'9', N'Tran Dinh Trong ', N'HCM ', CAST(N'2003-01-01' AS Date), N'tdt@gmail.com', N'0312489455', N'Nam', N'CNTT', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'SV001', N'Nguyễn Văn A', N'Hà N?i', CAST(N'1999-12-31' AS Date), N'abc@gmail.com', N'0123456789', N'Nam', N'Công nghệ thông tin', N'123456')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'SV002', N'Trần Thị B', N'TP H? Chí Minh', CAST(N'2000-01-01' AS Date), N'xyz@gmail.com', N'0987654321', N'Nữ', N'Kinh tế', N'456789')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'SV003', N'Lê Văn C', N'Đà N?ng', CAST(N'2001-02-02' AS Date), N'def@gmail.com', N'0345678901', N'Nam', N'Quản trị kinh doanh', N'789012')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'SV004', N'Phạm Thị D', N'C?n Thơ', CAST(N'2002-03-03' AS Date), N'ghi@gmail.com', N'0456789012', N'Nữ', N'Kỹ thuật phần mềm', N'102938')
INSERT [dbo].[SinhVien] ([masinhvien], [ten], [diachi], [ngaysinh], [email], [sdt], [gioitinh], [nganh], [matkhau]) VALUES (N'SV005', N'Vũ Văn E', N'H?i Ph?ng', CAST(N'2003-04-04' AS Date), N'jkl@gmail.com', N'0567890123', N'Nam', N'Công nghệ thông tin', N'123456')
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_LuanVan] FOREIGN KEY([maluanvan])
REFERENCES [dbo].[LuanVan] ([maluanvan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_LuanVan]
GO
ALTER TABLE [dbo].[DangKy]  WITH CHECK ADD  CONSTRAINT [FK_DangKy_SinhVien] FOREIGN KEY([masinhvien])
REFERENCES [dbo].[SinhVien] ([masinhvien])
GO
ALTER TABLE [dbo].[DangKy] CHECK CONSTRAINT [FK_DangKy_SinhVien]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_LuanVan] FOREIGN KEY([maluanvan])
REFERENCES [dbo].[LuanVan] ([maluanvan])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_LuanVan]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY([masinhvien])
REFERENCES [dbo].[SinhVien] ([masinhvien])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_SinhVien]
GO
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 14/05/2024 2:19:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dangnhap]
	@loaitaikhoan varchar(50),
	@taikhoan varchar(50),
	@matkhau varchar(50)
as 
begin
	
	if @loaitaikhoan = 'gv' 
				select *
				from GiangVien
				where CONVERT (varchar(50), magiangvien ) = @taikhoan
				and matkhau = @matkhau;
		 else 
				select *
				from SinhVien
				where CONVERT (varchar(50), masinhvien ) = @taikhoan
				and matkhau = @matkhau;
end 
GO
USE [master]
GO
ALTER DATABASE [DoAnGUNA] SET  READ_WRITE 
GO
