create or alter trigger tr_newPersonal
on Personal
After Insert
As
Begin
Insert into dpt values ((select max(id) from personal))
end;
insert into Personal values('Saksham','Prabhakar','Take',22,1);