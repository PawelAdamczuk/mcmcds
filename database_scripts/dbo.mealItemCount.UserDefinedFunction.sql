USE [DBANANA]
GO
/****** Object:  UserDefinedFunction [dbo].[mealItemCount]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[mealItemCount] (@mId int)
	returns numeric
	AS
	BEGIN
	RETURN (SELECT COUNT(MEALS_ITEMS.item_id) FROM MEALS JOIN MEALS_ITEMS ON MEALS_ITEMS.meal_id=MEALS.id WHERE MEALS.id=@mId);
	END





GO
