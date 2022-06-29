GO
if exists(select * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where CONSTRAINT_NAME = 'AdminUser')
alter table vehicles drop CONSTRAINT AdminUser
drop table if  exists ChopHouse
drop table if  exists AdminUser
drop table if  exists HouseReview
drop table if  exists UserID

GO
CREATE TABLE AdminUser(
id int IDENTITY not null,
UserName NVARCHAR(50) NOT NULL,
Password NVARCHAR(50) NOT NULL,
)
SELECT * FROM AdminUser

GO
CREATE TABLE ChopHouse(
    StoreID int IDENTITY NOT NULL,
    Name NVARCHAR(50) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    State NVARCHAR(50) NOT NULL,
    Zip int NOT NULL,
)
SELECT * FROM ChopHouse


GO
CREATE TABLE HouseReview(
    id int IDENTITY not null,
    StoreID NVARCHAR(100) NOT NULL,
    UserId NVARCHAR(100) NOT NULL,
    Rating INT NOT NULL,
    Feedback NVARCHAR (max) NOT NULL,
)

SELECT * FROM HouseReview
GO


CREATE TABLE UserID (
    UserId int IDENTITY not null,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    UserName NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_UserID PRIMARY KEY (UserID) 
    --PK_UserID PRIMARY KEY (UserID)    
)

Select * FROM UserID