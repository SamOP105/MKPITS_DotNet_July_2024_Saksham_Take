--1. Select Customers with Uppercased First Names: Write a query to select the
--CustomerID and FirstName of all customers with their FirstName converted to
--uppercase using the UPPER function.

select id,Concat(upper(FirstName),' ',upper(LastName)) as FullName from Customer;

--2.Select Customers with Lowercased Email Domains: Retrieve the CustomerID
--and the lowercased Email domain (portion after '@') using the LOWER and
--SUBSTRING functions.

Select Id,lower(substring(Email, charindex('@', Email)+1, len(Email))) AS Email
from Customer;


--3.Find Customers with Trimmed Spaces: Write a query to select customers whose
--FirstName or LastName contains leading or trailing spaces using the LTRIM and
--RTRIM functions
select Ltrim(FirstName) as FirstName,Rtrim(LastName) as LastName from customer;


--4.Select Initials of Customers: Retrieve the initials of each customer using the
--SUBSTRING function on FirstName and LastName.select Substring(FirstName,1,1)As Finitial,substring(LastName,1,1) as Linitial from Customer


--7. Find Customers with Substring in Last Name: Select customers whose
--LastName contains the substring 'son' using the CHARINDEX function.SELECT *
FROM Customer
WHERE CHARINDEX('son', LastName) > 0;
