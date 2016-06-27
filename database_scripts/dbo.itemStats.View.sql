USE [DBANANA]
GO
/****** Object:  View [dbo].[itemStats]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[itemStats] AS 
SELECT 
	DISTINCT name AS 'Item name', 
	dbo.itemStatLastMonth(id) AS 'Amount bought in last month'
FROM ITEMS





GO
