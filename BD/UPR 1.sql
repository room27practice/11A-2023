--1.	People:
---	FirstName ( стринг 16 символа) [Not null]
---	SurName ( стринг 16 символа) [ако има има ако не, няма проблем]
---	LastName ( стринг 16 символа) [Not null]
---	Age (int) [Not null]
---	Gender (bool) (true = male) [Not null]
---	Email (string 32) [ако има има ако не, няма проблем]
---	Town [Not null]
--2.	Towns:
---	Name ( стринг 16 символа) [Not null]
---	Population (int) [Not null]
---	PostCode (string 8) [optional]
---	Country 
---	Region (град) [Optional]



--3.	Country:
---	Name ( стринг 16 символа) [Not null]
---	PopulationMilions (int) [Not null]
---	Designation (string 2) [Not null]
---	ContinentName [Not null]
---	Languages (string 64) [Not null]
---	Description (string 1024) [може и да няма]




CREATE DATABASE Upr1DB
USE Upr1DB

CREATE TABLE Countries(
Designation nvarchar(2) PRIMARY KEY,
Name nvarchar(16) NOT NULL,
PopulationMilions int NOT NULL ,
ContinentName nvarchar(32) NOT NULL,
Languages nvarchar(64) NOT NULL,
Description nvarchar(1024) 
)

GO

CREATE TABLE Towns(
Id int PRIMARY KEY,
Name nvarchar(16) NOT NULL,
Population int NOT NULL ,
PostCode nvarchar(8) NOT NULL,
CountryId nvarchar(2) NOT NULL CONSTRAINT FK_Towns_Countries
FOREIGN KEY REFERENCES Countries(Designation),
Region int CONSTRAINT FK_Towns_Towns
FOREIGN KEY REFERENCES Towns(Id),
)

GO

CREATE TABLE People(
Id int PRIMARY KEY IDENTITY,
FirstName nvarchar(16) NOT NULL ,
SurName nvarchar(16) ,
LastName nvarchar(16) NOT NULL ,
Age int NOT NULL,
Gender bit, 
Email nvarchar(32) UNIQUE,
TownId int NOT NULL CONSTRAINT FK_People_Towns
FOREIGN KEY REFERENCES Towns(Id), 
)

INSERT INTO Countries(Name, PopulationMilions, Designation, ContinentName, Languages,Description) VALUES
('Bulgaria',6.5,'BG','Europe','Bulgarian','Visoki sini planini, Reki I zlatni ravnini.'),
('Uganda',45,'UG','Africa','English','For God and My Country'),
('USA',329,'US','South America','English, Spanish','E pluribus unum')

INSERT INTO Towns(Id,Name,Population,PostCode,CountryId,Region ) VALUES
 (1,'Shumen',89000,'9700','BG', 1	)
,(22,'Plovdiv',343000,'4000', 'BG', 22	)
,(3,'Smiadovo',4044,'9820', 'BG', 1		)
,(4,'Richmond',229000,'V4K','US',4	)
,(5,'Kampala',1500000,'759125','UG', 5	)
,(6,'Kaolinovo',1000,'9701','BG', 1	)

INSERT INTO Towns(Id,Name,Population, PostCode, CountryId, Region ) VALUES
 (77,'Varna',350000,'1700','BG', 77	)

 DELETE FROM Towns
 WHERE Id =77

 
SELECT * FROM Countries
SELECT * FROM Towns
SELECT * FROM People

DROP TABLE Towns
DROP TABLE Countries
DROP TABLE People