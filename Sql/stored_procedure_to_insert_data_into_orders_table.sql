--3. Develop a stored procedure to insert a new record into the orders table. 
--The procedure should accept all necessary order details as parameters.

create or alter procedure sp_insert
 @OrdersDate datetime ,              
 @CustomerId int,                 
 @TotalAmount decimal(18, 2),      
 @OrdersNumber varchar(50)
 As 
 begin
 insert into XOrders(OrdersDate,CustomerId,TotalAmount,OrdersNumber)Values (@OrdersDate,@CustomerId,@TotalAmount,@OrdersNumber);
 end;
exec sp_insert @OrdersDate ='2024-08-11',@CustomerId=34,@TotalAmount=433.33,@OrdersNumber=gvv;
