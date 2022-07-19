CREATE DATABASE [eCapital];

USE [eCapital];

CREATE TABLE [eCapital].[dbo].[Employee] (
	Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	FirstName NVARCHAR(200) NOT NULL,
	LastName NVARCHAR(200) NOT NULL,
	Salary INT NOT NULL
);

INSERT INTO [eCapital].[dbo].[Employee] VALUES ('Lewis', 'Burson', 40700);
INSERT INTO [eCapital].[dbo].[Employee] VALUES ('Ian', 'Malcolm', 70000);
INSERT INTO [eCapital].[dbo].[Employee] VALUES ('Ellie', 'Sattler', 102000);
INSERT INTO [eCapital].[dbo].[Employee] VALUES ('Dennis', 'Nedry', 52000);
INSERT INTO [eCapital].[dbo].[Employee] VALUES ('John', 'Hammond', 89600);
INSERT INTO [eCapital].[dbo].[Employee] VALUES ('Ray', 'Arnold', 45000);
INSERT INTO [eCapital].[dbo].[Employee] VALUES ('Laura', 'Burnett', 80000);

SELECT *
FROM [eCapital].[dbo].[Employee];