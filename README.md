██████  ███████ ██ ██████      ██      ██ ██████  ██████   █████  ██████  ██    ██ 
██   ██ ██      ██ ██   ██     ██      ██ ██   ██ ██   ██ ██   ██ ██   ██  ██  ██  
██████  █████   ██ ██   ██     ██      ██ ██████  ██████  ███████ ██████    ████   
██   ██ ██      ██ ██   ██     ██      ██ ██   ██ ██   ██ ██   ██ ██   ██    ██    
██   ██ ██      ██ ██████      ███████ ██ ██████  ██   ██ ██   ██ ██   ██    ██    
                                                                                   

This project is motivated by Education, object-oriented programming.
The project deals with a library system for submitting and lending books from the library.
----------------------------------------------------------------------------------------------------
Languages: C#, SQL, HTML5
IDE: Visual Studio 2022, Microsoft SQL Server Management Studio 18
Frameworks: ASP.Net, WinForm, SQL-server
Hardwear: Neo2  RFID-reader with 5 tags
----------------------------------------------------------------------------------------------------
Files located at:

Logging (WinForm)
logs all borrowed books and people registered for borrowing at the library. This sinks together with the database located under "RFID_LibraryDatabase"
The logging application also writes selected results to EXCEL

data management (ASP.Net)
Talking to the database. the end user registers the loan of a book as well as the return of the book.
Other end users can see if the book they want is in the library or borrowed, possibly when it is available for the next loan

RFID_LibraryDatabase (SQL-server)
Set up the database and enter test values ​​as well as values ​​from the RFID reader.
----------------------------------------------------------------------------------------------------
How to start
1) Download Zip-folder 
2) Rightclick and go to properties
3) check off remove block
4) Open SQL "RFID_LibraryDatabase" and run it 
5) Open SQL "Inser_Statment" and run it
6) Then you can run which of the C# applications you want