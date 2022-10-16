USE 
RFID_Library
GO

INSERT INTO PERSON(PersonID, fName,lName,phone,email,dOB)
VALUES(123,'Ole', 'Hansen',98999400,'Ole.Hansen@gmai.com', '2000/11/11')

--TESTVALUES BOOK---------------------------------
INSERT INTO BOOK(bookId,Title,pagecount, typeId,authorId)
VALUES(400,'Python',323, (SELECT typeId from TYPE WHERE typeId = 32), (SELECT authorId FROM AUTHOR WHERE authorId =1) )
INSERT INTO BOOK(bookId,Title,pagecount, typeId, authorId)
VALUES(401,'Snømannen',541, (SELECT typeId from TYPE WHERE typeId = 30), (SELECT authorId FROM AUTHOR WHERE authorId =2))
INSERT INTO BOOK(bookId,Title,pagecount, typeId,authorId)
VALUES(402,'Elon Musk',401,(SELECT typeId from TYPE WHERE typeId = 31), (SELECT authorId FROM AUTHOR WHERE authorId =3))

--TESTVALUES TYPE---------------------------------
INSERT INTO TYPE(typeId,TypeName)
VALUES(32,'Programmering')
INSERT INTO TYPE(typeId,TypeName)
VALUES(30,'Roman')
INSERT INTO TYPE(typeId,TypeName)
VALUES(31,'Biografi')

--TESTVALUES AUTHER---------------------------------
INSERT INTO AUTHOR(authorId, AutherFirstName, AutherLastName)
VALUES(1,'ole', 'Nordmann')
INSERT INTO AUTHOR(authorId, AutherFirstName, AutherLastName)
VALUES(2,'Nils', 'Hansen')
INSERT INTO AUTHOR(authorId, AutherFirstName, AutherLastName)
VALUES(3,'Herman', 'Pedersen')

