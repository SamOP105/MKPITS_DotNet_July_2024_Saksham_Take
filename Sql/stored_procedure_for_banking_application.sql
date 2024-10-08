--9. Write a stored procedure to transfer funds between two accounts in a banking application. 
--The procedure should accept source account ID, destination account ID, and the amount as parameters,
--and ensure that the source account has sufficient funds before proceeding with the transfer.

create or alter procedure sp_balance
@SAcc bigint,
@RAcc bigint,
@transferId bigint,
@Amount decimal(10,2)
As
begin
select BalanceAmt from AccountDetails where TransferId=@transferId
if((select BalanceAmt from AccountDetails where TransferId=@transferId)>=@Amount)
Update AccountDetails Set BalanceAmt=BalanceAmt-@Amount,SAcc=@SAcc,RAcc=@RAcc where TransferId=@transferId
select BalanceAmt from AccountDetails where TransferId=@transferId
end;

exec sp_balance @SAcc=165,@RAcc=183,@Amount=188.78,@transferId=123