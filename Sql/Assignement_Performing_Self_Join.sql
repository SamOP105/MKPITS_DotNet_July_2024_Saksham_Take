--13. Self Join: Retrieve all employees and their managers. 
--Assume that each employee has a manager specified by the 'manager_id' column.

SELECT e1.name AS employee_name, e2.name AS manager_name 
FROM employees e1 
INNER JOIN employees e2 ON e1.manager_id = e2.employee_id;