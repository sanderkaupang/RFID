CREATE PROCEDURE UpdatePasswordOnly


@phone int,
@Password char(40)
AS

UPDATE PERSON
SET
phone = @phone,
Password = @Password
WHERE phone = @phone