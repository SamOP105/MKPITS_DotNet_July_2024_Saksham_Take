--1.	Create a stored procedure to fetch all employees details from the employees table who are earning more than a 
--specific salary. The salary should be passed as a parameter.

create or alter procedure sp_fetch       
 
 @sal decimal(10,2)
 As
 Begin
 select * from Employee Where EmpSalary>@sal;
 End;

 exec sp_fetch @sal=6000