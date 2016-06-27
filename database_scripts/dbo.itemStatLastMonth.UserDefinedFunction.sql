USE [DBANANA]
GO
/****** Object:  UserDefinedFunction [dbo].[itemStatLastMonth]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE FUNCTION [dbo].[itemStatLastMonth] (@iId int)
	returns numeric
	AS
	BEGIN
	RETURN (
	
	SELECT COUNT(item_id) 
	FROM ORDERS JOIN ORDERS_ITEMS ON ORDERS.id=ORDERS_ITEMS.order_id WHERE item_id=@iId AND timestamp > DATEADD(month, -1, CURRENT_TIMESTAMP) AND executed=1);
	END







GO
