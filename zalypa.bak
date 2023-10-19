USE [163Weapon]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[Phone] [char](11) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
	[IdGender] [int] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Document]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Document](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FileList] [nvarchar](50) NOT NULL,
	[IdClient] [int] NOT NULL,
 CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[Phone] [char](11) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Birthday] [date] NOT NULL,
	[IdGender] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gender]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdClient] [int] NOT NULL,
	[IdEmployee] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[IdOrder] [int] NOT NULL,
	[IdProduct] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_OrderProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostEmployee]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostEmployee](
	[IdPost] [int] NOT NULL,
	[IdEmployee] [int] NOT NULL,
 CONSTRAINT [PK_PostEmployee] PRIMARY KEY CLUSTERED 
(
	[IdPost] ASC,
	[IdEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 19.10.2023 18:45:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[Cost] [decimal](10, 2) NOT NULL,
	[IdCategory] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Title], [Description]) VALUES (1, N'Холодное оружие', NULL)
INSERT [dbo].[Category] ([Id], [Title], [Description]) VALUES (2, N'Огнестрельное оружие', NULL)
INSERT [dbo].[Category] ([Id], [Title], [Description]) VALUES (3, N'Оружие ближнего боя', NULL)
INSERT [dbo].[Category] ([Id], [Title], [Description]) VALUES (4, N'Обвес', NULL)
INSERT [dbo].[Category] ([Id], [Title], [Description]) VALUES (5, N'Блочные', NULL)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (1, N'Андрей', N'Носов', N'Матвеевич', N'89831800670', N'kaft93x@outlook.com', CAST(N'1995-11-09' AS Date), 2, N'kRFAFXNq2-')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (2, N'Артём', N'Данисимов', N'Александрович', N'89378575179', N'dcu@yandex.ru', CAST(N'1984-05-19' AS Date), 2, N'87-jgm3-Mg')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (3, N'Тамерлан', N'Архипов', N'Матвеевич', N'89269621673', N'19dn@outlook.com', CAST(N'2008-06-27' AS Date), 1, N'XOuk-Ge84h')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (4, N'Максим', N'Алехандров', N'Алексеевич', N'89555308972', N'pa5h@mail.ru', CAST(N'1980-07-08' AS Date), 2, N'OFUgk-nyj3')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (5, N'Василий', N'Смазков', N'Константинович', N'89848789455', N'281av0@gmail.com', CAST(N'1977-11-10' AS Date), 2, N'm7Fl4-Vfow')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (6, N'Валерий', N'Козлов', N'Дмитриевич', N'89600284653', N'8edmfh@outlook.com', CAST(N'1980-02-03' AS Date), 2, N'Z7QkLiGz')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (7, N'Андей', N'Жуков', N'Матвеевич', N'89516434846', N'sfn13i@mail.ru', CAST(N'2009-04-07' AS Date), 1, N'vH3oPeo2w')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (8, N'Вася', N'Смирнова', N'Михайловна', N'89202950323', N'g0orc3x1@outlook.com', CAST(N'2022-10-03' AS Date), 1, N'r-Z1d_lDku')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (9, N'Карина', N'Лаптев', N'Глебович', N'89334311269', N'rv7bp@gmail.com', CAST(N'2015-05-22' AS Date), 1, N'9_sVV0CN7a')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (10, N'Ксюня', N'Митрофанов', N'Даниилович', N'89273718850', N'93@outlook.com', CAST(N'1983-09-22' AS Date), 1, N'EzDBNkR_1i')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (11, N'Мирон', N'Златовласова', N'Павлович', N'89501630990', N'er@gmail.com', CAST(N'2017-03-13' AS Date), 1, N'd-_0Q8hsaJ')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (12, N'Мария', N'Коновалов', N'Ивановна', N'89168748547', N'o0my@gmail.com', CAST(N'1986-10-02' AS Date), 1, N'i-lA6c0wTJ')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (13, N'Василиса', N'Рыжова', N'Матвеевна', N'89353225562', N'715qy08@gmail.com', CAST(N'2006-02-03' AS Date), 1, N'_6uwrgKvER')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (14, N'Артём', N'Маркелов', N'Леонидович', N'89992614989', N'vubx0t@mail.ru', CAST(N'1974-02-04' AS Date), 2, N'zXDg7Ofy-x')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (15, N'Мирослава', N'Грибова', N'Андреевна', N'89573663733', N'wnhborq@outlook.com', CAST(N'1990-09-04' AS Date), 2, N'te3dl2QHz_')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (16, N'Софья', N'Винокурова', N'Игоревна', N'89895911801', N'gq@yandex.ru', CAST(N'1971-01-10' AS Date), 2, N'tiP7V2O_XK')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (17, N'Таисия', N'Павлова', N'Михайловна', N'89262311496', N'ic0pu@outlook.com', CAST(N'1983-09-23' AS Date), 2, N'OrSs_1K1_e')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (18, N'Мария', N'Парфенова', N'Ивановна', N'89990792758', N'o7khr@yandex.ru', CAST(N'2022-08-22' AS Date), 1, N'-P-c61Soat')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (19, N'Софья', N'Борисова', N'Мироновна', N'89708321823', N'2shlaq@outlook.com', CAST(N'1987-06-27' AS Date), 1, N'd-JP_l3SRb')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (20, N'Виктория', N'Савина', N'Максимовна', N'89030314234', N'cdbw@yandex.ru', CAST(N'2005-11-18' AS Date), 1, N'G-1D0HoIwt')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (21, N'Ксения', N'Масленникова', N'Марковна', N'89275733074', N'wrts90puk@yandex.ru', CAST(N'2005-04-29' AS Date), 1, N'2x_J12xpyO')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (22, N'Даниил', N'Голубев', N'Михайлович', N'89443369222', N'yxunv@gmail.com', CAST(N'1975-10-05' AS Date), 1, N'OMOM_6Vl9w')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (23, N'Оливия', N'Хохлова', N'Платоновна', N'89345249482', N'7y@yandex.ru', CAST(N'1988-05-06' AS Date), 2, N'v6oW3-sQUy')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (24, N'Никита', N'Захаров', N'Лукич', N'89592339062', N'6@mail.ru', CAST(N'2007-10-09' AS Date), 2, N'M7yP_pV4dR')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (25, N'Даниил', N'Смирнов', N'Кириллович', N'89304414842', N'k8sjebg1y@mail.ru', CAST(N'2001-04-05' AS Date), 1, N'5pjRrqM5-C')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (26, N'Тамара', N'Бородина', N'Борисовна', N'89551726953', N'jirbold@gmail.com', CAST(N'1986-07-09' AS Date), 2, N'kVtZWr5_eU')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (27, N'Ева', N'Андреева', N'Андреевна', N'89122451569', N'u7yhwf1vb@mail.ru', CAST(N'2022-06-27' AS Date), 2, N'bm7ev8_J-x')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (28, N'Виктория', N'Ермолаева', N'Александровна', N'89570812368', N'f@outlook.com', CAST(N'1978-11-12' AS Date), 2, N'Ma7oeNKK-z')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (29, N'Виктория', N'Исаева', N'Михайловна', N'89674059868', N'gjkhp@mail.ru', CAST(N'1975-04-23' AS Date), 1, N'UtyM-rAps3')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (30, N'Лидия', N'Сидорова', N'Львовна', N'89405627367', N'wyalkxfde@gmail.com', CAST(N'1972-08-22' AS Date), 2, N'3LPlNxONd_')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (31, N'Савелий', N'Чернышев', N'Викторович', N'89456989588', N'f245n@outlook.com', CAST(N'1983-10-24' AS Date), 1, N'JP-M6sKn32')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (32, N'Андрей', N'Романов', N'Артёмович', N'89342989868', N'w@outlook.com', CAST(N'1975-12-21' AS Date), 1, N'v-3LjZNCMT')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (33, N'Максим', N'Журавлев', N'Ильич', N'89973030097', N'js3kyopz@mail.ru', CAST(N'1985-04-10' AS Date), 2, N'dko10W_2W8')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (34, N'Денис', N'Степанов', N'Германович', N'89161130209', N'o@outlook.com', CAST(N'1972-10-27' AS Date), 1, N'O8-_7a4QYd')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (35, N'Анастасия', N'Алешина', N'Кирилловна', N'89125346837', N'uzfd@mail.ru', CAST(N'1991-08-09' AS Date), 1, N'KK-nOqGrb6')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (36, N'Анна', N'Кузьмина', N'Демидовна', N'89081621351', N'g@mail.ru', CAST(N'2011-03-12' AS Date), 1, N'HYEA_tu6wu')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (37, N'Евгений', N'Сергеев', N'Артёмович', N'89222455792', N'dvjf0@gmail.com', CAST(N'1998-03-17' AS Date), 2, N'O732WxH9_k')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (38, N'Михаил', N'Орлов', N'Даниилович', N'89042986673', N'd2mc@outlook.com', CAST(N'2020-11-03' AS Date), 1, N'i-n3usZQM_')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (39, N'София', N'Борисова', N'Марковна', N'89499256334', N'06lk@mail.ru', CAST(N'2012-05-14' AS Date), 1, N'ykjV7Wh-T7')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (40, N'Елизавета', N'Гаврилова', N'Владимировна', N'89331819104', N'emhzysf2@yandex.ru', CAST(N'1982-12-03' AS Date), 1, N'Nc_OxYc8uT')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (41, N'Матвей', N'Сазонов', N'Демьянович', N'89885705913', N'd1w28lkg@yandex.ru', CAST(N'2012-01-10' AS Date), 2, N'ooO7Zr_zsW')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (42, N'Ольга', N'Головина', N'Владимировна', N'89235944350', N't93@mail.ru', CAST(N'2003-11-25' AS Date), 2, N'eXG-brYrl2')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (43, N'Асия', N'Смирнова', N'Григорьевна', N'89980217522', N't3i@outlook.com', CAST(N'2022-11-10' AS Date), 2, N'Gx-3ZP7BwF')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (44, N'Арина', N'Рогова', N'Алиевна', N'89953812530', N't6ro3@gmail.com', CAST(N'2007-10-02' AS Date), 2, N'_xWy-x4zyd')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (45, N'Алиса', N'Морозова', N'Александровна', N'89320610093', N'1zqnk0y7@yandex.ru', CAST(N'2007-03-31' AS Date), 1, N'0-ryBVjNfp')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (46, N'Павел', N'Ефимов', N'Ярославович', N'89667632031', N'768ptl4nv@gmail.com', CAST(N'1983-06-22' AS Date), 1, N'aH_49WE8zi')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (47, N'Анастасия', N'Туманова', N'Дмитриевна', N'89693116753', N'bzq3yh2c1@mail.ru', CAST(N'2006-11-22' AS Date), 1, N'6Mc_OtpwE2')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (48, N'Лада', N'Алексеева', N'Денисовна', N'89572920462', N'78k3dvwx@outlook.com', CAST(N'2000-11-19' AS Date), 1, N'3VQd3t_XVU')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (49, N'Мария', N'Смирнова', N'Данииловна', N'89790503675', N'74wwdvwx@outlook.com', CAST(N'1979-11-18' AS Date), 1, N'bxnGYSG9_c')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (50, N'Всеволод', N'Воробьев', N'Романович', N'89574601389', N'bzq332h2c1@mail.ru', CAST(N'2018-04-30' AS Date), 2, N'MpyF-2rZEs')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (53, N'Вячеслав', N'Дрочипенко', N'Анатольевич', N'89756376553', N'1', CAST(N'2018-12-12' AS Date), 1, N'1')
INSERT [dbo].[Client] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender], [Password]) VALUES (54, N'2', N'2', N'2', N'78965412364', N'2', CAST(N'2023-04-19' AS Date), 1, N'2')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Document] ON 

INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (1, N'ссылка 1', 6)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (2, N'ссылка 1', 6)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (3, N'ссылка 2', 22)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (4, N'ссылка 3', 50)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (5, N'ссылка 4', 34)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (6, N'ссылка 5', 11)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (7, N'ссылка 6', 17)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (8, N'ссылка 7', 26)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (9, N'ссылка 8', 35)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (10, N'ссылка 9', 35)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (11, N'ссылка 10', 18)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (12, N'ссылка 11', 46)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (13, N'ссылка 12', 48)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (14, N'ссылка 13', 28)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (15, N'ссылка 14', 2)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (16, N'ссылка 15', 37)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (17, N'ссылка 16', 13)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (18, N'ссылка 17', 38)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (19, N'ссылка 18', 44)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (20, N'ссылка 19', 4)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (21, N'ссылка 20', 17)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (22, N'ссылка 21', 41)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (23, N'ссылка 22', 5)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (24, N'ссылка 23', 5)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (25, N'ссылка 24', 3)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (26, N'ссылка 25', 14)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (27, N'ссылка 26', 16)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (28, N'ссылка 27', 29)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (29, N'ссылка 28', 9)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (30, N'ссылка 29', 1)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (31, N'ссылка 30', 33)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (32, N'ссылка 31', 11)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (33, N'ссылка 32', 40)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (34, N'ссылка 33', 32)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (35, N'ссылка 34', 12)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (36, N'ссылка 35', 47)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (37, N'ссылка 36', 41)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (38, N'ссылка 37', 44)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (39, N'ссылка 38', 47)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (40, N'ссылка 39', 22)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (41, N'ссылка 40', 18)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (42, N'ссылка 41', 37)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (43, N'ссылка 42', 7)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (44, N'ссылка 43', 43)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (45, N'ссылка 44', 9)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (46, N'ссылка 45', 32)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (47, N'ссылка 46', 39)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (48, N'ссылка 47', 37)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (49, N'ссылка 48', 14)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (50, N'ссылка 49', 17)
INSERT [dbo].[Document] ([Id], [FileList], [IdClient]) VALUES (51, N'ссылка 50', 47)
SET IDENTITY_INSERT [dbo].[Document] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (1, N'Дмитрий', N'Носов', N'Матвеевич', N'89384706095', N'kaft93x@outlook.com', CAST(N'1995-11-09' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (2, N'Артём', N'Макеев', N'Александрович', N'89714482386', N'dcu@yandex.ru', CAST(N'1984-05-19' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (3, N'Тимур', N'Осипов', N'Матвеевич', N'89562100769', N'19dn@outlook.com', CAST(N'2008-06-27' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (4, N'Всеволод', N'Аксенов', N'Алексеевич', N'89341879518', N'pa5h@mail.ru', CAST(N'1980-07-08' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (5, N'Константин', N'Максимов', N'Константинович', N'89167445641', N'281av0@gmail.com', CAST(N'1977-11-10' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (6, N'Даниил', N'Козлов', N'Дмитриевич', N'89200855967', N'8edmfh@outlook.com', CAST(N'1980-02-03' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (7, N'Леон', N'Жуков', N'Матвеевич', N'89790872333', N'sfn13i@mail.ru', CAST(N'2009-04-07' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (8, N'Диана', N'Смирнова', N'Михайловна', N'89615402856', N'g0orc3x1@outlook.com', CAST(N'2022-10-03' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (9, N'Максим', N'Лаптев', N'Глебович', N'89996247992', N'rv7bp@gmail.com', CAST(N'2015-05-22' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (10, N'Макар', N'Митрофанов', N'Даниилович', N'89701590358', N'93@outlook.com', CAST(N'1983-09-22' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (11, N'Мирон', N'Андреев', N'Павлович', N'89279526292', N'er@gmail.com', CAST(N'2017-03-13' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (12, N'Мария', N'Иванова', N'Ивановна', N'89330251800', N'o0my@gmail.com', CAST(N'1986-10-02' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (13, N'Василиса', N'Рыжова', N'Матвеевна', N'89007830564', N'715qy08@gmail.com', CAST(N'2006-02-03' AS Date), 1)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (14, N'Артём', N'Маркелов', N'Леонидович', N'89710960988', N'vubx0t@mail.ru', CAST(N'1974-02-04' AS Date), 2)
INSERT [dbo].[Employee] ([Id], [FirstName], [LastName], [Patronymic], [Phone], [Email], [Birthday], [IdGender]) VALUES (15, N'Мирослава', N'Грибова', N'Андреевна', N'89493658921', N'wnhborq@outlook.com', CAST(N'1990-09-04' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Gender] ON 

INSERT [dbo].[Gender] ([Id], [Title]) VALUES (1, N'M')
INSERT [dbo].[Gender] ([Id], [Title]) VALUES (2, N'Ж')
SET IDENTITY_INSERT [dbo].[Gender] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (1, 1, 2, CAST(N'1998-09-20T09:43:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (2, 13, 5, CAST(N'1993-06-10T08:56:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (3, 14, 3, CAST(N'2008-03-29T12:43:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (4, 18, 14, CAST(N'1973-07-17T10:09:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (5, 50, 8, CAST(N'1997-05-07T09:44:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (6, 11, 13, CAST(N'2010-09-28T22:32:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (7, 40, 13, CAST(N'1993-01-19T09:04:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (8, 15, 9, CAST(N'2014-05-02T20:16:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (9, 43, 11, CAST(N'2011-05-06T04:58:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (10, 26, 3, CAST(N'1989-11-26T09:20:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (11, 6, 15, CAST(N'1982-09-02T12:17:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (12, 28, 11, CAST(N'1989-07-13T02:15:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (13, 24, 2, CAST(N'1999-01-31T23:27:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (14, 36, 12, CAST(N'1995-09-28T14:54:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (15, 46, 8, CAST(N'2011-06-02T17:35:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (16, 13, 12, CAST(N'2021-10-01T06:26:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (17, 42, 1, CAST(N'2010-10-28T08:21:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (18, 44, 11, CAST(N'2011-05-03T09:26:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (19, 48, 13, CAST(N'1970-08-01T18:31:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (20, 18, 4, CAST(N'2006-05-26T21:05:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (21, 2, 2, CAST(N'1995-05-17T09:01:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (22, 14, 15, CAST(N'1971-01-04T14:15:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (23, 22, 11, CAST(N'1976-10-11T00:46:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (24, 4, 13, CAST(N'1998-06-27T16:11:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (25, 11, 5, CAST(N'2007-10-26T22:05:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (26, 40, 11, CAST(N'1987-06-30T05:19:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (27, 3, 1, CAST(N'2004-09-10T03:43:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (28, 1, 11, CAST(N'2012-09-03T02:54:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (29, 26, 11, CAST(N'2011-09-18T11:11:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (30, 16, 10, CAST(N'2007-02-23T08:41:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (31, 16, 8, CAST(N'2012-05-08T21:47:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (32, 43, 12, CAST(N'2023-01-03T16:43:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (33, 16, 13, CAST(N'1979-10-13T14:09:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (34, 31, 3, CAST(N'1970-06-21T13:11:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (35, 10, 3, CAST(N'1999-03-25T10:34:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (36, 12, 8, CAST(N'1992-01-15T06:51:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (37, 42, 15, CAST(N'2012-05-14T06:28:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (38, 48, 9, CAST(N'1991-01-07T03:10:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (39, 26, 10, CAST(N'1987-10-13T07:22:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (40, 30, 5, CAST(N'2003-09-17T05:51:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (41, 46, 13, CAST(N'2002-08-21T11:15:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (42, 45, 6, CAST(N'1987-10-15T19:02:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (43, 12, 7, CAST(N'1990-09-09T03:14:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (44, 47, 9, CAST(N'2019-04-24T06:39:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (45, 42, 7, CAST(N'1987-08-14T16:12:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (46, 12, 15, CAST(N'2011-10-16T02:16:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (47, 11, 13, CAST(N'2012-01-29T03:46:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (48, 29, 7, CAST(N'1987-04-21T09:15:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (49, 36, 12, CAST(N'2007-06-04T20:23:00.000' AS DateTime))
INSERT [dbo].[Order] ([Id], [IdClient], [IdEmployee], [Date]) VALUES (50, 10, 3, CAST(N'1975-03-08T08:53:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderProduct] ON 

INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (1, 38, 1)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (2, 8, 2)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (2, 42, 3)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (2, 43, 4)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (4, 24, 5)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (5, 49, 6)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (6, 5, 7)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (6, 9, 8)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (8, 23, 9)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (10, 26, 10)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (11, 15, 11)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (12, 29, 12)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (13, 34, 13)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (14, 43, 14)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (14, 47, 15)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (18, 19, 16)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (18, 23, 17)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (19, 6, 18)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (19, 12, 19)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (21, 39, 20)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (21, 45, 21)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (22, 15, 22)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (22, 25, 23)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (23, 2, 24)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (23, 33, 25)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (25, 19, 26)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (26, 3, 27)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (27, 3, 28)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (27, 31, 29)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (31, 2, 30)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (33, 1, 31)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (34, 3, 32)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (34, 21, 33)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (35, 19, 34)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (38, 27, 35)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (39, 6, 36)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (39, 30, 37)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (40, 4, 38)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (40, 38, 39)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (41, 14, 40)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (42, 28, 41)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (43, 19, 42)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (45, 41, 43)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (46, 14, 44)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (46, 28, 45)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (48, 18, 46)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (48, 22, 47)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (49, 2, 48)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (49, 21, 49)
INSERT [dbo].[OrderProduct] ([IdOrder], [IdProduct], [Id]) VALUES (50, 25, 50)
SET IDENTITY_INSERT [dbo].[OrderProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([Id], [Title], [Description]) VALUES (1, N'Уборщик', NULL)
INSERT [dbo].[Post] ([Id], [Title], [Description]) VALUES (2, N'Продавец', NULL)
INSERT [dbo].[Post] ([Id], [Title], [Description]) VALUES (3, N'Администратор', NULL)
SET IDENTITY_INSERT [dbo].[Post] OFF
GO
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (1, 1)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (1, 4)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (1, 15)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (2, 2)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (2, 3)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (2, 7)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (2, 8)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (2, 9)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (2, 10)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (2, 12)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (3, 5)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (3, 6)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (3, 11)
INSERT [dbo].[PostEmployee] ([IdPost], [IdEmployee]) VALUES (3, 13)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (1, N'Nova', N'', CAST(20175987.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (2, N'XM1014', N'', CAST(72151169.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (3, N'Sawed-Off', N'', CAST(58351934.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (4, N'MAG-7', N'', CAST(83633599.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (5, N'M249', N'', CAST(23235412.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (6, N'Negev', N'', CAST(50526848.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (7, N'MAC-10', N'', CAST(91782212.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (8, N'MP5-SD', N'', CAST(36276491.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (9, N'MP7', N'', CAST(64392794.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (10, N'MP9', N'', CAST(40693734.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (11, N'UMP-45', N'', CAST(31675428.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (12, N'P90', N'', CAST(54133463.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (13, N'PP-Bizon', N'', CAST(76938778.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (14, N'Galil', N'', CAST(4925235.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (15, N'FAMAS', N'', CAST(71176611.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (16, N'AK-47', N'', CAST(75249513.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (17, N'M4A4', N'', CAST(70635910.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (18, N'M4A1-S', N'', CAST(43658074.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (19, N'AUG', N'', CAST(82361158.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (20, N'SG', N'', CAST(97307317.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (21, N'SSG', N'', CAST(79618257.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (22, N'AWP', N'', CAST(50651725.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (23, N'G3SG1', N'', CAST(1485751.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (24, N'SCAR-20', N'', CAST(32201452.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (25, N'Glock-18', N'', CAST(68669728.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (26, N'USP-S', N'', CAST(43581804.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (27, N'P2000', N'', CAST(13231056.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (28, N'Five-Seven', N'', CAST(12202099.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (29, N'Dual', N'', CAST(80105221.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (30, N'P250', N'', CAST(4679875.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (31, N'Tec-9', N'', CAST(34802488.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (32, N'CZ75-Auto', N'', CAST(58654159.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (33, N'Desert', N'', CAST(11556457.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (34, N'R8', N'', CAST(14286343.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (35, N'Миротворец', N'', CAST(84471860.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (36, N'EVA-8 АВТО', N'', CAST(50819710.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (37, N'Мозамбик', N'', CAST(47887484.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (38, N'Мастифф', N'', CAST(91021119.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (39, N'RE-45', N'', CAST(98645186.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (40, N'P2020', N'', CAST(30819.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (41, N'Ведомый', N'', CAST(12682431.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (42, N'Сменщик', N'', CAST(90196736.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (43, N'R-99', N'', CAST(48797621.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (44, N'Ищейка', N'', CAST(80575781.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (45, N'R-301', N'', CAST(6709973.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (46, N'Флэтлайн', N'', CAST(95643079.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (47, N'Хемлок', N'', CAST(37322572.00 AS Decimal(10, 2)), 5)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (48, N'Спитфайр', N'', CAST(98553938.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (49, N'Преданность', N'', CAST(90858533.00 AS Decimal(10, 2)), 4)
INSERT [dbo].[Product] ([Id], [Title], [Description], [Cost], [IdCategory]) VALUES (50, N'Бабочка', NULL, CAST(16421.00 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Gender] FOREIGN KEY([IdGender])
REFERENCES [dbo].[Gender] ([Id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Gender]
GO
ALTER TABLE [dbo].[Document]  WITH CHECK ADD  CONSTRAINT [FK_Document_Client] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([Id])
GO
ALTER TABLE [dbo].[Document] CHECK CONSTRAINT [FK_Document_Client]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Gender] FOREIGN KEY([IdGender])
REFERENCES [dbo].[Gender] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Gender]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Client] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Client]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employee] FOREIGN KEY([IdEmployee])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employee]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Order] FOREIGN KEY([IdOrder])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Order]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Product] FOREIGN KEY([IdProduct])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Product]
GO
ALTER TABLE [dbo].[PostEmployee]  WITH CHECK ADD  CONSTRAINT [FK_PostEmployee_Employee] FOREIGN KEY([IdEmployee])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[PostEmployee] CHECK CONSTRAINT [FK_PostEmployee_Employee]
GO
ALTER TABLE [dbo].[PostEmployee]  WITH CHECK ADD  CONSTRAINT [FK_PostEmployee_Post] FOREIGN KEY([IdPost])
REFERENCES [dbo].[Post] ([Id])
GO
ALTER TABLE [dbo].[PostEmployee] CHECK CONSTRAINT [FK_PostEmployee_Post]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([IdCategory])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
