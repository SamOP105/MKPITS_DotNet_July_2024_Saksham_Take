--7. Find Customers with Substring in Last Name: Select customers whose
--LastName contains the substring 'son' using the CHARINDEX function.select *
from Customer
where charindex('son', LastName) > 0;

--8.Select Email Username Portion: Retrieve the portion of the Email before the '@'
--symbol using the LEFT and CHARINDEX functions.select Left(Email,CHARINDEX('@',Email)-1) from Customer;--9.Check Length of Customer Names: Write a query to select CustomerID,
--FirstName, and the length of FirstName using the LEN function.select len(firstName) as LFirstName,len(LastName) As LlastName from Customer--10.Select Customers with Padded Zip Codes: Write a query to retrieve the
--CustomerID and ZipCode, padding the ZipCode with leading zeros using the
--RIGHT and REPLICATE functions.

SELECT 
    ID,
    RIGHT(REPLICATE('0', 5) + ZipCode, 5) AS PaddedZipCode
FROM 
    Customer;


--11.Calculate Customer Age: Retrieve the CustomerID, FirstName, and calculated
--Age from the DateOfBirth field using the DATEDIFF and GETDATE functions.SELECT ID,FirstName,DATEDIFF(YEAR, DateOfBirth, GETDATE()) AS Age
FROM Customer;

--12.Select Customers by Birth Month: Write a query to select customers who were
--born in a specific month using the MONTH function.select ID,FirstName,LastName from Customer where Month(DateofBirth)=1;



