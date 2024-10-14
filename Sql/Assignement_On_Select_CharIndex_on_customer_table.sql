--7. Find Customers with Substring in Last Name: Select customers whose
--LastName contains the substring 'son' using the CHARINDEX function.select *
from Customer
where charindex('son', LastName) > 0;