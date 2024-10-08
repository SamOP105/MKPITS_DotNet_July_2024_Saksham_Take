create procedure sp_insertcustomer
As
insert into tblCustomers(FirstName,LastName,City,State,Zip) Values ('Saksham','Take','Yavatmal','In',445001)
go
EXEC sp_insertcustomer;