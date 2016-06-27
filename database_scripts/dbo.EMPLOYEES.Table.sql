USE [DBANANA]
GO
/****** Object:  Table [dbo].[EMPLOYEES]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EMPLOYEES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[wage] [int] NOT NULL,
	[position] [varchar](50) NOT NULL,
	[login] [varchar](50) NOT NULL,
	[password_hash] [varchar](64) NOT NULL,
 CONSTRAINT [PK_EMPLOYEES] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_EMPLOYEES]    Script Date: 2016-01-24 21:39:32 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_EMPLOYEES] ON [dbo].[EMPLOYEES]
(
	[login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EMPLOYEES]  WITH CHECK ADD  CONSTRAINT [CK_EMPLOYEES] CHECK  (([wage]>(0)))
GO
ALTER TABLE [dbo].[EMPLOYEES] CHECK CONSTRAINT [CK_EMPLOYEES]
GO
