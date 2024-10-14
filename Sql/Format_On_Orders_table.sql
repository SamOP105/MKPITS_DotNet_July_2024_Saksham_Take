--14. Format Date of Birth: Write a query to format the DateOfBirth field as
--MM/DD/YYYY using the FORMAT function.SELECT ID,FORMAT(ordersDate, 'MM/dd/yyyy') AS FormattedDateOfBirth
FROM Orders;