IF EXISTS (SELECT name
FROM sysobjects
WHERE name = 'UpdateBook'
AND type = 'P')
DROP PROCEDURE UpdateBook
GO

CREATE PROCEDURE UpdateBook
@BookId int,
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


UPDATE BOOK SET
bookId = @BookId,
Title = @Title,
pagecount = @pageCount,
typeId = (SELECT TypeName FROM TYPE WHERE TypeName = @TypeName),
authorId = (SELECT AutherLastName FROM AUTHOR WHERE AutherLastName = @AutherLastName)
GO