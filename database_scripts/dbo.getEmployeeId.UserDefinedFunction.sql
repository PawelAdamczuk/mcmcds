USE [DBANANA]
GO
/****** Object:  UserDefinedFunction [dbo].[getEmployeeId]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getEmployeeId]
(
	@l varchar(50),
	@p varchar(64)
)
RETURNS INT
AS
BEGIN
	RETURN (SELECT id FROM EMPLOYEES WHERE @l=EMPLOYEES.login AND @p=EMPLOYEES.password_hash);
END


GO
