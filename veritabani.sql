USE [uzaktan]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8.7.2020 14:31:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[admin]    Script Date: 8.7.2020 14:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kul] [nvarchar](max) NULL,
	[sifre] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[admin_table]    Script Date: 8.7.2020 14:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admin_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kul] [nvarchar](max) NULL,
	[sifre] [nvarchar](max) NULL,
 CONSTRAINT [PK_admin_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[canli_table]    Script Date: 8.7.2020 14:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[canli_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ders_id] [int] NOT NULL,
	[link] [nvarchar](max) NULL,
	[tarih] [nvarchar](max) NOT NULL,
	[derslerid] [int] NULL,
 CONSTRAINT [PK_canli_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cevaplar_table]    Script Date: 8.7.2020 14:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cevaplar_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ogrenci_id] [int] NOT NULL,
	[konu_id] [int] NOT NULL,
	[test_id] [int] NOT NULL,
	[soru_sira] [int] NOT NULL,
	[a] [nvarchar](max) NULL,
	[b] [nvarchar](max) NULL,
	[c] [nvarchar](max) NULL,
	[d] [nvarchar](max) NULL,
	[e] [nvarchar](max) NULL,
	[sonuc] [nvarchar](max) NULL,
 CONSTRAINT [PK_cevaplar_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dersler_table]    Script Date: 8.7.2020 14:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dersler_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ders] [nvarchar](max) NULL,
 CONSTRAINT [PK_dersler_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[konular_table]    Script Date: 8.7.2020 14:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[konular_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ders_id] [int] NOT NULL,
	[konu] [nvarchar](max) NULL,
	[youtube] [nvarchar](max) NULL,
	[video] [nvarchar](max) NULL,
	[dokuman] [nvarchar](max) NULL,
	[sinav] [int] NOT NULL,
	[sira] [int] NOT NULL,
	[derslerid] [int] NULL,
 CONSTRAINT [PK_konular_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[odev_table]    Script Date: 8.7.2020 14:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odev_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ders_id] [int] NOT NULL,
	[konu_id] [int] NOT NULL,
	[odevs] [nvarchar](max) NULL,
	[derslerid] [int] NULL,
	[ogrenciid] [int] NULL,
 CONSTRAINT [PK_odev_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ogrenci_table]    Script Date: 8.7.2020 14:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ogrenci_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tcno] [nvarchar](max) NOT NULL,
	[ad] [nvarchar](max) NULL,
	[soyad] [nvarchar](max) NULL,
	[telefon] [nvarchar](max) NULL,
	[dtarih] [nvarchar](max) NULL,
	[egitim] [nvarchar](max) NULL,
	[burs] [nvarchar](max) NULL,
	[onay] [nvarchar](max) NULL,
	[kayit] [nvarchar](max) NULL,
	[sube] [nvarchar](max) NULL,
	[ders_id] [int] NOT NULL,
	[kul] [nvarchar](max) NULL,
	[sifre] [nvarchar](max) NULL,
 CONSTRAINT [PK_ogrenci_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinav_table]    Script Date: 8.7.2020 14:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinav_table](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ogrenci_id] [int] NOT NULL,
	[konu_id] [int] NOT NULL,
	[ders_id] [int] NULL,
	[test_id] [int] NOT NULL,
	[soru_sira] [int] NOT NULL,
	[soru] [nvarchar](max) NULL,
	[a] [nvarchar](max) NULL,
	[b] [nvarchar](max) NULL,
	[c] [nvarchar](max) NULL,
	[d] [nvarchar](max) NULL,
	[e] [nvarchar](max) NULL,
	[cevap] [nvarchar](max) NULL,
	[ogrenciid] [int] NULL,
	[konularid] [int] NULL,
	[derslerid] [int] NULL,
 CONSTRAINT [PK_sinav_table] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[admin] ON 

INSERT [dbo].[admin] ([id], [kul], [sifre]) VALUES (1, N'1', N'1')
SET IDENTITY_INSERT [dbo].[admin] OFF
GO
SET IDENTITY_INSERT [dbo].[admin_table] ON 

INSERT [dbo].[admin_table] ([id], [kul], [sifre]) VALUES (1, N'1', N'1')
SET IDENTITY_INSERT [dbo].[admin_table] OFF
GO
SET IDENTITY_INSERT [dbo].[dersler_table] ON 

INSERT [dbo].[dersler_table] ([id], [ders]) VALUES (1, N'Deneme2')
SET IDENTITY_INSERT [dbo].[dersler_table] OFF
GO
SET IDENTITY_INSERT [dbo].[konular_table] ON 

INSERT [dbo].[konular_table] ([id], [ders_id], [konu], [youtube], [video], [dokuman], [sinav], [sira], [derslerid]) VALUES (1, 1, N'yeni', N'https://www.youtube.com/watch?v=DoQxssyF0No', NULL, NULL, 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[konular_table] OFF
GO
SET IDENTITY_INSERT [dbo].[odev_table] ON 

INSERT [dbo].[odev_table] ([id], [ders_id], [konu_id], [odevs], [derslerid], [ogrenciid]) VALUES (1, 1, 1, N'sfdaf', NULL, NULL)
SET IDENTITY_INSERT [dbo].[odev_table] OFF
GO
SET IDENTITY_INSERT [dbo].[ogrenci_table] ON 

INSERT [dbo].[ogrenci_table] ([id], [tcno], [ad], [soyad], [telefon], [dtarih], [egitim], [burs], [onay], [kayit], [sube], [ders_id], [kul], [sifre]) VALUES (3, N'2', N'2', N'2', N'2', N'2', N'2', N'2', N'2', N'2', N'2', 2, N'2', N'2')
SET IDENTITY_INSERT [dbo].[ogrenci_table] OFF
GO
ALTER TABLE [dbo].[konular_table]  WITH CHECK ADD  CONSTRAINT [FK_konular_table_dersler_table_derslerid] FOREIGN KEY([derslerid])
REFERENCES [dbo].[dersler_table] ([id])
GO
ALTER TABLE [dbo].[konular_table] CHECK CONSTRAINT [FK_konular_table_dersler_table_derslerid]
GO
ALTER TABLE [dbo].[odev_table]  WITH CHECK ADD  CONSTRAINT [FK_odev_table_dersler_table_derslerid] FOREIGN KEY([derslerid])
REFERENCES [dbo].[dersler_table] ([id])
GO
ALTER TABLE [dbo].[odev_table] CHECK CONSTRAINT [FK_odev_table_dersler_table_derslerid]
GO
ALTER TABLE [dbo].[odev_table]  WITH CHECK ADD  CONSTRAINT [FK_odev_table_ogrenci_table_ogrenciid] FOREIGN KEY([ogrenciid])
REFERENCES [dbo].[ogrenci_table] ([id])
GO
ALTER TABLE [dbo].[odev_table] CHECK CONSTRAINT [FK_odev_table_ogrenci_table_ogrenciid]
GO
ALTER TABLE [dbo].[sinav_table]  WITH CHECK ADD  CONSTRAINT [FK_sinav_table_dersler_table_derslerid] FOREIGN KEY([derslerid])
REFERENCES [dbo].[dersler_table] ([id])
GO
ALTER TABLE [dbo].[sinav_table] CHECK CONSTRAINT [FK_sinav_table_dersler_table_derslerid]
GO
ALTER TABLE [dbo].[sinav_table]  WITH CHECK ADD  CONSTRAINT [FK_sinav_table_konular_table_konularid] FOREIGN KEY([konularid])
REFERENCES [dbo].[konular_table] ([id])
GO
ALTER TABLE [dbo].[sinav_table] CHECK CONSTRAINT [FK_sinav_table_konular_table_konularid]
GO
ALTER TABLE [dbo].[sinav_table]  WITH CHECK ADD  CONSTRAINT [FK_sinav_table_ogrenci_table_ogrenciid] FOREIGN KEY([ogrenciid])
REFERENCES [dbo].[ogrenci_table] ([id])
GO
ALTER TABLE [dbo].[sinav_table] CHECK CONSTRAINT [FK_sinav_table_ogrenci_table_ogrenciid]
GO
