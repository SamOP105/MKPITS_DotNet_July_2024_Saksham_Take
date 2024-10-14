--4.Select Initials of Customers: Retrieve the initials of each customer using the
--SUBSTRING function on FirstName and LastName.select Substring(FirstName,1,1)As Finitial,substring(LastName,1,1) as Linitial from Customer
