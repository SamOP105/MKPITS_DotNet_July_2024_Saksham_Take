create table employees ( employee_id int primary key identity(0,1),name VARCHAR(100),department_id INT,manager_id INT,salary DECIMAL(10, 2),);
insert into employees (name, department_id, manager_id, salary) values('Alice Thompson', 1, 2, 60000.00),('Bob Martin', 1, 2, 55000.00),
('Charlie Harris', 2, 3, 45000.00),('Diana White', 2, 3, 47000.00),('Edward Green', 3, NULL, 70000.00),('Fiona Black', 3, 5, 80000.00),('George King', 1, 2, 52000.00),
('Helen Clark', 2, 4, 49000.00),('Ivy Scott', 3, 5, 68000.00),('Jack Adams', 3, NULL, 72000.00);
