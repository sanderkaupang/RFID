CREATE VIEW GetBookData
AS
SELECT 
BOOK.bookId,
BOOK.Title,
BOOK.pagecount,
Type.TypeName,
AUTHOR.AutherFirstName,
AUTHOR.AutherLastName 

FROM BOOK
INNER JOIN AUTHOR ON BOOK.authorId = AUTHOR.authorId
INNER JOIN TYPE ON BOOK.typeId = TYPE.typeId
