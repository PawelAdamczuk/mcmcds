SET server=196.69.69.12
SET login=sa
SET password=bananek1

sqlcmd.exe -S %server% -P %password% -U %login% -i DBANANA.Database.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.EMPLOYEES.Table.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.ITEMS.Table.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.MEALS.Table.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.MEALS_ITEMS.Table.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.ORDERS.Table.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.ORDERS_ITEMS.Table.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.SUPPLY_ORDERS.Table.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.SUPPLY_ORDERS_ITEMS.Table.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.employeeOrderCount.UserDefinedFunction.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.getEmployeeId.UserDefinedFunction.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.itemStatLastMonth.UserDefinedFunction.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.mealItemCount.UserDefinedFunction.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.mealItems.UserDefinedFunction.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.mealPrice.UserDefinedFunction.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.resupply.StoredProcedure.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.employeeStats.View.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.itemStats.View.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.mealStats.View.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.pendingOrders.View.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i dbo.triggers.sql
sqlcmd.exe -S %server% -P %password% -U %login% -i SAMPLE_DATA.sql