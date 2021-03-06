USE [DBANANA]
GO
/****** Object:  View [dbo].[mealStats]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[mealStats] AS 
SELECT 
	DISTINCT MEALS.name AS 'Meal name', 
	CAST(dbo.mealPrice(MEALS.id) AS float) / 100 AS 'Calculated price',
	CAST (dbo.mealPrice(MEALS.id) - MEALS.discount AS float) / 100 AS 'Designated price',
	dbo.mealItemCount(MEALS.id) AS 'Item count'
FROM MEALS JOIN MEALS_ITEMS ON MEALS.id=MEALS_ITEMS.meal_id



GO
