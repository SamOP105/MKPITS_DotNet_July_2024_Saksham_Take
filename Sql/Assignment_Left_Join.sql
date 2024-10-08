--10. Left Join: Retrieve all employees along with their
--department names. Some employees may not have a department assigned.


select e.employee_id, e.name,e.department_id,e.manager_id,
e.salary,d.department_name from employees e left join departments d 
on d.department_id= e.department_id;

