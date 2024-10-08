--5. Create a stored procedure that deletes all records from a logs table that are older
--than a given date. The date should be passed as a parameter.


create or alter procedure sp_delete
@OrdersDate DATETIME
as
begin
delete from Xorders where ordersdate<=@OrdersDate;
end

exec sp_delete @ordersdate ='2024-08-11'