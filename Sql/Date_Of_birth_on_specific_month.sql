--12.Select Customers by Birth Month: Write a query to select customers who were
--born in a specific month using the MONTH function.

select ID,FirstName,LastName from Customer where Month(DateofBirth)=01;


--13. Select Customers Registered in the Last Year: Retrieve customers who registered
--within the last year using the DATEADD and GETDATE functions.

select Id,FirstName,LastName,RegistredDate from Customer where RegistredDate>=DATEADD(Year,-1,GETDATE());


