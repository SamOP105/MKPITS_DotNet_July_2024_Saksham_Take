--Round Up Customer Ratings: Write a query to round up customer ratings (if any) to
-- the nearest whole number using the CEILING function.


select ID, CEILING(CustomerRating) AS RoundedUpCustomerRating from Customer;