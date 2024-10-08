--Create Sales Table
create table  tblSales (SalesID int Primary
key IDentity(1,1),ProductID int Foreign Key References tblProducts(ProductID),CustomerID int Foreign Key References tblCustomers(CustomerID),SalesPrice money,SalesDate Smalldatetime);


INSERT INTO tblSales ( ProductID, CustomerID, SalesPrice, SalesDate)
VALUES
    (1, 1, 130.00, '2005-06-14'),
    (2, 2, 97.00, '2005-06-19'),
    (3, 3, 200.00, '2005-09-20'),
    (4, 4, 80.00, '2005-03-22'),
    (5, 5, 899.00, '2005-01-23'),
    (6, 6, 150.00, '2005-03-24'),
    (3, 7, 209.00, '2005-03-10'),
    (4, 8, 90.00, '2005-08-11'),
    (6, 9, 130.00, '2005-08-12'),
    (2, 14, 85.00, '2005-12-13'),
    (3, 15, 240.00, '2005-05-14'),
    (1, 17, 87.00, '2005-07-19'),
    (2, 18, 99.00, '2005-09-20'),
    (1,9, 150.00, '2005-07-22'),
    (5, 5, 900.00, '2005-03-06'),
    (4, 6, 86.00, '2005-04-07'),
    (2, 7, 88.00, '2005-11-08'),
    (3, 8, 198.00, '2005-05-09'),
    (1, 9, 150.00, '2005-10-10'),
    (6, 14, 99.00, '2005-05-09'),
    (6, 15, 104.00, '2005-09-20'),
    (4, 14, 90.00, '2005-07-22'),
    (1, 1, 130.00, '2005-03-06'),
    (2, 2, 102.00, '2005-04-07'),
    (1, 3, 114.00, '2005-11-08'),
    (5, 4, 1000.00, '2005-05-09'),
    (5, 5, 1100.00, '2005-10-10'),
    (3,6, 285.00, '2005-06-11'),
    (2, 7, 87.00, '2005-10-12'),
    (3, 8, 300.00, '2005-07-13'),
    (3, 20, 205.00, '2005-12-31');