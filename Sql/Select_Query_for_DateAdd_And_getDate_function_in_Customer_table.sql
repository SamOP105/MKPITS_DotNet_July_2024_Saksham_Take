--13. Select Customers Registered in the Last Year: Retrieve customers who registered
--within the last year using the DATEADD and GETDATE functions.

select Id,FirstName,LastName,RegistredDate from Customer where RegistredDate>=DATEADD(Year,-1,GETDATE());
