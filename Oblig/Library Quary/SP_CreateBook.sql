IF EXISTS (SELECT name
FROM sysobjects
WHERE name = 'CreateBook'
AND type = 'P')
DROP PROCEDURE CreateBook
GO

CREATE PROCEDURE CreateBook
@bookId int,
@Title char(40),
@AutherFirstName char(40),
@AutherLastName char(40),
@TypeName char(40),
@pageCount int
AS

if not exists (select * from TYPE where TypeName = @TypeName)
INSERT INTO TYPE (TypeName) VALUES (@TypeName)
if not exists (select * from AUTHOR where AutherFirstName = @AutherFirstName)
INSERT INTO AUTHOR (AutherFirstName) VALUES (@AutherFirstName)
if not exists (select * from AUTHOR where AutherLastName = @AutherLastName)
INSERT INTO AUTHOR (AutherLastName) VALUES (@AutherLastName)

INSERT INTO BOOK(bookId,Title,typeId,pagecount,authorId)
VALUES 
(
@bookId,
@Title,
@TypeName,
@pageCount,
@AutherLastName
)
Go