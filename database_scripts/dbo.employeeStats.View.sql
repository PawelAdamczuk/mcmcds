USE [DBANANA]
GO
/****** Object:  View [dbo].[employeeStats]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[employeeStats] AS 
SELECT 
	DISTINCT EMPLOYEES.name AS 'Employee name', 
	EMPLOYEES.position AS 'Employee role',
	dbo.employeeOrderCount(employee_id) AS 'Order count',
	(SELECT AVG(price) FROM ORDERS WHERE EMPLOYEES.id=ORDERS.employee_id) AS 'Average order value'
FROM ORDERS INNER JOIN EMPLOYEES ON ORDERS.employee_id=EMPLOYEES.id
WHERE ORDERS.executed = 1



GO
