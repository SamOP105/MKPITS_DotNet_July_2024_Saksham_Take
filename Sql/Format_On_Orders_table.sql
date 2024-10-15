--14. Format Date of Birth: Write a query to format the DateOfBirth field as
--MM/DD/YYYY using the FORMAT function.

SELECT ID,FORMAT(ordersDate, 'MM/dd/yyyy') AS FormattedDateOfBirth
FROM Orders;

--15. Find Customers with Upcoming Birthdays: Select customers whose birthdays fall
--within the next 30 days using the DAY, MONTH, and GETDATE functions.

select 