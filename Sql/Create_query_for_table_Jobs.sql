create table Jobs (Job_ID int identity(1,1), Job_Title varchar(10),Job_MinSal money, Job_MaxSal money);
Alter table Jobs Add CurrentDate Date;


insert into Jobs (Job_Title, Job_MinSal, Job_MaxSal, CurrentDate)
values ('Data', 50000, 100000, '2024-09-27'),('Manager', 80000, 150000, '2024-09-27'),('Mining', 45000, 85000, '2024-09-27'),
('Clerk', 25000, 50000, '2024-09-27'),('Consultant', 60000, 120000, '2024-09-27');