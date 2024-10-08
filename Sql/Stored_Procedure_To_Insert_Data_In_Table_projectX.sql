--create table X(id int identity(1,1), FName varchar(20), LName varchar(20), EmpId int);

CREATE PROCEDURE InsertIntoX
    @FName VARCHAR(20),
    @LName VARCHAR(20),
    @EmpId INT
AS
BEGIN
    -- Inserting data into table X
    INSERT INTO X (FName, LName, EmpId)
    VALUES (@FName, @LName, @EmpId);

    SELECT * FROM X WHERE id = SCOPE_IDENTITY();
END;
