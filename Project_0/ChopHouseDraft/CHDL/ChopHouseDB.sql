
--DROP TABLE ChopHouse

CREATE TABLE ChopHouse (
    StoreID NVARCHAR(100) NOT NULL PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    State NVARCHAR(50) NOT NULL
    
)
SELECT * FROM ChopHouse

SELECT * FROM AdminView

CREATE TABLE AdminView (
    StoreID NVARCHAR(100) NOT NULL,
    UserId NVARCHAR(100) NOT NULL,
    Rating INT NOT NULL,
    NumRatings INT NOT NULL,
    
)

--DROP TABLE HouseReview

SELECT * FROM HouseReview

CREATE TABLE HouseReview (
    StoreID NVARCHAR(100) NOT NULL,
    UserId NVARCHAR(100) NOT NULL,
    Rating INT NOT NULL,
    Feedback NVARCHAR(100) NOT NULL,
    
)
--Rating INT NOT NULL,
    --Review NVARCHAR(100) NOT NULL,
    --NumRatings INT NOT NULL,

--DROP TABLE UserAccount


CREATE TABLE UserAccount (
    UserID DATETIME2 NOT NULL DEFAULT 'myDateTime',
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    UserName NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_UserID PRIMARY KEY (UserID) 
    --PK_UserID PRIMARY KEY (UserID)    
)
DECLARE @DATETIME DATETIME = GetDate();
--CONVERT(VARCHAR(20),@dt,0) s1,
SELECT CONVERT (NVARCHAR(25), GetDate()
--,CONVERT (date, SYSUTCDATETIME())   
-- 
--SELECT CURRENT_TIMESTAMP;  
--DECLARE @UserID DATETIME = CURRENT_TIMESTAMP;
--DECLARE @myDateTime NVARCHAR(25) = CONVERT(NVARCHAR, @DateTime, 126);
--SELECT @myDateTime AS 'myDateTime' 
--CONVERT ( data_type [ ( length ) ] , expression [ , style ] )  
)

INSERT INTO UserAccount(UserID, FirstName, LastName, UserName, Password, Email) VALUES ('myDateTime','Anita', 'Walker', 'Ilike2Eat', 'password1234','Ilike2eat@gmail.com')

SELECT * FROM UserAccount


--SELECT 
    
   -- CONVERT(VARCHAR(20),@dt,100) s2;

--DELETE FROM ChopHouse WHERE NumRatings='0';
--DELETE FROM UserAccount WHERE 

ALTER TABLE UserAccount ADD column_UserID NVARCHAR NULL

--ALTER TABLE UserAccount ADD 
--CONSTRAINT DF_UserID DEFAULT SYSUTCDATETIME() FOR UserID

INSERT INTO ChopHouse (Name, City, State, Rating, Review, NumRatings, StoreID) VALUES ('Captain Georges', 'Newport News', 'Virginia', '5','Best seafood on the planet', '1', 'CH0001')
INSERT INTO UserAccount (UserID, FirstName, LastName, UserName, Password, Email) VALUES ('CHU00001','Anita', 'Walker', 'Ilike2Eat', 'password1234','Ilike2eat@gmail.com')