create table products (product_id int primary key identity(0,1),product_name VARCHAR(100),category_id INT,);

insert into products (product_name, category_id) values('Laptop', 1),('Smartphone', 1),('Headphones', 2),('Tablet', 1),('Monitor', 3),
('Keyboard', 3),('Mouse', 3),('Printer', 3),('Charger', 2),('Webcam', 3);
