CREATE DATABASE RFID_Library
go

use 
RFID_Library
go


CREATE TABLE AUTHOR
( 
	authorId             integer  NOT NULL ,
	AutherFirstName               char(40)  NULL ,
	AutherLastName               char(40)  NULL 
)
go

CREATE TABLE BOOK
( 
	bookId               integer  NOT NULL ,
	typeId               integer  NOT NULL ,
	authorId             integer  NOT NULL ,
	Title                 char(40)  NULL ,
	pagecount            integer  NULL 
)
go

CREATE TABLE BORROW
( 
	borrowID             char(40)  NOT NULL ,
	fromDate             date  NULL ,
	toDate               date  NULL ,
	bookId               integer  NOT NULL ,
	PersonID             integer  NULL 
)
go

CREATE TABLE PERSON
( 
	PersonID             integer  NOT NULL ,
	fName                char(40)  NULL ,
	lName                char(40)  NULL ,
	phone                integer  NULL ,
	email                char(60)  NULL ,
	dOB                  date  NULL ,
	Username			 char(40) NOT NULL,
	Password			 char(40) NOT NULL
)
go

CREATE TABLE RFID
( 
	rfidId               char(18)  NOT NULL ,
	fromDate             date  NULL ,
	toDate               date  NULL ,
	PersonID             integer  NOT NULL 
)
go

CREATE TABLE TYPE
( 
	typeId               integer  NOT NULL ,
	TypeName                 char(40)  NULL 
)
go

ALTER TABLE AUTHOR
	ADD CONSTRAINT XPKAUTHOR PRIMARY KEY  CLUSTERED (authorId ASC)
go

ALTER TABLE BOOK
	ADD CONSTRAINT XPKBOOK PRIMARY KEY  CLUSTERED (bookId ASC)
go

ALTER TABLE BORROW
	ADD CONSTRAINT XPKBORROW PRIMARY KEY  CLUSTERED (borrowID ASC)
go

ALTER TABLE PERSON
	ADD CONSTRAINT XPKPERSON PRIMARY KEY  CLUSTERED (PersonID ASC)
go

ALTER TABLE RFID
	ADD CONSTRAINT XPKRFID PRIMARY KEY  CLUSTERED (rfidId ASC,PersonID ASC)
go

ALTER TABLE TYPE
	ADD CONSTRAINT XPKTYPE PRIMARY KEY  CLUSTERED (typeId ASC)
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
	ADD CONSTRAINT R_18 FOREIGN KEY (PersonID) REFERENCES PERSON(PersonID)
go


ALTER TABLE RFID
	ADD CONSTRAINT R_19 FOREIGN KEY (PersonID) REFERENCES PERSON(PersonID)
go