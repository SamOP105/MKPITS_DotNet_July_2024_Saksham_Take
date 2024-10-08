--Inner Join: Write an SQL query to retrieve all orders with 
--customer information (name, email) from the 'orders' and 'customers'
--tables using an inner join.

select o.order_id, o.customer_id,o.order_amount, o.order_date, c.name,
c.email from orders o inner join customers c on o.customer_id=c.customer_id

