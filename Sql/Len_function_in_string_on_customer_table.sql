--9.Check Length of Customer Names: Write a query to select CustomerID,
--FirstName, and the length of FirstName using the LEN function.
select len(firstName) as LFirstName,len(LastName) As LlastName from Customer