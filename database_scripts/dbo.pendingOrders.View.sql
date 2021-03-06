USE [DBANANA]
GO
/****** Object:  View [dbo].[pendingOrders]    Script Date: 2016-01-24 21:39:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[pendingOrders] AS 
SELECT 
	ORDERS.id AS 'Order ID',
	EMPLOYEES.name AS 'Employee name', 
	CAST (ORDERS.price AS float)/100 AS 'Order value', 
	ORDERS.timestamp AS 'Creation time' 
FROM ORDERS INNER JOIN EMPLOYEES ON ORDERS.employee_id=EMPLOYEES.id
WHERE ORDERS.executed != 1


GO
