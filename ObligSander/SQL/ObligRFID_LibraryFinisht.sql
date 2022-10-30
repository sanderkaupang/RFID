CREATE DATABASE RFID_Library2
go
USE RFID_lIBRARY2
GO

CREATE TABLE AUTHOR
( 
	authorId             integer  IDENTITY ( 1,1 )  NOT NULL ,
	AutherFirstName      char(40)  NULL ,
	AutherLastName       char(40)  NULL ,
	CONSTRAINT XPKAUTHOR PRIMARY KEY  CLUSTERED (authorId ASC)
)
go

CREATE TABLE BOOK
( 
	bookId               integer  IDENTITY ( 1,1 )  NOT NULL ,
	typeId               integer  NOT NULL ,
	authorId             integer  NOT NULL ,
	Title                char(40)  NULL ,
	pagecount            integer  NULL ,
	CONSTRAINT XPKBOOK PRIMARY KEY  CLUSTERED (bookId ASC)
)
go

CREATE TABLE BORROW
( 
	borrowID             integer  IDENTITY ( 1,1 )  NOT NULL ,
	fromDate             date  NULL ,
	toDate               date  NULL ,
	bookId               integer  NOT NULL ,
	PersonID             integer  NULL ,
	rfidId               integer  NULL ,
	CONSTRAINT XPKBORROW PRIMARY KEY  CLUSTERED (borrowID ASC)
)
go

CREATE TABLE PERSON
( 
	PersonID             integer  IDENTITY ( 1,1 )  NOT NULL ,
	fName                char(40)  NULL ,
	lName                char(40)  NULL ,
	phone                integer  NULL ,
	email                char(60)  NULL ,
	dOB                  date  NULL ,
	Username             char(40)  NULL ,
	Password             char(40)  NULL ,
	CONSTRAINT XPKPERSON PRIMARY KEY  CLUSTERED (PersonID ASC)
)
go

CREATE TABLE RFID
( 
	rfidId               integer  NOT NULL ,
	PersonID             integer  NOT NULL ,
	CONSTRAINT XPKRFID PRIMARY KEY  CLUSTERED (rfidId ASC,PersonID ASC)
)
go

CREATE TABLE TYPE
( 
	typeId               integer  IDENTITY ( 1,1 )  NOT NULL ,
	TypeName             char(40)  NULL ,
	CONSTRAINT XPKTYPE PRIMARY KEY  CLUSTERED (typeId ASC)
)
go


ALTER TABLE BOOK
	ADD CONSTRAINT R_16 FOREIGN KEY (typeId) REFERENCES TYPE(typeId)
go

ALTER TABLE BOOK
	ADD CONSTRAINT R_17 FOREIGN KEY (authorId) REFERENCES AUTHOR(authorId)
go


ALTER TABLE BORROW
	ADD CONSTRAINT R_14 FOREIGN KEY (bookId) REFERENCES BOOK(bookId)
go

ALTER TABLE BORROW
	ADD CONSTRAINT R_20 FOREIGN KEY (rfidId,PersonID) REFERENCES RFID(rfidId,PersonID)
go


ALTER TABLE RFID
	ADD CONSTRAINT R_19 FOREIGN KEY (PersonID) REFERENCES PERSON(PersonID)
go