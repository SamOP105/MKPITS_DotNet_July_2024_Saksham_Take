--11. Right Join: Retrieve all departments along with their employees.
--Include departments that have no employees.


select d.department_id,d.department_name , from employees e 
right join departments d on d.department_id= e.department_id;
