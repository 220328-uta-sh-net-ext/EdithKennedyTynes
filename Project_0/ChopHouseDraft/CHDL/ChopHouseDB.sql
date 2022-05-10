
--DROP TABLE ChopHouse
CREATE TABLE ChopHouse (
    Name NVARCHAR(50) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    State NVARCHAR(50) NOT NULL,
    Rating INT NOT NULL,
    Review NVARCHAR(100) NOT NULL,
    NumRatings INT NOT NULL,
    StoreID NVARCHAR(100) NOT NULL PRIMARY KEY
)
SELECT * FROM ChopHouse

DROP TABLE UserAccount
CREATE TABLE UserAccount (
    UserID NVARCHAR(100) NOT NULL, 
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    UserName NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
)
SELECT * FROM UserAccount
--DELETE FROM ChopHouse WHERE NumRatings='0';
--DELETE FROM UserAccount WHERE 

ALTER TABLE UserAccount ADD column_UserID NVARCHAR NOT NULL


INSERT INTO ChopHouse (Name, City, State, Rating, Review, NumRatings, StoreID) VALUES ('Captain Georges', 'Newport News', 'Virginia', '5','Best seafood on the planet', '1', 'CH0001')
INSERT INTO UserAccount (UserID, FirstName, LastName, UserName, Password, Email) VALUES ('CHU00001','Anita', 'Walker', 'Ilike2Eat', 'password1234','Ilike2eat@gmail.com')