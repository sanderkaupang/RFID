USE [RFID_Library]
GO
/****** Object:  StoredProcedure [dbo].[CreateBook]    Script Date: 10/18/2022 8:02:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[CreateBook]
@bookId int,
@Title char(40),
@pageCount int,

@authorId int,
@AutherFirstName char(40),
@AutherLastName char(40),

@typeId int,
@TypeName char(40)
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
(SELECT typeId from TYPE WHERE typeId = @typeId),
@pageCount,
(SELECT authorId from AUTHOR WHERE authorId = @authorId)
)

INSERT INTO AUTHOR (authorId,AutherFirstName,AutherLastName)
VALUES 
(
@authorId,
@AutherFirstName,
@AutherLastName
)

INSERT INTO TYPE (typeId, TypeName)
VALUES 
(
@typeId,
@TypeName
)