CREATE PROCEDURE UpdateUsernamePAssword


@phone int,
@Username char(40),
@Password char(40)
AS

UPDATE PERSON
SET
phone = @phone,
Username = @Username,
Password = @Password
WHERE phone = @phone