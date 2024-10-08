create table orders (order_id int primary key identity(0,1),customer_id INT,order_amount money,order_date DATE,);
insert into orders (customer_id, order_amount, order_date) values(1, 250.50, '2024-09-01'),(2, 120.75, '2024-09-03'),(3, 350.00, '2024-09-05')
,(4, 220.25, '2024-09-06'),(5, 400.00, '2024-09-07'),(6, 80.50, '2024-09-08'),(7, 99.99, '2024-09-10'),(8, 150.30, '2024-09-12'),(9, 500.00, '2024-09-13'),
(10, 75.25, '2024-09-14');

