USE [Test]
GO
/****** Object:  Table [dbo].[m_movie]    Script Date: 03/01/2023 21:23:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_movie](
	[id_movie] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[desciption] [varchar](max) NULL,
	[duration] [int] NULL,
	[artist] [varchar](50) NULL,
	[genres] [varchar](50) NULL,
	[watch_url] [varchar](50) NULL,
	[views] [int] NULL,
 CONSTRAINT [PK_m_movie] PRIMARY KEY CLUSTERED 
(
	[id_movie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[m_user]    Script Date: 03/01/2023 21:23:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[m_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](20) NULL,
	[password] [varchar](20) NULL,
	[role] [int] NULL,
	[createdDate] [datetime] NULL,
	[createdBy] [int] NULL,
 CONSTRAINT [PK_m_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[m_movie] ON 

INSERT [dbo].[m_movie] ([id_movie], [title], [desciption], [duration], [artist], [genres], [watch_url], [views]) VALUES (1, N'expendable', N'tembak tembakan', 120, N'stallone, statham', N'action', N'https://www.youtube.com/watch?v=8KtYRALe-xo', 20)
INSERT [dbo].[m_movie] ([id_movie], [title], [desciption], [duration], [artist], [genres], [watch_url], [views]) VALUES (2, N'kotaro', N'anak kecil', 120, N'kotaro', N'anime', N'https://www.youtube.com/watch?v=WLzmLUtVkxA', 5)
INSERT [dbo].[m_movie] ([id_movie], [title], [desciption], [duration], [artist], [genres], [watch_url], [views]) VALUES (3, N'transpormer', N'robot', 131, N'optimus', N'action', N'https://www.youtube.com/watch?v=WWWDskI46Js', 86)
INSERT [dbo].[m_movie] ([id_movie], [title], [desciption], [duration], [artist], [genres], [watch_url], [views]) VALUES (4, N'big bang theory', N'komedi', 130, N'bianca', N'comedy', N'https://www.youtube.com/watch?v=YLz8deK4uuM', 95)
INSERT [dbo].[m_movie] ([id_movie], [title], [desciption], [duration], [artist], [genres], [watch_url], [views]) VALUES (5, N'apengers', N'super hero', 120, N'iron man', N'action', N'https://www.youtube.com/watch?v=eOrNdBpGMv8', 155)
INSERT [dbo].[m_movie] ([id_movie], [title], [desciption], [duration], [artist], [genres], [watch_url], [views]) VALUES (6, N'updateeeee', N'sample string 3', 1, N'sample string 4', N'sample string 5', N'sample string 6', 1)
INSERT [dbo].[m_movie] ([id_movie], [title], [desciption], [duration], [artist], [genres], [watch_url], [views]) VALUES (7, N'updateeeee sincan', N'hahaha', 99, N'misaeeee', N'comedy', N'wwwwwwww', 2)
SET IDENTITY_INSERT [dbo].[m_movie] OFF
GO
SET IDENTITY_INSERT [dbo].[m_user] ON 

INSERT [dbo].[m_user] ([id], [username], [password], [role], [createdDate], [createdBy]) VALUES (1, N'rzkypprtm', N'123456', 1, CAST(N'2021-12-11T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[m_user] OFF
GO
