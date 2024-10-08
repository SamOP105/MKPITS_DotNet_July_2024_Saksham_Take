create or alter procedure sp_get
@product_name varchar(100),
@category_id int,
@customer_id int,
@order_amount money

As
Begin
insert into products(product_name,category_id) values (@product_name, @category_id)
insert into orders(customer_id,order_amount) values (@customer_id,@order_amount)
select * from orders
select * from products;
End
exec sp_get @product_name='neeraj', @category_id=121,@customer_id=12,@order_amount=999;