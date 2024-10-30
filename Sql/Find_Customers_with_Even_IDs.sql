--Find Customers with Even IDs: Select customers whose CustomerID is an even
-- number using the MOD function.


select * from Customer where ID % 2 = 0;