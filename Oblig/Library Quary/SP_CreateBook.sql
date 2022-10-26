IF EXISTS (SELECT name
FROM sysobjects
WHERE name = 'CreateBook'
AND type = 'P')
DROP PROCEDURE CreateBook
GO

CREATE PROCEDURE CreateBook
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

INSERT INTO BOOK(Title,pagecount)
VALUES 
(
@Title,
@pageCount
)
INSERT INTO TYPE(TypeName)
VALUES 
(
@TypeName
)
INSERT INTO AUTHOR (AutherFirstName, AutherLastName)
VALUES
(
@AutherFirstName,
@AutherLastName
)
Go

insert into TYPE(TypeName)
VALUES
(
('Roman')
)
GO

SELECT * FROM BOOK