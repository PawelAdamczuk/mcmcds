USE [DBANANA]
GO
/****** Object:  Table [dbo].[ORDERS]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ORDERS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[price] [int] NOT NULL,
	[timestamp] [datetime] NOT NULL DEFAULT (getdate()),
	[employee_id] [int] NOT NULL,
	[executed] [bit] NOT NULL DEFAULT ((0)),
 CONSTRAINT [PK_ORDERS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD  CONSTRAINT [FK_ORDERS_EMPLOYEES] FOREIGN KEY([employee_id])
REFERENCES [dbo].[EMPLOYEES] ([id])
GO
ALTER TABLE [dbo].[ORDERS] CHECK CONSTRAINT [FK_ORDERS_EMPLOYEES]
GO
ALTER TABLE [dbo].[ORDERS]  WITH CHECK ADD  CONSTRAINT [CK_ORDERS] CHECK  (([price]>=(0)))
GO
ALTER TABLE [dbo].[ORDERS] CHECK CONSTRAINT [CK_ORDERS]
GO
