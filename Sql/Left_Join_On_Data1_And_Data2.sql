--syntax for join
select table_name_1.column_name,table_name_2.column_name from table_name_1 join table_name_2 
on table_name_1.common_column=table_name_2.common_column;

--Left join
select d1.id,d1.fname,d1.mname,d1.lname,d2.department from Data1 d1 left join data2 d2 on d1.Id=d2.D1Id;
