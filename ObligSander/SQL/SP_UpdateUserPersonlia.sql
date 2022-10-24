CREATE PROCEDURE UpdateUserPersonlia
@fName char(40),
@lName char(40),
@phone int,
@email char(40),
@dOB char(40),
@Username char(40),
@Password char(40)
AS

UPDATE PERSON
SET
fName = @fName,
lName = @lName,
phone = @phone,
email = @email,
dOB = @dOB,
Username = @Username,
Password = @Password
WHERE Password = @Password 