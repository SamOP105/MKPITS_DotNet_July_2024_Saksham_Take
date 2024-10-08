--2.	Write a stored procedure that accepts a department ID and returns the number of employees 
--in that department


create or alter procedure sp_dep
@DepartmentId int
As
begin 
Select count(EmpName) as Number_of_employees from Employee where departmentId=@DepartmentId;
end;

exec sp_dep @departmentId=3
