--3. Find Customers with Trimmed Spaces: Write a query to select customers whose
--FirstName or LastName contains leading or trailing spaces using the LTRIM and
--RTRIM functions

select Ltrim(FirstName) as FirstName,Rtrim(LastName) as LastName from customer;
