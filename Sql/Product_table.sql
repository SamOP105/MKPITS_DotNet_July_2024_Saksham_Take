--Create Product Table
create table tblProducts (tID int Primary
key IDentity(1,1),ProductName varchar(20),Recommended money,Category varchar(10));

INSERT INTO tblProducts(ProductName, RecommendedPrice, Category) 
VALUES
    ('DVD', 105.00, 'LivingRoom'),
    ('Microwave', 98.00, 'Kitchen'),
    ('Monitor', 200.00, 'Office'),
    ('Speakers', 85.00, 'Office'),
    ('Refrigerator', 900.00, 'Kitchen'),
    ('VCR', 165.00, 'LivingRoom'),
    ('CoffeePot', 35.00, 'Kitchen');