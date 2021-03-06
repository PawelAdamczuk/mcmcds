USE [DBANANA]
GO
/****** Object:  UserDefinedFunction [dbo].[mealItems]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[mealItems] (@mId int)
	returns table
	AS
	RETURN (SELECT item_id, name, CAST (price AS float)/100 as price FROM MEALS_ITEMS JOIN ITEMS ON ITEMS.id=MEALS_ITEMS.item_id where meal_id=@mId);


GO
