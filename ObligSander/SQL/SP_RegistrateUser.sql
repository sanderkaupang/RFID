CREATE PROCEDURE RegistrateUser
@fName char(40),
@lName char(40),
@phone int,
@email char(40),
@dOB date,
@Username char(40),
@Password char(40)
AS

INSERT INTO PERSON(fName,lName,phone,email,dOB,Username,Password)
VALUES 
(@fName,@lName,@phone,@email,@dOB,@Username,@Password)
Go