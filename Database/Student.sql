 use [SAid]
CREATE TABLE [dbo].[Business_Idea](
	[Idea_No] [int] NOT NULL,
	[Description] [varchar](150) NOT NULL,
	[Student_ID] [int] NOT NULL,
	[Sponsor_ID] [int] NOT NULL,
 CONSTRAINT [PK_Business_Idea] PRIMARY KEY CLUSTERED 
(
	[Idea_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contests]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contests](
	[Contest_No] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Link] [varchar](50) NULL,
	[Location] [varchar](50) NOT NULL,
	[Time] [varchar](50) NOT NULL,
	[Prize] [varchar](50) NOT NULL,
	[Theme] [varchar](50) NOT NULL,
	[Sponsor_ID] [int] NOT NULL,
 CONSTRAINT [PK_Contests] PRIMARY KEY CLUSTERED 
(
	[Contest_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Course_OfferedBy_Doctors]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course_OfferedBy_Doctors](
	[Course_No] [int] NOT NULL,
	[Doctor_ID] [int] NOT NULL,
 CONSTRAINT [PK_Course_OfferedBy_Doctors] PRIMARY KEY CLUSTERED 
(
	[Course_No] ASC,
	[Doctor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Courses]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Courses](
	[Course_No] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Link] [varchar](50) NULL,
	[Level] [int] NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Course_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctor_Gives_Student_GradesInCourse]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctor_Gives_Student_GradesInCourse](
	[Doctor_ID] [int] NOT NULL,
	[Student_ID] [int] NOT NULL,
	[Course_No] [int] NOT NULL,
	[Grade] [varchar](1) NULL,
 CONSTRAINT [PK_Doctor_Gives_Student_GradesInCourse] PRIMARY KEY CLUSTERED 
(
	[Doctor_ID] ASC,
	[Student_ID] ASC,
	[Course_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctor_Publishes_RPapers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor_Publishes_RPapers](
	[Doctor_ID] [int] NOT NULL,
	[RPapers_No] [int] NOT NULL,
 CONSTRAINT [PK_Doctor_Publishes_RPapers] PRIMARY KEY CLUSTERED 
(
	[Doctor_ID] ASC,
	[RPapers_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor_Replies_Community_ToAPost]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor_Replies_Community_ToAPost](
	[Doctor_ID] [int] NOT NULL,
	[Post_No] [int] NOT NULL,
	[Reply_Post_No] [int] NOT NULL,
 CONSTRAINT [PK_Doctor_Replies_Community_ToAPost] PRIMARY KEY CLUSTERED 
(
	[Doctor_ID] ASC,
	[Post_No] ASC,
	[Reply_Post_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor_Upload_Textbook_ToCourse]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor_Upload_Textbook_ToCourse](
	[Doctor_ID] [int] NOT NULL,
	[Course_No] [int] NOT NULL,
	[Textbook_No] [int] NOT NULL,
 CONSTRAINT [PK_Doctor_Upload_Textbook_ToCourse] PRIMARY KEY CLUSTERED 
(
	[Doctor_ID] ASC,
	[Course_No] ASC,
	[Textbook_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor_Uploads_Seminar]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor_Uploads_Seminar](
	[Doctor_ID] [int] NOT NULL,
	[Seminar_No] [int] NOT NULL,
 CONSTRAINT [PK_Doctor_Uploads_Seminar] PRIMARY KEY CLUSTERED 
(
	[Doctor_ID] ASC,
	[Seminar_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctors](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Feedback]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Feedback](
	[Feedback_No] [int] NOT NULL,
	[Course_No] [int] NOT NULL,
	[Rating] [float] NOT NULL,
	[Description] [varchar](150) NULL,
 CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED 
(
	[Feedback_No] ASC,
	[Course_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Internship_Prerequisites]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Internship_Prerequisites](
	[Internship_No] [int] NOT NULL,
	[Prerequisites] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Internship_Prerequisites] PRIMARY KEY CLUSTERED 
(
	[Internship_No] ASC,
	[Prerequisites] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Internships]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Internships](
	[Internship_ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Link] [varchar](50) NULL,
	[Start] [varchar](50) NOT NULL,
	[EndDate] [varchar](50) NOT NULL,
	[Sponsor_ID] [int] NOT NULL,
 CONSTRAINT [PK_Internships] PRIMARY KEY CLUSTERED 
(
	[Internship_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Post_Community]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post_Community](
	[Post_No] [int] NOT NULL,
	[Text] [text] NOT NULL,
 CONSTRAINT [PK_Post_Community] PRIMARY KEY CLUSTERED 
(
	[Post_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Project_Team]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project_Team](
	[Team_No] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](150) NULL,
	[TeamLeader_ID] [int] NOT NULL,
 CONSTRAINT [PK_Project_Team] PRIMARY KEY CLUSTERED 
(
	[Team_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project_Team_Requirements]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Project_Team_Requirements](
	[Team_No] [int] NOT NULL,
	[Requirement] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Project_Team_Requirementss] PRIMARY KEY CLUSTERED 
(
	[Team_No] ASC,
	[Requirement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProjectTeam_Joins_Contests]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectTeam_Joins_Contests](
	[Team_No] [int] NOT NULL,
	[Contest_No] [int] NOT NULL,
 CONSTRAINT [PK_ProjectTeam_Joins_Contests] PRIMARY KEY CLUSTERED 
(
	[Team_No] ASC,
	[Contest_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RPapers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RPapers](
	[RPaper_No] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Link] [varchar](50) NULL,
	[Publisher] [varchar](50) NULL,
 CONSTRAINT [PK_RPapers] PRIMARY KEY CLUSTERED 
(
	[RPaper_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Seminars]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Seminars](
	[Seminar_No] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Link] [varchar](50) NULL,
	[Presenter] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Doctor_Presents_Seminar] PRIMARY KEY CLUSTERED 
(
	[Seminar_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sponsor_Accepts_Student_inInternship]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sponsor_Accepts_Student_inInternship](
	[Sponsor_ID] [int] NOT NULL,
	[Student_ID] [int] NOT NULL,
	[Internship_ID] [int] NOT NULL,
 CONSTRAINT [PK_Sponsor_Accepts_Student_inInternship] PRIMARY KEY CLUSTERED 
(
	[Sponsor_ID] ASC,
	[Student_ID] ASC,
	[Internship_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sponsor_Replies_Community_ToAPost]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sponsor_Replies_Community_ToAPost](
	[Sponsor_ID] [int] NOT NULL,
	[Post_No] [int] NOT NULL,
	[Reply_Post_No] [int] NOT NULL,
 CONSTRAINT [PK_Sponsor_Replies_Community_ToAPost] PRIMARY KEY CLUSTERED 
(
	[Sponsor_ID] ASC,
	[Post_No] ASC,
	[Reply_Post_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sponsors]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sponsors](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sponsers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student_Goes_Contests]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Goes_Contests](
	[Student_ID] [int] NOT NULL,
	[Contest_No] [int] NOT NULL,
 CONSTRAINT [PK_Student_Goes_Contests] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC,
	[Contest_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Joins_ProjectTeam]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Joins_ProjectTeam](
	[Student_ID] [int] NOT NULL,
	[Team_No] [int] NOT NULL,
 CONSTRAINT [PK_Student_Joins_ProjectTeam] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC,
	[Team_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Loads_Textbook]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Loads_Textbook](
	[Student_ID] [int] NOT NULL,
	[Textbook_No] [int] NOT NULL,
 CONSTRAINT [PK_Student_Loads_Textbook] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC,
	[Textbook_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Posts_Community]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Posts_Community](
	[Student_ID] [int] NOT NULL,
	[Post_No] [int] NOT NULL,
 CONSTRAINT [PK_Student_Posts_Community] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC,
	[Post_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Replies_Community_ToAPost]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Replies_Community_ToAPost](
	[Student_ID] [int] NOT NULL,
	[Post_No] [int] NOT NULL,
	[Reply_Post_No] [int] NOT NULL,
 CONSTRAINT [PK_Student_Replies_Community_ToAPost] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC,
	[Post_No] ASC,
	[Reply_Post_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Request_Internship]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Request_Internship](
	[Student_ID] [int] NOT NULL,
	[Internship_ID] [int] NOT NULL,
 CONSTRAINT [PK_Student_Request_Internship] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC,
	[Internship_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student_Takes_Courses]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Takes_Courses](
	[Student_ID] [int] NOT NULL,
	[Course_No] [int] NOT NULL,
 CONSTRAINT [PK_Student_Takes_Courses] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC,
	[Course_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Textbook]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Textbook](
	[Textbook_No] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Link] [varchar](50) NULL,
	[Publisher] [varchar](50) NULL,
 CONSTRAINT [PK_Textbook] PRIMARY KEY CLUSTERED 
(
	[Textbook_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Business_Idea] ([Idea_No], [Description], [Student_ID], [Sponsor_ID]) VALUES (5001, N'My idea is to make houses use solar energy instead of electricity', 1170002, 97001)
GO
INSERT [dbo].[Business_Idea] ([Idea_No], [Description], [Student_ID], [Sponsor_ID]) VALUES (5002, N'My idea is to start using different frequencies in the networking system of the companies', 1170035, 97008)
GO
INSERT [dbo].[Business_Idea] ([Idea_No], [Description], [Student_ID], [Sponsor_ID]) VALUES (5003, N'My idea is to start using smaller amounts of ICs in producing chips', 1170009, 97006)
GO
INSERT [dbo].[Business_Idea] ([Idea_No], [Description], [Student_ID], [Sponsor_ID]) VALUES (5004, N'My idea is to make a new application that divides the amount of work on the number of hours and the person''s power', 1170026, 97002)
GO
INSERT [dbo].[Contests] ([Contest_No], [Name], [Link], [Location], [Time], [Prize], [Theme], [Sponsor_ID]) VALUES (2001, N'Data Structures Contest', N'www.dsforfun.com', N'Maadi', N'7th of December 2019', N'certificate', N'algorithms', 97004)
GO
INSERT [dbo].[Contests] ([Contest_No], [Name], [Link], [Location], [Time], [Prize], [Theme], [Sponsor_ID]) VALUES (2002, N'Electronics Contest', N'www.elcforgeeks.com', N'Mohandessin', N'12nd of January 2020', N'trip', N'ICs', 97006)
GO
INSERT [dbo].[Contests] ([Contest_No], [Name], [Link], [Location], [Time], [Prize], [Theme], [Sponsor_ID]) VALUES (2003, N'Risk Management Contest', NULL, N'Nasr City', N'5th of December 2019', N'money', N'hazardous situations', 97007)
GO
INSERT [dbo].[Contests] ([Contest_No], [Name], [Link], [Location], [Time], [Prize], [Theme], [Sponsor_ID]) VALUES (2004, N'DE Solver', N'www.differentialequations.com', N'6th of October', N'9th of February 2020', N'certificate', N'integration', 97003)
GO
INSERT [dbo].[Contests] ([Contest_No], [Name], [Link], [Location], [Time], [Prize], [Theme], [Sponsor_ID]) VALUES (2005, N'Simple Logic Circuit', NULL, N'Maadi', N'13th of March 2020', N'trip', N'logic gates', 97001)
GO
INSERT [dbo].[Course_OfferedBy_Doctors] ([Course_No], [Doctor_ID]) VALUES (57401, 881003)
GO
INSERT [dbo].[Course_OfferedBy_Doctors] ([Course_No], [Doctor_ID]) VALUES (57405, 881002)
GO
INSERT [dbo].[Course_OfferedBy_Doctors] ([Course_No], [Doctor_ID]) VALUES (57406, 881004)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57401, N'Fundamentals of Electronics-1', N'www.elcn101.com', 1)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57402, N'Microprocessors-1', NULL, 2)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57403, N'Introduction To Database', N'www.dbsystems.com', 2)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57404, N'Risk Management', N'www.genn210.com', NULL)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57405, N'Seminar', NULL, 4)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57406, N'Signals Analysis', N'www.elcn203.com', 2)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57407, N'Discrete Mathematics', N'www.discrete104.com', 1)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57408, N'Differential Equations', N'www.khanacademy.com', 1)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57409, N'Logic Design', N'www.cpmn201.com', 0)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57410, N'Circuits-2', NULL, 1)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57411, N'Computer Architecrure', N'www.comparch.com', 3)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57412, N'Networks-1', NULL, 4)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57413, N'Modern Physics', N'www.phyn101.com', 0)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57414, N'Data Structures', N'www.ds201.com', 1)
GO
INSERT [dbo].[Courses] ([Course_No], [Name], [Link], [Level]) VALUES (57415, N'Laboratory', NULL, 2)
GO
INSERT [dbo].[Doctor_Gives_Student_GradesInCourse] ([Doctor_ID], [Student_ID], [Course_No], [Grade]) VALUES (881001, 1170005, 57403, N'A')
GO
INSERT [dbo].[Doctor_Gives_Student_GradesInCourse] ([Doctor_ID], [Student_ID], [Course_No], [Grade]) VALUES (881007, 1170014, 57414, N'C')
GO
INSERT [dbo].[Doctor_Publishes_RPapers] ([Doctor_ID], [RPapers_No]) VALUES (881001, 56401)
GO
INSERT [dbo].[Doctor_Publishes_RPapers] ([Doctor_ID], [RPapers_No]) VALUES (881006, 56400)
GO
INSERT [dbo].[Doctor_Publishes_RPapers] ([Doctor_ID], [RPapers_No]) VALUES (881010, 56404)
GO
INSERT [dbo].[Doctor_Replies_Community_ToAPost] ([Doctor_ID], [Post_No], [Reply_Post_No]) VALUES (881004, 8001, 11001)
GO
INSERT [dbo].[Doctor_Upload_Textbook_ToCourse] ([Doctor_ID], [Course_No], [Textbook_No]) VALUES (881001, 57403, 6005)
GO
INSERT [dbo].[Doctor_Uploads_Seminar] ([Doctor_ID], [Seminar_No]) VALUES (881001, 4180001)
GO
INSERT [dbo].[Doctor_Uploads_Seminar] ([Doctor_ID], [Seminar_No]) VALUES (881002, 4180002)
GO
INSERT [dbo].[Doctor_Uploads_Seminar] ([Doctor_ID], [Seminar_No]) VALUES (881005, 4180004)
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881001, N'Mayada Hadhoud', N'mayadahadhoud1', N'PD44qTSP5T6', N'mayadahadhoud@gmail.com')
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881002, N'Ihab Talkhan', N'ihabtalkhan22', N'c3UmwFwwBq7', N'ihabtalkhan@acu.edu.eg')
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881003, N'Ahmed Nader', N'anader22', N'eqEQSWVv6Cb', N'anaderr22@gmail.com')
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881004, N'Mohamed Fathy', N'mfathy1', N'cuSjLzu3LZk', N'mfathye1@gmail.com')
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881005, N'Mohamed Refky', N'mrefky', N'2gyngNKcWL6', N'mohamedrefky@yahoo.com')
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881006, N'Khaled Mohammed', N'khaledmohammed', N'7EpHs9sfRsW', N'khaledsoradi@gmail.com')
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881007, N'Magda Fayek', N'magdafayek', N'Rsf5T55C6XD', N'magdafayek@hotmail.com')
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881008, N'Hanan El Sersy', N'hananelsersy', N'wHBs5SQxKYf', N'hananelsersy@gmail.com')
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881009, N'Ragia Badr', N'ragiabadr', N'g94Ec8e8vda', N'ragiabadr@yahoo.com')
GO
INSERT [dbo].[Doctors] ([ID], [Name], [Username], [Password], [Email]) VALUES (881010, N'Ahmed Hussein', N'ahussein', N'LbkrHvzD8V6', N'ahussein@gmail.com')
GO
INSERT [dbo].[Feedback] ([Feedback_No], [Course_No], [Rating], [Description]) VALUES (3001, 57401, 4.5, N'It was an interesting course, but I didn''t get the grade I expected')
GO
INSERT [dbo].[Feedback] ([Feedback_No], [Course_No], [Rating], [Description]) VALUES (3002, 57402, 4, N'It had a lot of work to do, and made me drop other subject..')
GO
INSERT [dbo].[Feedback] ([Feedback_No], [Course_No], [Rating], [Description]) VALUES (3003, 57407, 3, N'It was one of the harshest courses in my college life.')
GO
INSERT [dbo].[Feedback] ([Feedback_No], [Course_No], [Rating], [Description]) VALUES (3004, 57408, 5, N'It was an amazing course and I really liked it.')
GO
INSERT [dbo].[Feedback] ([Feedback_No], [Course_No], [Rating], [Description]) VALUES (3005, 57403, 4.8, N'')
GO
INSERT [dbo].[Internship_Prerequisites] ([Internship_No], [Prerequisites]) VALUES (7002, N'Fundamentals of Electronics-1')
GO
INSERT [dbo].[Internships] ([Internship_ID], [Name], [Link], [Start], [EndDate], [Sponsor_ID]) VALUES (7001, N'Mechanical Engineering Internship', N'www.mechainterns.com', N'9th of January 2019', N'1st of February 2019', 97007)
GO
INSERT [dbo].[Internships] ([Internship_ID], [Name], [Link], [Start], [EndDate], [Sponsor_ID]) VALUES (7002, N'Electronics Internship', NULL, N'5th of March', N'22nd of March', 97006)
GO
INSERT [dbo].[Internships] ([Internship_ID], [Name], [Link], [Start], [EndDate], [Sponsor_ID]) VALUES (7003, N'Software Internship', N'www.softwareinterns.com', N'22nf of March', N'5th of April', 97004)
GO
INSERT [dbo].[Post_Community] ([Post_No], [Text]) VALUES (8001, N'I want to ask whether I should take the Signals Analysis course in the Junior year first semester or not?')
GO
INSERT [dbo].[Project_Team] ([Team_No], [Name], [Description], [TeamLeader_ID]) VALUES (4001, N'Team_1', N'Micro team of 4 students, and making a ghost hunter game as a project', 1170005)
GO
INSERT [dbo].[Project_Team] ([Team_No], [Name], [Description], [TeamLeader_ID]) VALUES (4002, N'Team_2', N'DB team of 3 students, and making a hotel database as a project', 1170019)
GO
INSERT [dbo].[Project_Team] ([Team_No], [Name], [Description], [TeamLeader_ID]) VALUES (4003, N'Team_3', N'Micro team of 4 students, and making pacman game as a project', 1170022)
GO
INSERT [dbo].[Project_Team] ([Team_No], [Name], [Description], [TeamLeader_ID]) VALUES (4004, N'Team_4', NULL, 1170001)
GO
INSERT [dbo].[Project_Team] ([Team_No], [Name], [Description], [TeamLeader_ID]) VALUES (4005, N'Team_5', N'DB team of 4 students, and making a hospital database as aproject', 1170015)
GO
INSERT [dbo].[Project_Team_Requirements] ([Team_No], [Requirement]) VALUES (4001, N'Create a DB')
GO
INSERT [dbo].[ProjectTeam_Joins_Contests] ([Team_No], [Contest_No]) VALUES (2001, 4003)
GO
INSERT [dbo].[ProjectTeam_Joins_Contests] ([Team_No], [Contest_No]) VALUES (2003, 4004)
GO
INSERT [dbo].[ProjectTeam_Joins_Contests] ([Team_No], [Contest_No]) VALUES (2005, 4001)
GO
INSERT [dbo].[RPapers] ([RPaper_No], [Name], [Link], [Publisher]) VALUES (56400, N'Introduction to Modern Physics', N'www.intotomodern.com', N'Tamer Abbas')
GO
INSERT [dbo].[RPapers] ([RPaper_No], [Name], [Link], [Publisher]) VALUES (56401, N'Control Systems', N'www.controlsystems.net', N'Heba ElReedy')
GO
INSERT [dbo].[RPapers] ([RPaper_No], [Name], [Link], [Publisher]) VALUES (56402, N'Communications Introduction', N'www.introtocomm.com', N'Tamim ElSayed')
GO
INSERT [dbo].[RPapers] ([RPaper_No], [Name], [Link], [Publisher]) VALUES (56403, N'Logic Design Process', N'www.processoflogic.net', N'Mahmoud Alaa')
GO
INSERT [dbo].[RPapers] ([RPaper_No], [Name], [Link], [Publisher]) VALUES (56404, N'Risk Control', N'www.hazardoussystems.com', N'Noura Gasser')
GO
INSERT [dbo].[Seminars] ([Seminar_No], [Name], [Link], [Presenter]) VALUES (4180001, N'Databases in A Lifetime', N'www.dbforlife.com', N'Injy Ismail')
GO
INSERT [dbo].[Seminars] ([Seminar_No], [Name], [Link], [Presenter]) VALUES (4180002, N'Logically Logical', N'www.logicisfun.com', N'Mohamed Ahmed Mahmoud')
GO
INSERT [dbo].[Seminars] ([Seminar_No], [Name], [Link], [Presenter]) VALUES (4180003, N'Electromagnetics Applications', N'www.emapp.net', N'Samira Adham')
GO
INSERT [dbo].[Seminars] ([Seminar_No], [Name], [Link], [Presenter]) VALUES (4180004, N'Physics Between Newton & Schrodinger', N'www.modernphy.com', N'Mohamed Ismail')
GO
INSERT [dbo].[Seminars] ([Seminar_No], [Name], [Link], [Presenter]) VALUES (4180005, N'The Art of Control', N'www.controllingall.com', N'Fares Dhaher')
GO
INSERT [dbo].[Sponsor_Accepts_Student_inInternship] ([Sponsor_ID], [Student_ID], [Internship_ID]) VALUES (97001, 1170035, 7002)
GO
INSERT [dbo].[Sponsor_Replies_Community_ToAPost] ([Sponsor_ID], [Post_No], [Reply_Post_No]) VALUES (97001, 8001, 12001)
GO
INSERT [dbo].[Sponsors] ([ID], [Name], [Username], [Password], [Email]) VALUES (97001, N'IBM', N'ibm11', N'yGsB8BnXk', N'ibm@ibm.com')
GO
INSERT [dbo].[Sponsors] ([ID], [Name], [Username], [Password], [Email]) VALUES (97002, N'Microsoft', N'microsoftmaster', N'pEwYz58jZ', N'microsoft@microsoft.com')
GO
INSERT [dbo].[Sponsors] ([ID], [Name], [Username], [Password], [Email]) VALUES (97003, N'Telecom', N'telecomuser', N'4LzZLssrF', N'telecom@telecom.com')
GO
INSERT [dbo].[Sponsors] ([ID], [Name], [Username], [Password], [Email]) VALUES (97004, N'Google', N'google12', N'fHtX4RgZ8', N'google@google.com')
GO
INSERT [dbo].[Sponsors] ([ID], [Name], [Username], [Password], [Email]) VALUES (97005, N'DELL', N'dellmaster', N'LF3686DwM', N'dell@dell.com')
GO
INSERT [dbo].[Sponsors] ([ID], [Name], [Username], [Password], [Email]) VALUES (97006, N'Intel', N'inteluser', N'B7wDQNpxM', N'intel@intel.net')
GO
INSERT [dbo].[Sponsors] ([ID], [Name], [Username], [Password], [Email]) VALUES (97007, N'Oracle', N'oraclemaster', N'XPzd3WVV8', N'oracle@oracle.com')
GO
INSERT [dbo].[Sponsors] ([ID], [Name], [Username], [Password], [Email]) VALUES (97008, N'Vodafone', N'vodafoneuser', N'9vuKeSYPD', N'vodafone@vodafone.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170001, N'Ahmed Mohamed Yasser', N'ahmedmoh9', N'jvwLaBLv2Z', N'ahmedmoh99@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170002, N'Yassin Gasser ElReedy', N'ygasser66', N'kZv6VxL5up', N'yg2001@hotmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170003, N'Ahmed Yasser Khalil', N'yassser09', N'j4R4KrwVpY', N'yasser.ahmed@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170004, N'Nadine Raouf ElReefy', N'nadinera22', N'dRj6u6ppRh', N'nadineakar@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170005, N'Waleed Ashraf ElGammal', N'washraf', N'S3rVGwk', N'washraf@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170006, N'Hana Zaher Osama', N'hanazaherr', N'34eng5613', N'hanazaherr@hotmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170007, N'Menna Omar Talal', N'momar1', N'56e9n11g0', N'momar1@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170008, N'Maysoun Mohamed ElFar', N'maysounmoh', N'00en234g8', N'maysounmoh@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170009, N'Pakinam Talaat Mamdouh', N'pakitalaat', N'5LgSP8V', N'pakitalaat@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170010, N'Aya Samy Abbas', N'ayyasamyy3', N'CtX2cL7', N'ayyasamyy3@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170011, N'Noura Ashraf Ammar', N'nourast99', N'FADaa3L', N'nourast99@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170012, N'Hany Ahmed Khorshed', N'hkhaled123', N'2bPm3Gc', N'hahmed123@hotmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170013, N'Mohamed Mohsen Tarhouni', N'mohmohsen', N'bNeYv2F', N'mohmohsen@hotmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170014, N'Munir Fayad Mohamed', N'munirf', N'TuHX4hK', N'munirfayad1@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170015, N'Hassan Mokhtar ElAassar', N'hmokhtar', N'Rt8Gvya', N'hmokhtar2@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170016, N'Asmaa Mohamed Bassem', N'asmaamoh3434', N'a2MrfCd', N'asmaamoh3434@hotmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170017, N'Nayera Mohamed Nasser', N'naymohamed', N'LDh9yaf', N'naymohamed11@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170018, N'Nesma Mahmoud Hossam', N'nesmamah', N'uQ3FbhQ', N'nesmamah99@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170019, N'Mariam Asser Khalil', N'mariamasser77', N'k3Jkg48', N'mariamasser77@hotmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170020, N'Marina Wagdy Kirollos', N'mwagdyy', N'wTM9btR', N'mwagdyy@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170021, N'Monica Maged Wahba', N'monmaged', N'2SNLpmQ', N'monmaged@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170022, N'Marwan Waleed Gasser', N'marowaleed', N'SADx2Wd', N'marowaleed98@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170023, N'Merna Bahgat Qammar', N'mernabah77', N'2ZySzrA', N'mernabah77@hotmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170024, N'Ahmed Osama Mahmoud', N'aosamamah', N'11e22n55g99', N'aosamamah@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170025, N'Ahmed ElTaher AddelRady', N'ahmedeltaheerr', N'49en647g227', N'ahmedeltaheerr@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170026, N'Ahmed Ragab Abdelqader', N'aabdelqader', N'5888erni3719', N'aabdo@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170027, N'Ahmed Mahmoud Hussein', N'ahussmahmoud', N'77unp9d3qwe', N'ahmedhussmah@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170028, N'Ahmed Motaaz Lotfy', N'motaazahmed', N'44tMsDB', N'amotaaz46@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170029, N'Esraa Hossam Fawzy', N'esraahoss', N'd3RSYzayq', N'esraahoss@outlook.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170030, N'Amir Osama Mohamed', N'amir99osama', N'gPfJs66yf', N'amir99osama@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170031, N'pakinam moataz bellah', N'pakinam9765', N'cCFDzrJ9e', N'pakinam9765@yahoo.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170032, N'Pierre Amir Fouad Farag', N'pierream786', N'T3PB7vctq', N'pierream786@gmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170033, N'Tasnem Adel Mohamed', N'tasnem4627', N'29M4zZWkh', N'tasnem4627@hotmail.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170034, N'rawda Ahmed Shaker', N'rawdaahmeed7', N'WQ2Gdng3M', N'rawdaahmeed7@outlook.com')
GO
INSERT [dbo].[Student] ([ID], [Name], [Username], [Password], [Email]) VALUES (1170035, N'Sandra Adel Aziz ', N'sandraadel67', N'fenN4VCsV', N'sandraadel67@hotmail.com')
GO
INSERT [dbo].[Student_Goes_Contests] ([Student_ID], [Contest_No]) VALUES (1170009, 2002)
GO
INSERT [dbo].[Student_Goes_Contests] ([Student_ID], [Contest_No]) VALUES (1170016, 2001)
GO
INSERT [dbo].[Student_Goes_Contests] ([Student_ID], [Contest_No]) VALUES (1170029, 2004)
GO
INSERT [dbo].[Student_Goes_Contests] ([Student_ID], [Contest_No]) VALUES (1170034, 2003)
GO
INSERT [dbo].[Student_Joins_ProjectTeam] ([Student_ID], [Team_No]) VALUES (1170008, 4002)
GO
INSERT [dbo].[Student_Joins_ProjectTeam] ([Student_ID], [Team_No]) VALUES (1170008, 4003)
GO
INSERT [dbo].[Student_Joins_ProjectTeam] ([Student_ID], [Team_No]) VALUES (1170013, 4005)
GO
INSERT [dbo].[Student_Joins_ProjectTeam] ([Student_ID], [Team_No]) VALUES (1170014, 4001)
GO
INSERT [dbo].[Student_Joins_ProjectTeam] ([Student_ID], [Team_No]) VALUES (1170031, 4005)
GO
INSERT [dbo].[Student_Loads_Textbook] ([Student_ID], [Textbook_No]) VALUES (1170004, 6003)
GO
INSERT [dbo].[Student_Loads_Textbook] ([Student_ID], [Textbook_No]) VALUES (1170027, 6002)
GO
INSERT [dbo].[Student_Loads_Textbook] ([Student_ID], [Textbook_No]) VALUES (1170033, 6001)
GO
INSERT [dbo].[Student_Posts_Community] ([Student_ID], [Post_No]) VALUES (1170009, 8001)
GO
INSERT [dbo].[Student_Replies_Community_ToAPost] ([Student_ID], [Post_No], [Reply_Post_No]) VALUES (1170029, 8001, 99001)
GO
INSERT [dbo].[Student_Request_Internship] ([Student_ID], [Internship_ID]) VALUES (1170001, 7003)
GO
INSERT [dbo].[Student_Request_Internship] ([Student_ID], [Internship_ID]) VALUES (1170035, 7001)
GO
INSERT [dbo].[Student_Takes_Courses] ([Student_ID], [Course_No]) VALUES (1170002, 57403)
GO
INSERT [dbo].[Student_Takes_Courses] ([Student_ID], [Course_No]) VALUES (1170003, 57406)
GO
INSERT [dbo].[Student_Takes_Courses] ([Student_ID], [Course_No]) VALUES (1170011, 57403)
GO
INSERT [dbo].[Student_Takes_Courses] ([Student_ID], [Course_No]) VALUES (1170022, 57401)
GO
INSERT [dbo].[Textbook] ([Textbook_No], [Name], [Link], [Publisher]) VALUES (6001, N'Introduction to Mechanical Engineering', N'www.mechanicalengineering.com', N'Jonathan Wickert')
GO
INSERT [dbo].[Textbook] ([Textbook_No], [Name], [Link], [Publisher]) VALUES (6002, N'Engineers'' Practical Databook', N'www.emp.com', N'Jay Smith')
GO
INSERT [dbo].[Textbook] ([Textbook_No], [Name], [Link], [Publisher]) VALUES (6003, N'The Unwritten Laws of Engineering', N'www.englaws.com', N'James G. Skakoon')
GO
INSERT [dbo].[Textbook] ([Textbook_No], [Name], [Link], [Publisher]) VALUES (6004, N'Elements of Power Electronics', N'www.elementsofpower.net', N'Philip Krein')
GO
INSERT [dbo].[Textbook] ([Textbook_No], [Name], [Link], [Publisher]) VALUES (6005, N'Introduction To Database', N'www.into@info.net', N'Mazidi')
GO
ALTER TABLE [dbo].[Business_Idea]  WITH CHECK ADD  CONSTRAINT [FK_Business_Idea_Sponsors] FOREIGN KEY([Sponsor_ID])
REFERENCES [dbo].[Sponsors] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Business_Idea] CHECK CONSTRAINT [FK_Business_Idea_Sponsors]
GO
ALTER TABLE [dbo].[Business_Idea]  WITH CHECK ADD  CONSTRAINT [FK_Business_Idea_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Business_Idea] CHECK CONSTRAINT [FK_Business_Idea_Student]
GO
ALTER TABLE [dbo].[Contests]  WITH CHECK ADD  CONSTRAINT [FK_Contests_Sponsors] FOREIGN KEY([Sponsor_ID])
REFERENCES [dbo].[Sponsors] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Contests] CHECK CONSTRAINT [FK_Contests_Sponsors]
GO
ALTER TABLE [dbo].[Course_OfferedBy_Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Course_OfferedBy_Doctors_Courses] FOREIGN KEY([Course_No])
REFERENCES [dbo].[Courses] ([Course_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Course_OfferedBy_Doctors] CHECK CONSTRAINT [FK_Course_OfferedBy_Doctors_Courses]
GO
ALTER TABLE [dbo].[Course_OfferedBy_Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Course_OfferedBy_Doctors_Doctors] FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctors] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Course_OfferedBy_Doctors] CHECK CONSTRAINT [FK_Course_OfferedBy_Doctors_Doctors]
GO
ALTER TABLE [dbo].[Doctor_Gives_Student_GradesInCourse]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Gives_Student_GradesInCourse_Courses] FOREIGN KEY([Course_No])
REFERENCES [dbo].[Courses] ([Course_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Doctor_Gives_Student_GradesInCourse] CHECK CONSTRAINT [FK_Doctor_Gives_Student_GradesInCourse_Courses]
GO
ALTER TABLE [dbo].[Doctor_Gives_Student_GradesInCourse]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Gives_Student_GradesInCourse_Doctors] FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctors] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Doctor_Gives_Student_GradesInCourse] CHECK CONSTRAINT [FK_Doctor_Gives_Student_GradesInCourse_Doctors]
GO
ALTER TABLE [dbo].[Doctor_Gives_Student_GradesInCourse]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Gives_Student_GradesInCourse_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Doctor_Gives_Student_GradesInCourse] CHECK CONSTRAINT [FK_Doctor_Gives_Student_GradesInCourse_Student]
GO
ALTER TABLE [dbo].[Doctor_Replies_Community_ToAPost]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Replies_Community_ToAPost_Doctors] FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctors] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Doctor_Replies_Community_ToAPost] CHECK CONSTRAINT [FK_Doctor_Replies_Community_ToAPost_Doctors]
GO
ALTER TABLE [dbo].[Doctor_Replies_Community_ToAPost]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Replies_Community_ToAPost_Post_Community] FOREIGN KEY([Post_No])
REFERENCES [dbo].[Post_Community] ([Post_No])
GO
ALTER TABLE [dbo].[Doctor_Replies_Community_ToAPost] CHECK CONSTRAINT [FK_Doctor_Replies_Community_ToAPost_Post_Community]
GO
ALTER TABLE [dbo].[Doctor_Upload_Textbook_ToCourse]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Upload_Textbook_ToCourse_Courses] FOREIGN KEY([Course_No])
REFERENCES [dbo].[Courses] ([Course_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Doctor_Upload_Textbook_ToCourse] CHECK CONSTRAINT [FK_Doctor_Upload_Textbook_ToCourse_Courses]
GO
ALTER TABLE [dbo].[Doctor_Upload_Textbook_ToCourse]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Upload_Textbook_ToCourse_Doctors] FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctors] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Doctor_Upload_Textbook_ToCourse] CHECK CONSTRAINT [FK_Doctor_Upload_Textbook_ToCourse_Doctors]
GO
ALTER TABLE [dbo].[Doctor_Upload_Textbook_ToCourse]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Upload_Textbook_ToCourse_Textbook] FOREIGN KEY([Textbook_No])
REFERENCES [dbo].[Textbook] ([Textbook_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Doctor_Upload_Textbook_ToCourse] CHECK CONSTRAINT [FK_Doctor_Upload_Textbook_ToCourse_Textbook]
GO
ALTER TABLE [dbo].[Feedback]  WITH CHECK ADD  CONSTRAINT [FK_Feedback_Courses] FOREIGN KEY([Course_No])
REFERENCES [dbo].[Courses] ([Course_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Feedback] CHECK CONSTRAINT [FK_Feedback_Courses]
GO
ALTER TABLE [dbo].[Internships]  WITH CHECK ADD  CONSTRAINT [FK_Internships_Sponsors] FOREIGN KEY([Sponsor_ID])
REFERENCES [dbo].[Sponsors] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Internships] CHECK CONSTRAINT [FK_Internships_Sponsors]
GO
ALTER TABLE [dbo].[Project_Team]  WITH CHECK ADD  CONSTRAINT [FK_Project_Team_Student] FOREIGN KEY([TeamLeader_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Project_Team] CHECK CONSTRAINT [FK_Project_Team_Student]
GO
ALTER TABLE [dbo].[Sponsor_Accepts_Student_inInternship]  WITH CHECK ADD  CONSTRAINT [FK_Sponsor_Accepts_Student_inInternship_Internships] FOREIGN KEY([Internship_ID])
REFERENCES [dbo].[Internships] ([Internship_ID])
GO
ALTER TABLE [dbo].[Sponsor_Accepts_Student_inInternship] CHECK CONSTRAINT [FK_Sponsor_Accepts_Student_inInternship_Internships]
GO
ALTER TABLE [dbo].[Sponsor_Accepts_Student_inInternship]  WITH CHECK ADD  CONSTRAINT [FK_Sponsor_Accepts_Student_inInternship_Sponsors] FOREIGN KEY([Sponsor_ID])
REFERENCES [dbo].[Sponsors] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sponsor_Accepts_Student_inInternship] CHECK CONSTRAINT [FK_Sponsor_Accepts_Student_inInternship_Sponsors]
GO
ALTER TABLE [dbo].[Sponsor_Accepts_Student_inInternship]  WITH CHECK ADD  CONSTRAINT [FK_Sponsor_Accepts_Student_inInternship_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sponsor_Accepts_Student_inInternship] CHECK CONSTRAINT [FK_Sponsor_Accepts_Student_inInternship_Student]
GO
ALTER TABLE [dbo].[Sponsor_Replies_Community_ToAPost]  WITH CHECK ADD  CONSTRAINT [FK_Sponsor_Replies_Community_ToAPost_Post_Community] FOREIGN KEY([Post_No])
REFERENCES [dbo].[Post_Community] ([Post_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sponsor_Replies_Community_ToAPost] CHECK CONSTRAINT [FK_Sponsor_Replies_Community_ToAPost_Post_Community]
GO
ALTER TABLE [dbo].[Sponsor_Replies_Community_ToAPost]  WITH CHECK ADD  CONSTRAINT [FK_Sponsor_Replies_Community_ToAPost_Sponsors] FOREIGN KEY([Sponsor_ID])
REFERENCES [dbo].[Sponsors] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sponsor_Replies_Community_ToAPost] CHECK CONSTRAINT [FK_Sponsor_Replies_Community_ToAPost_Sponsors]
GO
ALTER TABLE [dbo].[Student_Goes_Contests]  WITH CHECK ADD  CONSTRAINT [FK_Student_Goes_Contests_Contests] FOREIGN KEY([Contest_No])
REFERENCES [dbo].[Contests] ([Contest_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Goes_Contests] CHECK CONSTRAINT [FK_Student_Goes_Contests_Contests]
GO
ALTER TABLE [dbo].[Student_Goes_Contests]  WITH CHECK ADD  CONSTRAINT [FK_Student_Goes_Contests_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Goes_Contests] CHECK CONSTRAINT [FK_Student_Goes_Contests_Student]
GO
ALTER TABLE [dbo].[Student_Joins_ProjectTeam]  WITH CHECK ADD  CONSTRAINT [FK_Student_Joins_ProjectTeam_Project_Team] FOREIGN KEY([Team_No])
REFERENCES [dbo].[Project_Team] ([Team_No])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Student_Joins_ProjectTeam] CHECK CONSTRAINT [FK_Student_Joins_ProjectTeam_Project_Team]
GO
ALTER TABLE [dbo].[Student_Joins_ProjectTeam]  WITH CHECK ADD  CONSTRAINT [FK_Student_Joins_ProjectTeam_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
GO
ALTER TABLE [dbo].[Student_Joins_ProjectTeam] CHECK CONSTRAINT [FK_Student_Joins_ProjectTeam_Student]
GO
ALTER TABLE [dbo].[Student_Loads_Textbook]  WITH CHECK ADD  CONSTRAINT [FK_Student_Loads_Textbook_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Loads_Textbook] CHECK CONSTRAINT [FK_Student_Loads_Textbook_Student]
GO
ALTER TABLE [dbo].[Student_Loads_Textbook]  WITH CHECK ADD  CONSTRAINT [FK_Student_Loads_Textbook_Textbook] FOREIGN KEY([Textbook_No])
REFERENCES [dbo].[Textbook] ([Textbook_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Loads_Textbook] CHECK CONSTRAINT [FK_Student_Loads_Textbook_Textbook]
GO
ALTER TABLE [dbo].[Student_Posts_Community]  WITH CHECK ADD  CONSTRAINT [FK_Student_Posts_Community_Post_Community] FOREIGN KEY([Post_No])
REFERENCES [dbo].[Post_Community] ([Post_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Posts_Community] CHECK CONSTRAINT [FK_Student_Posts_Community_Post_Community]
GO
ALTER TABLE [dbo].[Student_Posts_Community]  WITH CHECK ADD  CONSTRAINT [FK_Student_Posts_Community_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Posts_Community] CHECK CONSTRAINT [FK_Student_Posts_Community_Student]
GO
ALTER TABLE [dbo].[Student_Replies_Community_ToAPost]  WITH CHECK ADD  CONSTRAINT [FK_Student_Replies_Community_ToAPost_Post_Community] FOREIGN KEY([Post_No])
REFERENCES [dbo].[Post_Community] ([Post_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Replies_Community_ToAPost] CHECK CONSTRAINT [FK_Student_Replies_Community_ToAPost_Post_Community]
GO
ALTER TABLE [dbo].[Student_Replies_Community_ToAPost]  WITH CHECK ADD  CONSTRAINT [FK_Student_Replies_Community_ToAPost_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Replies_Community_ToAPost] CHECK CONSTRAINT [FK_Student_Replies_Community_ToAPost_Student]
GO
ALTER TABLE [dbo].[Student_Request_Internship]  WITH CHECK ADD  CONSTRAINT [FK_Student_Request_Internship_Internships] FOREIGN KEY([Internship_ID])
REFERENCES [dbo].[Internships] ([Internship_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Request_Internship] CHECK CONSTRAINT [FK_Student_Request_Internship_Internships]
GO
ALTER TABLE [dbo].[Student_Request_Internship]  WITH CHECK ADD  CONSTRAINT [FK_Student_Request_Internship_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Request_Internship] CHECK CONSTRAINT [FK_Student_Request_Internship_Student]
GO
ALTER TABLE [dbo].[Student_Takes_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Student_Takes_Courses_Courses] FOREIGN KEY([Course_No])
REFERENCES [dbo].[Courses] ([Course_No])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Takes_Courses] CHECK CONSTRAINT [FK_Student_Takes_Courses_Courses]
GO
ALTER TABLE [dbo].[Student_Takes_Courses]  WITH CHECK ADD  CONSTRAINT [FK_Student_Takes_Courses_Student] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Student] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student_Takes_Courses] CHECK CONSTRAINT [FK_Student_Takes_Courses_Student]
GO
/****** Object:  StoredProcedure [dbo].[AddBusinessIdeaa]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddBusinessIdeaa]
	@Idea_No	int,
	@Description  varchar(150), 
	@Student_ID int,
	@Sponsor_ID int
AS
BEGIN
INSERT INTO Business_Idea(Idea_No,Description,Student_ID,Sponsor_ID)
Values (@Idea_No,@Description,@Student_ID,@Sponsor_ID)
END
GO
/****** Object:  StoredProcedure [dbo].[AddContests]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddContests]
	@Contest_No	int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Location varchar(50),
	@Time  varchar(50),
	@Prize  varchar(50),
	@Theme  varchar(50),
	@Sponsor_ID int
AS
BEGIN
INSERT INTO Contests(Contest_No,Name,Link,Location,Time,Prize,Theme,Sponsor_ID)
Values (@Contest_No,@Name,@Link,@Location,@Time,@Prize,@Theme,@Sponsor_ID)
END

GO
/****** Object:  StoredProcedure [dbo].[AddContestToAStudentProfile]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddContestToAStudentProfile]
	@Student_ID int,
	@Contest_No	int
AS
BEGIN
INSERT INTO Student_Goes_Contests(Student_ID,Contest_No)
Values (@Student_ID, @Contest_No)
END

GO
/****** Object:  StoredProcedure [dbo].[AddCourses]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddCourses]
	@Course_No		int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Level int 
AS
BEGIN
INSERT INTO Courses(Course_No,Name,Link,Level)
Values (@Course_No,@Name,@Link,@Level)
END

GO
/****** Object:  StoredProcedure [dbo].[AddCourseToAStudentProfile]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddCourseToAStudentProfile]
	@Course_No	int,
	@Student_ID int
AS
BEGIN
INSERT INTO Student_Takes_Courses(Course_No,Student_ID)
Values (@Course_No,@Student_ID)
END
GO
/****** Object:  StoredProcedure [dbo].[AddDoctors]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddDoctors]
	@ID		int,
	@Name  varchar(50), 
	@Username varchar(50),
	@Password varchar(50), 
	@Email varchar(50)
AS
BEGIN
INSERT INTO Doctors(ID,Name,Username,Password,Email)
Values (@ID,@Name,@Username,@Password,@Email)
END
GO
/****** Object:  StoredProcedure [dbo].[AddFeedback]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddFeedback]
	@Feedback_No	int,
	@Course_No  int, 
	@Rating float,
	@Description varchar(150)
AS
BEGIN
INSERT INTO Feedback(Feedback_No,Course_No,Rating,Description)
Values (@Feedback_No,@Course_No,@Rating,@Description)
END

GO
/****** Object:  StoredProcedure [dbo].[AddGradesByDoctors]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddGradesByDoctors]
	@Doctor_ID		int,
	@Student_ID  int, 
	@Course_No int,
	@Grade varchar(1) 
AS
BEGIN
INSERT INTO Doctor_Gives_Student_GradesInCourse(Doctor_ID,Student_ID,Course_No,Grade)
Values (@Doctor_ID,@Student_ID,@Course_No,@Grade)
END
GO
/****** Object:  StoredProcedure [dbo].[AddInternshipToAStudentProfile]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddInternshipToAStudentProfile]
	@Student_ID		int,
	@Internship_ID  int
AS
BEGIN
INSERT INTO Student_Request_Internship(Student_ID,Internship_ID)
Values (@Student_ID,@Internship_ID)
END

GO
/****** Object:  StoredProcedure [dbo].[AddInterships]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddInterships]
	@Internship_ID		int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Start varchar(50), 
	@End varchar(50),
	@Sponsor_ID int
AS
BEGIN
INSERT INTO Internships(Internship_ID,Name,Link,Start,EndDate,Sponsor_ID)
Values (@Internship_ID,@Name,@Link,@Start,@End,@Sponsor_ID)
END
GO
/****** Object:  StoredProcedure [dbo].[AddPost]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddPost]
	@Post_No	int,
	@Text  text
AS
BEGIN
INSERT INTO Post_Community(Post_No,Text)
Values (@Post_No,@Text)
END

GO
/****** Object:  StoredProcedure [dbo].[AddProjectTeam]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddProjectTeam]
	@Team_No	int,
	@Name  varchar(50), 
	@Description varchar(150),
	@TeamLeader_ID  int
AS
BEGIN
INSERT INTO Project_Team(Team_No,Name,Description,TeamLeader_ID)
Values (@Team_No,@Name,@Description,@TeamLeader_ID)
END
GO
/****** Object:  StoredProcedure [dbo].[AddProjectTeamToAStudentProfile]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddProjectTeamToAStudentProfile]
	@Student_ID int,
	@Team_No	int
AS
BEGIN
INSERT INTO Student_Joins_ProjectTeam(Student_ID,Team_No)
Values (@Student_ID,@Team_No)
END

GO
/****** Object:  StoredProcedure [dbo].[AddRPapers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddRPapers]
	@RPaper_No	int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Publisher varchar(50)
AS
BEGIN
INSERT INTO RPapers(RPaper_No,Name,Link,Publisher)
Values (@RPaper_No,@Name,@Link,@Publisher)
END

GO
/****** Object:  StoredProcedure [dbo].[AddSeminars]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddSeminars]
	@Seminar_No	int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Presenter varchar(50)
AS
BEGIN
INSERT INTO Seminars(Seminar_No,Name,Link,Presenter)
Values (@Seminar_No,@Name,@Link,@Presenter)
END
GO
/****** Object:  StoredProcedure [dbo].[AddSponsors]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddSponsors]
	@ID		int,
	@Name  varchar(50), 
	@Username varchar(50),
	@Password varchar(50), 
	@Email varchar(50)
AS
BEGIN
INSERT INTO Sponsors(ID,Name,Username,Password,Email)
Values (@ID,@Name,@Username,@Password,@Email)
END

GO
/****** Object:  StoredProcedure [dbo].[AddStudent]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddStudent]
	@ID		int,
	@Name  varchar(50), 
	@Username varchar(50),
	@Password varchar(50), 
	@Email varchar(50)
AS
BEGIN
INSERT INTO Student(ID,Name,Username,Password,Email)
Values (@ID,@Name,@Username,@Password,@Email)
END
GO
/****** Object:  StoredProcedure [dbo].[AddTextbook]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddTextbook]
	@Textbook_No	int,
	@Name  varchar(50), 
	@Link varchar(50),
	@Publisher varchar(50)
AS
BEGIN
INSERT INTO Textbook(Textbook_No,Name,Link,Publisher)
Values (@Textbook_No,@Name,@Link,@Publisher)
END

GO
/****** Object:  StoredProcedure [dbo].[AddTextbookToAStudentProfile]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[AddTextbookToAStudentProfile]
	@Student_ID int,
	@Textbook_No	int
AS
BEGIN
INSERT INTO Student_Loads_Textbook(Student_ID,Textbook_No)
Values (@Student_ID,@Textbook_No)
END

GO
/****** Object:  StoredProcedure [dbo].[CheckDoctorLogIn]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[CheckDoctorLogIn]
@Username	varchar(50),
@Password	varchar(50)
AS
BEGIN
	SELECT Username,Password
    From Doctors
	where Username=@Username and Password=@Password
END
GO
/****** Object:  StoredProcedure [dbo].[CheckSponsorLogIn]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[CheckSponsorLogIn]
@Username	varchar(50),
@Password	varchar(50)
AS
BEGIN
	SELECT Username,Password
    From Sponsors
	where Username=@Username and Password=@Password
END

GO
/****** Object:  StoredProcedure [dbo].[CheckStudentLogIn]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[CheckStudentLogIn]
@Username	varchar(50),
@Password	varchar(50)
AS
BEGIN
	SELECT Username,Password
    From Student
	where Username=@Username and Password=@Password
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllContestsNamesAndNumbers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllContestsNamesAndNumbers]
AS
BEGIN
	SELECT Name as Name,Contest_No as ContestNumber
    From Contests
END


GO
/****** Object:  StoredProcedure [dbo].[GetAllCoursesNameAndNumbers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllCoursesNameAndNumbers]
AS
BEGIN
	SELECT Name as Name,Course_No as CourseNumber
    From Courses
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllInfoOfInternshipByID]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllInfoOfInternshipByID]
@Internship_ID	int
AS
BEGIN
	SELECT *
    From Internships
	where Internship_ID=@Internship_ID
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllInfoOfRPaperByNumber]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllInfoOfRPaperByNumber]
@RPaper_No int
AS
BEGIN
	SELECT *
    From RPapers
	where RPaper_No=@RPaper_No
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllInfoOfSeminarByNumber]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllInfoOfSeminarByNumber]
@Seminar_No int
AS
BEGIN
	SELECT *
    From Seminars
	where Seminar_No=@Seminar_No
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllInfoOfTextbookByNumber]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllInfoOfTextbookByNumber]
@Textbook_No int
AS
BEGIN
	SELECT *
    From Textbook
	where Textbook_No=@Textbook_No
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllInternshipsNamesAndIDs]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllInternshipsNamesAndIDs]
AS
BEGIN
	SELECT Name as InternshipName, Internship_ID as InternshipID
    From Internships
END


GO
/****** Object:  StoredProcedure [dbo].[GetAllProjectTeamsNameAndNumbers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllProjectTeamsNameAndNumbers]
AS
BEGIN
	SELECT Name as Name,Team_No as TeamNumber
    From Project_Team
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllQuestions]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllQuestions]
AS
BEGIN
	SELECT Text as Questions
    From Student_Posts_Community as E join Post_Community as F on E.Post_No=F.Post_No
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllRPapersNamesAndNumbers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllRPapersNamesAndNumbers]
AS
BEGIN
	SELECT Name as RPaperName, RPaper_No as RPaperNumber
    From RPapers
END

GO
/****** Object:  StoredProcedure [dbo].[GetAllSeminarsNamesAndNumbers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllSeminarsNamesAndNumbers]
AS
BEGIN
	SELECT Name as SeminarName, Seminar_No as SeminarNumber
    From Seminars
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTextbooksNamesAndNumbers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetAllTextbooksNamesAndNumbers]
AS
BEGIN
	SELECT Name as TextbookName, Textbook_No as TextbookNumber
    From Textbook
END

GO
/****** Object:  StoredProcedure [dbo].[GetContestsNameJoinedByASpecificStudentByUsername]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetContestsNameJoinedByASpecificStudentByUsername]
@Username  varchar(50)
AS
BEGIN
		SELECT F.Name as ContestName
		From Contests as F
		where F.Contest_No IN
							  (SELECT Contest_No 
							  FROM (Student_Goes_Contests as E join Student as K on E.Student_ID=ID)  
							  where Contest_No in (SELECT Contest_No FROM Contests) and Username=@Username)
END

GO
/****** Object:  StoredProcedure [dbo].[GetCountOfBusinessIdea]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfBusinessIdea]
AS
BEGIN
	SELECT Count(*) as CountOfBusinessIdea
    From Business_Idea
END
GO
/****** Object:  StoredProcedure [dbo].[GetCountOfContests]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfContests]
AS
BEGIN
	SELECT Count(*) as CountOfContests
    From Contests
END
GO
/****** Object:  StoredProcedure [dbo].[GetCountOfCourses]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfCourses]
AS
BEGIN
	SELECT Count(*) as CountOfCourses
    From Courses
END

GO
/****** Object:  StoredProcedure [dbo].[GetCountOfDoctors]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfDoctors]
AS
BEGIN
	SELECT Count(*) as CountOfDoctors
     From Doctors
END

GO
/****** Object:  StoredProcedure [dbo].[GetCountOfFeedback]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfFeedback]
AS
BEGIN
	SELECT Count(*) as CountOfFeedback
    From Feedback
END

GO
/****** Object:  StoredProcedure [dbo].[GetCountOfInternships]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfInternships]
AS
BEGIN
	SELECT Count(*) as CountOfInternships
    From Internships
END


GO
/****** Object:  StoredProcedure [dbo].[GetCountOfPosts]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfPosts]
AS
BEGIN
	SELECT Count(*) as CountOfPosts
    From Student_Posts_Community
END

GO
/****** Object:  StoredProcedure [dbo].[GetCountOfProjectTeam]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfProjectTeam]
AS
BEGIN
	SELECT Count(*) as CountOfProjectTeam
    From Project_Team
END

GO
/****** Object:  StoredProcedure [dbo].[GetCountOfReplies]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfReplies]
AS
BEGIN
	SELECT (Count(D.Reply_Post_No) + Count(S.Reply_Post_No) + Count(T.Reply_Post_No)) as Sum
    From Doctor_Replies_Community_ToAPost as D, Sponsor_Replies_Community_ToAPost as S, Student_Replies_Community_ToAPost as T
END

GO
/****** Object:  StoredProcedure [dbo].[GetCountOfRPapers]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfRPapers]
AS
BEGIN
	SELECT Count(*) as CountOfRPapers
    From RPapers
END

GO
/****** Object:  StoredProcedure [dbo].[GetCountOfSeminars]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfSeminars]
AS
BEGIN
	SELECT Count(*) as CountOfSeminars
    From Seminars
END


GO
/****** Object:  StoredProcedure [dbo].[GetCountOfSponsors]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfSponsors]
AS
BEGIN
	SELECT Count(*) as CountOfSponsors
    From Sponsors
END

GO
/****** Object:  StoredProcedure [dbo].[GetCountOfStudent]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================


CREATE PROCEDURE [dbo].[GetCountOfStudent]
AS
BEGIN
	SELECT Count(*) as CountOfStudent
     From Student
END


GO
/****** Object:  StoredProcedure [dbo].[GetCountOfTextbook]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCountOfTextbook]
AS
BEGIN
	SELECT Count(*) as CountOfTextbook
    From Textbook
END


GO
/****** Object:  StoredProcedure [dbo].[GetCoursesAndGradeOfASpecificStudentByUsername]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetCoursesAndGradeOfASpecificStudentByUsername]
@Username  varchar(50)
AS
BEGIN
	SELECT E.Name as StudentName, Grade as StudentGrade
    From Courses as E, Doctor_Gives_Student_GradesInCourse as F, Student as K
	where E.Course_No=F.Course_No and F.Student_ID=K.ID and Username=@Username
END

GO
/****** Object:  StoredProcedure [dbo].[GetDoctorNameByUsername]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetDoctorNameByUsername]
@Username	varchar(50)
AS
BEGIN
	SELECT Name as DoctorName
    From Doctors
	where Username=@Username
END
GO
/****** Object:  StoredProcedure [dbo].[GetEmailOfStudentByName]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetEmailOfStudentByName]
@Name varchar(50)
AS
BEGIN
	SELECT Email
     From Student
	 where Name=@Name
END

GO
/****** Object:  StoredProcedure [dbo].[GetFeedbackOfASpecificCourseByNumber]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetFeedbackOfASpecificCourseByNumber]
@Course_No  int
AS
BEGIN
	SELECT Description,Rating
    From Courses as E join Feedback as F on E.Course_No=F.Course_No
	where E.Name=@Course_No
END
GO
/****** Object:  StoredProcedure [dbo].[GetInfoOfAContestByNumber]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetInfoOfAContestByNumber]
@Contest_No  int
AS
BEGIN
	SELECT *
    From Contests
	where Contest_No=@Contest_No
END


GO
/****** Object:  StoredProcedure [dbo].[GetInfoOfACourseByName]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetInfoOfACourseByName]
@Name  varchar(50)
AS
BEGIN
	SELECT *
    From Courses
	where Name=@Name
END


GO
/****** Object:  StoredProcedure [dbo].[GetInfoOfAProjectTeamByNumber]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetInfoOfAProjectTeamByNumber]
@Team_No  int
AS
BEGIN
	SELECT *
    From Project_Team
	where Team_No=@Team_No
END

GO
/****** Object:  StoredProcedure [dbo].[GetProjectTeamNameJoinedByASpecificStudentByUsername]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetProjectTeamNameJoinedByASpecificStudentByUsername]
@Username  varchar(50)
AS
BEGIN
	SELECT F.Name as TeamName
    From Project_Team as F
	where F.Team_No IN
						(SELECT Team_No 
						 FROM (Student_Joins_ProjectTeam as E join Student as K on E.Student_ID=ID)  
						 where team_no in ( SELECT Team_No FROM Project_Team) and Username=@Username)
END

GO
/****** Object:  StoredProcedure [dbo].[GetSponsorNameByUsername]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetSponsorNameByUsername]
@Username	varchar(50)
AS
BEGIN
	SELECT Name as SponsorName
    From Sponsors
	where Username=@Username
END

GO
/****** Object:  StoredProcedure [dbo].[GetStudentNameByUsername]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetStudentNameByUsername]
@Username	varchar(50)
AS
BEGIN
	SELECT Name as StudentName
    From Student
	where Username=@Username
END
GO
/****** Object:  StoredProcedure [dbo].[GetTextbookNameLoadedByASpecificStudentByUsername]    Script Date: 12/14/2019 2:39:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[GetTextbookNameLoadedByASpecificStudentByUsername]
@Username  varchar(50)
AS
BEGIN
	SELECT F.Name as TextbookName
    From Textbook as F
	where F.Textbook_No IN
						(SELECT Textbook_No 
						 FROM (Student_Loads_Textbook as E join Student as K on E.Student_ID=ID)  
						 where textbook_no in ( SELECT Textbook_No FROM Textbook) and Username=@Username)
END

GO
USE [master]
GO
ALTER DATABASE [Student] SET  READ_WRITE 
GO
