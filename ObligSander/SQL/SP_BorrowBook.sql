CREATE PROCEDURE BorrowBook

@toDate char(40),
@fromDate char(40),
@bookId int,
@rfidId char(40)
AS


INSERT INTO BORROW(fromDate,toDate,bookId,rfidId, PersonID)
VALUES
(
@toDate,
@fromDate,
@bookId,
@rfidId,
(SELECT PersonId from RFID)

)

GO
