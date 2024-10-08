--4. Write a stored procedure to update the salary of an employee based on their employee ID.
--The new salary should be passed as a parameter.\


create or alter procedure sp_update
@salary decimal(10,2),
@empId int
as
begin
update Employee set EmpSalary =@salary where Id=@empid;
end
exec sp_update @empid=1, @salary=60000.23