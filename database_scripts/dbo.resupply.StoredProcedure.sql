USE [DBANANA]
GO
/****** Object:  StoredProcedure [dbo].[resupply]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[resupply]
AS
	UPDATE ITEMS
	SET stock = max_stock
RETURN


GO
