--8. Create a stored procedure that accepts an employee ID and a percentage,
--then increases that employee’s salary by that percentage.

create or alter procedure sp_per
@empid int,
@per int

as
begin
update Employee set EmpSalary=Empsalary+Empsalary*(@per) where id=@empId;
select * from Employee
end

exec sp_per @per=12, @empid=4