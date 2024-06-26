USE [HastaneRandevu]
GO
/****** Object:  Table [dbo].[doktorlar]    Script Date: 7.05.2024 15:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doktorlar](
	[doktorno] [int] IDENTITY(1,1) NOT NULL,
	[doktor] [nchar](30) NOT NULL,
	[polno] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[poller]    Script Date: 7.05.2024 15:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[poller](
	[polno] [int] IDENTITY(1,1) NOT NULL,
	[pol] [nchar](20) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[randevular]    Script Date: 7.05.2024 15:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[randevular](
	[randevuno] [int] IDENTITY(1,1) NOT NULL,
	[hasta] [nchar](30) NOT NULL,
	[tc] [nchar](11) NOT NULL,
	[doktorno] [int] NOT NULL,
	[tarih] [nchar](20) NOT NULL,
	[saatno] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[saatler]    Script Date: 7.05.2024 15:13:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[saatler](
	[saatno] [int] IDENTITY(1,1) NOT NULL,
	[saatler] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[doktorlar] ON 

INSERT [dbo].[doktorlar] ([doktorno], [doktor], [polno]) VALUES (1, N'Ömer Ateş                     ', 1)
INSERT [dbo].[doktorlar] ([doktorno], [doktor], [polno]) VALUES (2, N'Şule Şahin                    ', 2)
INSERT [dbo].[doktorlar] ([doktorno], [doktor], [polno]) VALUES (3, N'Ömer Ünver                    ', 3)
INSERT [dbo].[doktorlar] ([doktorno], [doktor], [polno]) VALUES (1002, N'Veysel Ateş                   ', 2)
INSERT [dbo].[doktorlar] ([doktorno], [doktor], [polno]) VALUES (1003, N'Ahmet Ünal                    ', 1)
INSERT [dbo].[doktorlar] ([doktorno], [doktor], [polno]) VALUES (1004, N'Muhammet Özbek                ', 2)
INSERT [dbo].[doktorlar] ([doktorno], [doktor], [polno]) VALUES (1005, N'Büşra Kaya                    ', 3)
INSERT [dbo].[doktorlar] ([doktorno], [doktor], [polno]) VALUES (1006, N'Mustafa Emin                  ', 1)
SET IDENTITY_INSERT [dbo].[doktorlar] OFF
GO
SET IDENTITY_INSERT [dbo].[poller] ON 

INSERT [dbo].[poller] ([polno], [pol]) VALUES (1, N'Kardiyoloji         ')
INSERT [dbo].[poller] ([polno], [pol]) VALUES (2, N'Göz  Hastalıkları   ')
INSERT [dbo].[poller] ([polno], [pol]) VALUES (3, N'Çocuk Hastalıkları  ')
SET IDENTITY_INSERT [dbo].[poller] OFF
GO
SET IDENTITY_INSERT [dbo].[randevular] ON 

INSERT [dbo].[randevular] ([randevuno], [hasta], [tc], [doktorno], [tarih], [saatno]) VALUES (4006, N'b                             ', N'2          ', 1005, N'1.05.2024           ', 3)
INSERT [dbo].[randevular] ([randevuno], [hasta], [tc], [doktorno], [tarih], [saatno]) VALUES (5009, N'www                           ', N'1111       ', 1005, N'8.05.2024           ', 1)
INSERT [dbo].[randevular] ([randevuno], [hasta], [tc], [doktorno], [tarih], [saatno]) VALUES (5010, N'eee                           ', N'111        ', 2, N'8.05.2024           ', 2)
INSERT [dbo].[randevular] ([randevuno], [hasta], [tc], [doktorno], [tarih], [saatno]) VALUES (5011, N'ppppp                         ', N'55555      ', 2, N'8.05.2024           ', 5)
SET IDENTITY_INSERT [dbo].[randevular] OFF
GO
SET IDENTITY_INSERT [dbo].[saatler] ON 

INSERT [dbo].[saatler] ([saatno], [saatler]) VALUES (1, N'10:30     ')
INSERT [dbo].[saatler] ([saatno], [saatler]) VALUES (2, N'11:00     ')
INSERT [dbo].[saatler] ([saatno], [saatler]) VALUES (3, N'11:30     ')
INSERT [dbo].[saatler] ([saatno], [saatler]) VALUES (4, N'12:00     ')
INSERT [dbo].[saatler] ([saatno], [saatler]) VALUES (5, N'12:30     ')
SET IDENTITY_INSERT [dbo].[saatler] OFF
GO
