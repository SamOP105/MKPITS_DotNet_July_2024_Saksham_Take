--7. Find Customers with Substring in Last Name: Select customers whose
--LastName contains the substring 'son' using the CHARINDEX function.
from Customer
where charindex('son', LastName) > 0;

--8.Select Email Username Portion: Retrieve the portion of the Email before the '@'
--symbol using the LEFT and CHARINDEX functions.
--FirstName, and the length of FirstName using the LEN function.
--CustomerID and ZipCode, padding the ZipCode with leading zeros using the
--RIGHT and REPLICATE functions.

SELECT 
    ID,
    RIGHT(REPLICATE('0', 5) + ZipCode, 5) AS PaddedZipCode
FROM 
    Customer;


--11.Calculate Customer Age: Retrieve the CustomerID, FirstName, and calculated
--Age from the DateOfBirth field using the DATEDIFF and GETDATE functions.
FROM Customer;

--12.Select Customers by Birth Month: Write a query to select customers who were
--born in a specific month using the MONTH function.


