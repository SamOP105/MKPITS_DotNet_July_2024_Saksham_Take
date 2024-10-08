create table Data1( Id int primary key identity(1,1),
FName varchar(55),MName Varchar(55) ,LName varchar(55),
);
INSERT INTO Data1 (FName, MName, LName)
VALUES 
('Amit', 'Kumar', 'Sharma'),
('Priya', 'Rani', 'Verma'),
('Rajesh', 'Singh', 'Thakur'),
('Sneha', 'Devi', 'Yadav'),
('Vikram', 'Pratap', 'Patel'),
('Anjali', 'Rani', 'Chauhan'),
('Ravi', 'Narayan', 'Gupta'),
('Pooja', 'Shree', 'Deshmukh'),
('Sunil', 'Mohan', 'Joshi'),
('Kiran', 'Rani', 'Mehta');
select *from Data1