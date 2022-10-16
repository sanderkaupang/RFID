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
LEFT JOIN AUTHOR ON BOOK.authorId = AUTHOR.authorId
LEFT JOIN TYPE ON BOOK.typeId = TYPE.typeId
