SELECT * FROM Orders WHERE OrdersDate> '2012-07-19 00:00:00.000'

SELECT * FROM Orders ORDER BY OrdersDate DESC --Decresing 
SELECT * FROM Orders ORDER BY OrdersDate ASC --Incresing

SELECT * FROM Customer
SELECT MAX(Orders.OrdersDate) As OrdersDate FROM Orders group by OrdersDate

SELECT MAX(Orders.Id) As OrderNumber 
From Orders 
Where OrdersNumber=542383
Group by OrdersNumber