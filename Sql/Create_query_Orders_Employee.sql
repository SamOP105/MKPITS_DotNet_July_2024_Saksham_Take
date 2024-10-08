CREATe TABLE Employee (
    Id INT PRIMARY KEY identity(1,1),        
    EmpName NVARCHAR(100),    
    DepartmentId INT,          
    EmpSalary DECIMAL(10, 2),
    EmpContact NVARCHAR(15),  
    EmpAddress NVARCHAR(255) 
);


INSERT INTO Employee (EmpName, DepartmentId, EmpSalary, EmpContact, EmpAddress) VALUES
('Aarav Sharma', 1, 50000.00, '9876543210', '123, MG Road, Bangalore'),
('Vivaan Verma', 2, 55000.00, '8765432109', '456, 1st Block, Delhi'),
('Aditya Rao', 1, 60000.00, '7654321098', '789, Shivaji Nagar, Mumbai'),
('Vihaan Gupta', 3, 52000.00, '6543210987', '321, Gandhi Road, Pune'),
('Krishna Iyer', 2, 58000.00, '5432109876', '654, Marine Drive, Chennai'),
('Ayaan Mehta', 3, 49000.00, '4321098765', '987, Brigade Road, Bangalore'),
('Anaya Patel', 1, 63000.00, '3210987654', '234, Connaught Place, Delhi'),
('Dhruv Singh', 2, 57000.00, '2109876543', '456, Juhu Beach, Mumbai'),
('Nisha Rao', 3, 48000.00, '1098765432', '789, Hiranandani, Pune'),
('Saanvi Khanna', 1, 70000.00, '0987654321', '123, Nungambakkam, Chennai');
CREATE TABLE XOrders (
    Id INT PRIMARY KEY IDENTITY(1,1),  
    OrdersDate DATETIME,        
    CustomerId INT ,                    
    TotalAmount DECIMAL(18, 2) ,      
    OrdersNumber VARCHAR(50)        
);
