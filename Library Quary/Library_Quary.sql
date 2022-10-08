CREATE DATABASE RFID_Library
go
use RFID_Library
go
CREATE TABLE AUTHOR
( 
	AuthorID             char(48)  NOT NULL ,
	Fname                char(48)  NULL ,
	Lname                char(48)  NULL ,
	CONSTRAINT XPKAUTHOR PRIMARY KEY  CLUSTERED (AuthorID ASC)
)
go

CREATE TABLE BOOKS
( 
	BookID               char(48)  NOT NULL ,
	Name                 char(48)  NULL ,
	Pagecount            char(48)  NULL ,
	AuthorID             char(48)  NULL ,
	TypeID               char(48)  NULL ,
	CONSTRAINT XPKBOOKS PRIMARY KEY  CLUSTERED (BookID ASC)
)
go

CREATE TABLE BORROW
( 
	BorrowID             char(48)  NOT NULL ,
	TakenDate            char(48)  NULL ,
	BookID               char(48)  NULL ,
	TagID                char(48)  NULL ,
	CONSTRAINT XPKBORROW PRIMARY KEY  CLUSTERED (BorrowID ASC)
)
go

CREATE TABLE RFID
( 
	TagID                char(48)  NOT NULL ,
	Tag_Activation       char(48)  NULL ,
	StudentID            char(48)  NOT NULL ,
	Expired              char(48)  NULL ,
	CONSTRAINT XPKRFID PRIMARY KEY  CLUSTERED (TagID ASC)
)
go

CREATE TABLE STUDENT
( 
	StudentID            char(48)  NOT NULL ,
	Lname                char(48)  NULL ,
	Fname                char(48)  NULL ,
	Birthdate            char(48)  NULL ,
	Class                char(48)  NULL ,
	Gender               char(48)  NULL ,
	CONSTRAINT XPKSTUDENT PRIMARY KEY  CLUSTERED (StudentID ASC)
)
go

CREATE TABLE TYPE
( 
	TypeID               char(48)  NOT NULL ,
	Name                 char(48)  NULL ,
	CONSTRAINT XPKTYPE PRIMARY KEY  CLUSTERED (TypeID ASC)
)
go


ALTER TABLE BOOKS
	ADD CONSTRAINT R_19 FOREIGN KEY (AuthorID) REFERENCES AUTHOR(AuthorID)
go

ALTER TABLE BOOKS
	ADD CONSTRAINT R_20 FOREIGN KEY (TypeID) REFERENCES TYPE(TypeID)
go


ALTER TABLE BORROW
	ADD CONSTRAINT R_18 FOREIGN KEY (BookID) REFERENCES BOOKS(BookID)
go

ALTER TABLE BORROW
	ADD CONSTRAINT R_22 FOREIGN KEY (TagID) REFERENCES RFID(TagID)
go


ALTER TABLE RFID
	ADD CONSTRAINT R_13 FOREIGN KEY (StudentID) REFERENCES STUDENT(StudentID)
go