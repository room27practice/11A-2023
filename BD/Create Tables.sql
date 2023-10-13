CREATE DATABASE HoraDurjaviGradove
USE HoraDurjaviGradove

CREATE DATABASE MountainsDB
USE MountainsDB

CREATE TABLE Countries(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(20) NOT NULL,
Designation NVARCHAR(2) NOT NULL,
Population INT NOT NULL,
AreaKM2 DECIMAL(12,2)
)

CREATE TABLE Mountains(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(20) NOT NULL,
CountryID INT NOT NULL 
CONSTRAINT FK_Mountains_Countries 
FOREIGN KEY REFERENCES Countries(Id)
)

CREATE TABLE Peaks(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(20) NOT NULL,
Height INT NOT NULL,
AverageTemp DECIMAL(5,2),
MountainID INT NOT NULL 
CONSTRAINT FK_Peaks_Mountains
FOREIGN KEY REFERENCES Mountains(Id)
)

INSERT INTO Countries VALUES
('Bulgaria','BG',5000000,111000),
('Germania','GR',80000000,357000)

INSERT INTO Mountains VALUES
('Shvartzvald',2),
('Stara Planina',1),
('Pirin',1),
('Rila',1)

SELECT * FROM Countries
SELECT * FROM Mountains
SELECT * FROM Peaks

DROP TABLE Peaks

INSERT INTO Peaks(MountainID, Height,Name, AverageTemp) VALUES
(4, 2925,'Musala',-8.5),
(2,2255,'Mechi Chalk', null)

INSERT INTO Peaks(MountainID, Height,Name, AverageTemp) VALUES
(1, 1493, 'FeldBerg' , -20.3)

DELETE FROM Peaks
WHERE Name='FeldBERG' OR Height>3000

TRUNCATE TABLE Peaks