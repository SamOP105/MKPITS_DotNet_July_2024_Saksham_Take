
--2.Select Customers with Lowercased Email Domains: Retrieve the CustomerID
--and the lowercased Email domain (portion after '@') using the LOWER and
--SUBSTRING functions.

Select Id,lower(substring(Email, charindex('@', Email)+1, len(Email))) AS Email
from Customer;