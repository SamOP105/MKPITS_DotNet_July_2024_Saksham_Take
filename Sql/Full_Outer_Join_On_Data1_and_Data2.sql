--syntax for join
select table_name_1.column_name,table_name_2.column_name from table_name_1 join table_name_2 
on table_name_1.common_column=table_name_2.common_column;

--full join 
select d1.id,d1.fname,d1.mname,d1.lname, d2.Id, d2.department, d2.email, d2.currentdate, d2.d1id from data1 d1 full outer join Data2 d2 on d1.Id=d2.D1Id;
