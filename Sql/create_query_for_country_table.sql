create table country (country_Id int, Country_Name varchar(20) , Region_Id int);
Alter table Country Add CurrentDate Date;

insert into Country (country_Id, Country_Name, Region_Id, CurrentDate)
values (1, 'USA', 101, '2024-09-27'),(2, 'India', 102, '2024-09-27'),(3, 'Germany', 103, '2024-09-27'),
(4, 'Japan', 104, '2024-09-27'),(5, 'Australia', 105, '2024-09-27');
