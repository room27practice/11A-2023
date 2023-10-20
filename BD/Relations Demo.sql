/* ���� � ��� ������ �� ��������� �� ���� � 
���������� � ��������� �� ������� */
CREATE DATABASE RelationsDemoDB
GO
USE RelationsDemoDB
GO
CREATE TABLE Addresses (
Id int PRIMARY KEY IDENTITY,
TownName nvarchar(16) NOT NULL,
StreetName nvarchar(32) NOT NULL,
[Description] nvarchar(128),
StreetNumber int NOT NULL
)
GO
CREATE TABLE Purposes (
Id int PRIMARY KEY IDENTITY,
Name nvarchar(16) NOT NULL,
Description nvarchar(128),
)
GO
CREATE TABLE Shops (
Id int PRIMARY KEY IDENTITY,
Name nvarchar(16) NOT NULL,
StartHour int NOT NULL,
EndHour int NOT NULL,
AddressId int NOT NULL 
CONSTRAINT FK_Shops_Addresses
REFERENCES Addresses(Id),
PurposeId int NOT NULL 
CONSTRAINT FK_Shops_Purposes
REFERENCES Purposes(Id)
)
GO
CREATE TABLE People (
EGN nvarchar(4) PRIMARY KEY,
Name nvarchar(32) NOT NULL,
Age int,
Email nvarchar(32) UNIQUE NOT NULL,
Proffession nvarchar(32) 
)

CREATE TABLE PeopleShops(
PersonId nvarchar(4) NOT NULL
CONSTRAINT FK_PeopleShops_People
REFERENCES People(EGN),
ShopId int NOT NULL
CONSTRAINT FK_PeopleShops_Shops
REFERENCES Shops(Id),
CONSTRAINT PK_PeopleShops PRIMARY KEY(PersonId,ShopId)
)

INSERT INTO Addresses(TownName,StreetName,StreetNumber,Description) VALUES
('Shumen','Cherna gora',12,'Bqlata prust'),
('Varna','Glarus',7,'Morskata Gradina'),
('Shumen','Trakia',9,'Krugovoto na kauflanda')

INSERT INTO People(EGN,Name,Age,Proffession,Email) VALUES
('8743','Purvan Goshkov',35,N'���������','purvanG@yahoo.com'),
('9753','Vtorislav Goshkov',76,'���������','gosholosho@abv.bg'),
('2211','Tretomir Chetvurtoslavov',76,'Krupie','3tomir-gmail.com'),
('1212','Petur Shestomirov',26,'Magaziner','5etur@abv.bg'),
('H43S','Shestoslava Sedmomirova',17,'Dilar na Kozmetika','6i6arka@dir.bg')

INSERT INTO Purposes(Name,Description) VALUES
('Bakladjiinica','Mnogo zahar mnogo kalorii'),
('Kafe','Ima masichki i se piqt kafeta moje i sok4eta'),
('Hranitelen','Prodava se i sirene!'),
('Za jivotni','Samo malki jivotni kravi ne!')

INSERT INTO Shops(StartHour,EndHour,AddressId,PurposeId,Name) VALUES
(8,20,1,7,'ZooMag 75 Eood'),
(7,22,3,6,'Mambo'),
(10,23,2,5,'Generala'),
(6,16,1,4,'Golqmata baklava')

INSERT INTO PeopleShops(ShopId,PersonId) VALUES
(2,'H43S'),
(4,'H43S'),
(4,'1212'),
(3,'9753'),
(3,'8743')

--ALTER TABLE Shops 
--ADD Name VARCHAR(16) NOT NULL

SELECT * FROM Addresses
SELECT * FROM Purposes
SELECT * FROM People
SELECT * FROM Shops
SELECT * FROM PeopleShops

/* �� �� ������� ������ ���� ���������� �� ova ������� �������� �������� � ���������� �� ��������
*/
SELECT TOP(3) p.Email AS [�����],p.Name AS [�����],s.Name as [��� �� �������],pur.Description AS [�������] FROM People as p
JOIN PeopleShops as ps
ON p.EGN=ps.PersonId
JOIN Shops as s
ON ps.ShopId=s.Id
JOIN Addresses AS a
ON a.Id=s.AddressId
JOIN Purposes as pur
ON pur.Id=s.PurposeId
WHERE p.Name LIKE '%ova'