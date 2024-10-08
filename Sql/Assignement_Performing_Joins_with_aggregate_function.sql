--15. Join with Aggregation: Retrieve the total number of 
--orders placed by each customer along with their name and email.

select Count(order_amount)as Count_Number from orders o join customers c on o.customer_id=c.customer_id;
