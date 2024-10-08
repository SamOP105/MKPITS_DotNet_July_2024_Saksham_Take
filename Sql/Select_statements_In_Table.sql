
select count(id) as DATA  from data1;
select count(*) from data1;

select e.department,e.Email from data2 e;

select * from data2 where department='IT';

select * from data3 order by salary desc;

select avg(salary) as Salary from data3;

select department,count(Id) as number_of_employees from data2 group by department;

