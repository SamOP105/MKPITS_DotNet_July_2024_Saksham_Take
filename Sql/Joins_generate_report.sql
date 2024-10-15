--generate a report on CustomerName,OrderID,ProductName,Quantity,total price(quantity*price)

select c.customerName, o.orderId, p.productName, oi.quantity, (oi.quantity * p.price) as Total
from customer c join orders o on c.customerId = o.customerId join orderItems oi on o.orderId = oi.orderId
join products p ON oi.productId = p.productId;
