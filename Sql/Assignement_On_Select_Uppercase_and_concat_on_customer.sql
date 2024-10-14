--1. Select Customers with Uppercased First Names: Write a query to select the
--CustomerID and FirstName of all customers with their FirstName converted to
--uppercase using the UPPER function.

select id,Concat(upper(FirstName),' ',upper(LastName)) as FullName from Customer;

