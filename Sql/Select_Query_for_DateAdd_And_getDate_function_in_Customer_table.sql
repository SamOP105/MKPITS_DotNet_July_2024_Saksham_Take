--13. Select Customers Registered in the Last Year: Retrieve customers who registered
--within the last year using the DATEADD and GETDATE functions.

select Id,FirstName,LastName,RegistredDate from Customer where RegistredDate>=DATEADD(Year,-1,GETDATE());

--14. Format Date of Birth: Write a query to format the DateOfBirth field as
--MM/DD/YYYY using the FORMAT function.SELECT ID,FORMAT(ordersDate, 'MM/dd/yyyy') AS FormattedDateOfBirth
FROM Orders;