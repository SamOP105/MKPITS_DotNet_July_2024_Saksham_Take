--Round Down Loyalty Points: Retrieve the CustomerID and loyalty points rounded
-- down to the nearest whole number using the FLOOR function.


SELECT ID, FLOOR(LoyaltyPoints) AS RoundedLoyaltyPoints FROM Customer;