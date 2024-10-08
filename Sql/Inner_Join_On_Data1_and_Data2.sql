--syntax for join
select table_name_1.column_name,table_name_2.column_name from table_name_1 join table_name_2 
on table_name_1.common_column=table_name_2.common_column;

--Inner joins 
select d1.fname, d2.department from data1 d1 join data2 d2 on d1.Id=d2.D1Id;
