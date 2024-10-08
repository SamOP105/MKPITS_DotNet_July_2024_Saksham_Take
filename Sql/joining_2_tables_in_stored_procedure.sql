--7. Develop a stored procedure that takes a customer ID and returns the list of 
--orders placed by that customer, including order details such as order date, 
--product names, and quantities.

create or alter procedure sp_details
@customerId int

as
begin
select o.ordersdate, p.productId,count(o.Id) as Quantity from Xorders o join products p on o.productId= p.product_id where customerId=@customerId;
end