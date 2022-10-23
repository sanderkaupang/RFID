USE 
RFID_Library
GO

INSERT INTO PERSON(fName,lName,phone,email,dOB, Username, Password)
VALUES('Ole', 'Hansen',98999400,'Ole.Hansen@gmai.com', '2000/11/11', 1234,1412)
INSERT INTO PERSON(fName,lName,phone,email,dOB, Username, Password)
VALUES('Nils', 'Hansen',98999400,'Ole.Hansen@gmai.com', '2000/11/11', 1,1)

SELECT * FROM PERSON
--TESTVALUES BOOK---------------------------------
INSERT INTO BOOK(Title,pagecount, typeId,authorId)
VALUES('Python',323, (SELECT typeId from TYPE WHERE typeId = 1), (SELECT authorId FROM AUTHOR WHERE authorId =1) )
INSERT INTO BOOK(Title,pagecount, typeId, authorId)
VALUES('Snømannen',541, (SELECT typeId from TYPE WHERE typeId = 2), (SELECT authorId FROM AUTHOR WHERE authorId =2))
INSERT INTO BOOK(Title,pagecount, typeId,authorId)
VALUES('Elon Musk',401,(SELECT typeId from TYPE WHERE typeId = 3), (SELECT authorId FROM AUTHOR WHERE authorId =3))

--TESTVALUES TYPE---------------------------------
INSERT INTO TYPE(TypeName)
VALUES('Programmering')
INSERT INTO TYPE(TypeName)
VALUES('Roman')
INSERT INTO TYPE(TypeName)
VALUES('Biografi')

--TESTVALUES AUTHER---------------------------------
INSERT INTO AUTHOR(AutherFirstName, AutherLastName)
VALUES('ole', 'Nordmann')
INSERT INTO AUTHOR(AutherFirstName, AutherLastName)
VALUES('Nils', 'Hansen')
INSERT INTO AUTHOR(AutherFirstName, AutherLastName)
VALUES('Herman', 'Pedersen')

