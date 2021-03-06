USE [feedbackcollage]
GO
/****** Object:  Table [dbo].[teachermaster]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[teachermaster](
	[teacherid] [int] NOT NULL,
	[teachername] [varchar](50) NOT NULL,
	[mobileno] [nchar](15) NOT NULL,
	[emailid] [nvarchar](50) NOT NULL,
	[branchname] [nvarchar](50) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_teachermaster] PRIMARY KEY CLUSTERED 
(
	[teacherid] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TeacherAssgSub]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TeacherAssgSub](
	[Branch] [nvarchar](50) NOT NULL,
	[TeacherName] [nvarchar](50) NOT NULL,
	[Class] [nvarchar](50) NOT NULL,
	[SemesterName] [nvarchar](50) NOT NULL,
	[subjectName] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Teacher_new]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher_new](
	[Branch] [nvarchar](50) NOT NULL,
	[TeacherName] [nvarchar](50) NOT NULL,
	[Class] [nvarchar](50) NOT NULL,
	[SemesterName] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subjectMaster1]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subjectMaster1](
	[Subjectcode] [nvarchar](50) NOT NULL,
	[Subjectname] [nvarchar](50) NOT NULL,
	[Class] [nvarchar](50) NULL,
	[Branch] [nvarchar](50) NULL,
	[SemesterName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studentmaster]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[studentmaster](
	[studentid] [int] NULL,
	[studentname] [varchar](50) NOT NULL,
	[mobileno] [nvarchar](50) NOT NULL,
	[emailid] [nvarchar](50) NOT NULL,
	[branchname] [nvarchar](50) NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[class] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Studentlogin]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Studentlogin](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stafflogin]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stafflogin](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SemesterMaster]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SemesterMaster](
	[SemesterId] [int] NULL,
	[SemesterName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinalFeedback]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinalFeedback](
	[PD] [decimal](18, 2) NULL,
	[DK] [decimal](18, 2) NULL,
	[psskill] [decimal](18, 2) NULL,
	[AD] [decimal](18, 2) NULL,
	[ES] [decimal](18, 2) NULL,
	[PDcount] [decimal](18, 2) NULL,
	[DKcount] [decimal](18, 2) NULL,
	[psskillcount] [decimal](18, 2) NULL,
	[ADcount] [decimal](18, 2) NULL,
	[EScount] [decimal](18, 2) NULL,
	[branch] [nvarchar](50) NOT NULL,
	[class] [nvarchar](50) NOT NULL,
	[teacher] [nvarchar](50) NOT NULL,
	[subject] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[feedback]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[feedback](
	[branch] [nvarchar](50) NOT NULL,
	[class] [nvarchar](50) NOT NULL,
	[subject] [nvarchar](50) NOT NULL,
	[teacher] [nvarchar](50) NOT NULL,
	[PD] [decimal](18, 2) NOT NULL,
	[DK] [decimal](18, 2) NOT NULL,
	[psskill] [decimal](18, 2) NOT NULL,
	[AD] [decimal](18, 2) NOT NULL,
	[ES] [decimal](18, 2) NOT NULL,
	[semister] [nvarchar](50) NOT NULL,
	[Studentname] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[demo1]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[demo1](
	[id] [int] NULL,
	[name] [varchar](1) NULL,
	[address] [varchar](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[demo]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[demo](
	[id] [int] NULL,
	[name] [varchar](1) NULL,
	[address] [varchar](1) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[branchmaster]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[branchmaster](
	[branchid] [int] NOT NULL,
	[branchname] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adminlogin]    Script Date: 02/23/2020 11:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Adminlogin](
	[UserName] [varchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
