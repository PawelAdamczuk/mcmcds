USE [DBANANA]
GO
/****** Object:  UserDefinedFunction [dbo].[mealPrice]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[mealPrice] (@mId int)
	returns numeric
	AS
	BEGIN
	RETURN (SELECT SUM(price) FROM MEALS_ITEMS JOIN ITEMS ON ITEMS.id=MEALS_ITEMS.item_id where meal_id=@mId);
	END



GO
