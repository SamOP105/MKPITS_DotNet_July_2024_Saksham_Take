create or alter trigger tr_SelectPersonal
on Personal
After Insert 
As
Begin
Select * from Personal;
End;
--Sql Server does not support before 

insert into Personal values('Saksham','Prabhakar','Take',22,1);