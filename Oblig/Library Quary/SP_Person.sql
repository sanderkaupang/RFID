CREATE PROCEDURE PersonSave
@PersonalID int,
@fName char(40),
@lName char(40),
@phone int,
@email char(40),
@dob date
AS

INSERT INTO Person (PersonID,fName,lName,phone,email,dOB)
	values (@PersonalID,@fName,@lName,@phone,@email,@dob)
GO