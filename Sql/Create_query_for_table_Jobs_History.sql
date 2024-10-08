create table Job_History (Emp_ID int identity(1,1), StartDate Date, EndDate date,Job_ID int,Dept_ID int);
Alter table Job_History Add CurrentDate Date;


Insert into Job_History (StartDate, EndDate, Job_ID, Dept_ID, CurrentDate)
Values ('2021-01-01', '2022-06-30', 1, 10, '2024-09-27'),('2020-03-15', '2023-03-31', 2, 20, '2024-09-27'),('2019-05-20', '2021-12-31', 3, 30, '2024-09-27'),
('2018-10-01', '2020-10-01', 4, 40, '2024-09-27'),('2022-01-01', '2023-01-01', 5, 50, '2024-09-27');
