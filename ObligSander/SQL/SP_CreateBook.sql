create procedure CreateBook

@Title char(40),
@pageCount int,
@AutherFirstName char(40),
@AutherLastName char(40),
@TypeName char(40)
AS

--if not exists (select * from TYPE where TypeName = @TypeName)
--INSERT INTO TYPE (TypeName) VALUES (@TypeName)

--if not exists (select * from AUTHOR where AutherFirstName = @AutherFirstName)
--INSERT INTO AUTHOR (AutherFirstName) VALUES (@AutherFirstName)
--if not exists (select * from AUTHOR where AutherLastName = @AutherLastName)
--INSERT INTO AUTHOR (AutherLastName) VALUES (@AutherLastName)
--select TYPE.TypeName into BOOK.


INSERT INTO AUTHOR (AutherFirstName,AutherLastName)
VALUES 
(
@AutherFirstName,
@AutherLastName
)

INSERT INTO TYPE ( TypeName)
VALUES 
(
@TypeName
)

INSERT INTO BOOK(Title,typeId, authorId,pagecount)
VALUES 
(
@Title,
(SELECT typeId from Type where TypeName = @TypeName),
(SELECT authorId from AUTHOR where AutherLastName = @AutherLastName),
@pageCount
)
