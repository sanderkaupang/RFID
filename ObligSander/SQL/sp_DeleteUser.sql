CREATE PROCEDURE DELETEUSER

@rfidId char(40),
@username char(40)
AS

Delete from RFID where rfidId = @rfidId;
Delete from PERSON where Username = @username

