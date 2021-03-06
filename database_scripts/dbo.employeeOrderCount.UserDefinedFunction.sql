USE [DBANANA]
GO
/****** Object:  UserDefinedFunction [dbo].[employeeOrderCount]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[employeeOrderCount] (@eId int)
	returns numeric
	AS
	BEGIN
	RETURN (SELECT COUNT(ORDERS.id) FROM EMPLOYEES JOIN ORDERS ON ORDERS.employee_id=EMPLOYEES.id WHERE employee_id=@eId);
	END




GO
