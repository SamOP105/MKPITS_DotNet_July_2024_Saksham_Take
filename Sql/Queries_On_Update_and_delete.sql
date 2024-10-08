create table country (country_Id int, Country_Name varchar(20) , Region_Id int);

create table Jobs (Job_ID int identity(1,1), Job_Title varchar(10),Job_MinSal money, Job_MaxSal money);

--create a table job history including columns empid, start date, end date, job id, dept id

create table Job_History (Emp_ID int identity(1,1), StartDate Date, EndDate date,Job_ID int,Dept_ID int);

Alter table Country Add CurrentDate Date;
Alter table Jobs Add CurrentDate Date;
Alter table Job_History Add CurrentDate Date;


insert into Country (country_Id, Country_Name, Region_Id, CurrentDate)
values (1, 'USA', 101, '2024-09-27'),(2, 'India', 102, '2024-09-27'),(3, 'Germany', 103, '2024-09-27'),
(4, 'Japan', 104, '2024-09-27'),(5, 'Australia', 105, '2024-09-27');

insert into Jobs (Job_Title, Job_MinSal, Job_MaxSal, CurrentDate)
values ('Data', 50000, 100000, '2024-09-27'),('Manager', 80000, 150000, '2024-09-27'),('Mining', 45000, 85000, '2024-09-27'),
('Clerk', 25000, 50000, '2024-09-27'),('Consultant', 60000, 120000, '2024-09-27');

Insert into Job_History (StartDate, EndDate, Job_ID, Dept_ID, CurrentDate)
Values ('2021-01-01', '2022-06-30', 1, 10, '2024-09-27'),('2020-03-15', '2023-03-31', 2, 20, '2024-09-27'),('2019-05-20', '2021-12-31', 3, 30, '2024-09-27'),
('2018-10-01', '2020-10-01', 4, 40, '2024-09-27'),('2022-01-01', '2023-01-01', 5, 50, '2024-09-27');

Update country Set Country_Name='Japan' where country_Id=1;
Update Jobs Set Job_Title='Marketing' where Job_Id=0;
Update Job_History Set StartDate='2022-01-01' where Emp_ID=0;

Delete From country where country_Id=2;
Delete From Jobs where Job_Id=3;
Delete From Job_History where Emp_Id=1;

