--Create Customer Table
create table  tblCustomers (CustomerID int Primary
key IDentity(1,1),FirstName varchar(50),LastName varchar(50),City varchar(50),State char(2),Zip varchar(10));

INSERT INTO tblCustomers (FirstName, LastName, City, State, Zip)
VALUES
    ('Chintan', 'Patel', 'Anand', 'GJ', '388001'),
    ('Paresh', 'Prajapati', 'Nadiad', 'GJ', '387001'),
    ('Pragnesh', 'Patel', 'Surat', 'GJ', '395008'),
    ('Nilesh', 'Dharsandia', 'Mumbai', 'MH', '400002'),
    ('Sonal', 'Patel', 'Mumbai', 'MH', '400002'),
    ('Harshal', 'Patel', 'Mogri', 'GJ', '388345'),
    ('Prakash', 'Rathod', 'Mogri', 'GJ', '388345'),
    ('Aarzoo', 'Dodhiya', 'Rajkot', 'GJ', '360003'),
    ('Heta', 'Dave', 'Varanasi', 'UP', '221002'),
    ('Nikita', 'Dave', 'Varanasi', 'UP', '221002'),
    ('Vaibhav', 'Dave', 'Varanasi', 'UP', '221002'),
    ('Paresh', 'Patel', 'Pune', 'MH', '411001'),
    ('Prakash', 'Patel', 'Pune', 'MH', '411001'),
    ('Sandhya', 'Patel', 'Hyderabad', 'AP', '500031'),
    ('Divesh', 'Patel', 'Banglore', 'KA', '560002'),
    ('Payal', 'Shah', 'Banglore', 'KA', '560002'),
    ('Priyanka', 'Rana', 'Anand', 'GJ', '388001'),
    ('Sanket', 'Dhebar', 'V.V.Nagar', 'GJ', '388121'),
    ('Puja', 'Shah', 'Varanasi', 'UP', '221002'),
    ('Priya', 'Shah', 'Varanasi', 'UP', '221002');
