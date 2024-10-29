--Find Customers with More Than One Order: Write a query to select customers
-- who have placed more than one order by grouping by CustomerID and using the
-- HAVING clause with COUNT

select CustomerID, COUNT(ID) AS Order_Count from Orders group by CustomerID having Count(ID) > 1;