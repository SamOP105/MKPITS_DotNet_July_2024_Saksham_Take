create table Data2(Id int primary key identity(1,1),
department varchar(55),Email varchar(55),CurrentDate date,D1ID int
);


INSERT INTO Data2 (Department, Email, CurrentDate, D1ID)
VALUES 
('HR', 'amit.sharma@domain.in', GETDATE(), 1),
('Finance', 'priya.verma@domain.in', GETDATE(), 2),
('IT', 'rajesh.thakur@domain.in', GETDATE(), 3),
('Admin', 'sneha.yadav@domain.in', GETDATE(), 4),
('Sales', 'vikram.patel@domain.in', GETDATE(), 5),
('Marketing', 'anjali.chauhan@domain.in', GETDATE(), 6),
('Operations', 'ravi.gupta@domain.in', GETDATE(), 7),
('Support', 'pooja.deshmukh@domain.in', GETDATE(), 8),
('Legal', 'sunil.joshi@domain.in', GETDATE(), 9),
('R&D', 'kiran.mehta@domain.in', GETDATE(), 10);