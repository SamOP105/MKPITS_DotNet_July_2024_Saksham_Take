--6. Write a stored procedure to calculate and return the total sales for a specific product. 
--The product ID should be passed as a parameter.


create or alter procedure sp_cal
    @ProductId INT   
as
begin
    select SUM(TotalAmount) as TotalSales from XOrders where ProductId = @ProductId;
end
