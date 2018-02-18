--DROP TABLE dbo.keysModuleIntroContent;
--DROP TABLE dbo.keysModuleIntroSection;
--DROP TABLE dbo.keysModule

CREATE TABLE [dbo].[keysModule]
(
	[ModuleID] INT IDENTITY(1,1) PRIMARY KEY,
	[ModuleName] varchar(50) NOT NULL,
	[HasIntroModal] bit NOT NULL
)

INSERT INTO dbo.keysModule (ModuleName, HasIntroModal) VALUES
('ER Notation', 1)

SELECT * FROM keysModule

DECLARE @ERNotation int = (SELECT TOP 1 ModuleID FROM dbo.keysModule WHERE ModuleName like 'ER Notation')

CREATE TABLE [dbo].[keysModuleIntroSection]
(
	[ModuleIntroSectionID] INT IDENTITY(1,1)  PRIMARY KEY,
	[ModuleID] INT NOT NULL,
	[SectionTitle] varchar(50) NOT NULL,
	[SectionOrder] INT NOT NULL,
	[OpenOnStart] BIT NOT NULL,
	FOREIGN KEY (ModuleID) REFERENCES dbo.keysModule(ModuleID)
)

DECLARE @ERNotation int = (SELECT TOP 1 ModuleID FROM dbo.keysModule WHERE ModuleName like 'ER Notation')

INSERT INTO dbo.keysModuleIntroSection (ModuleID, SectionTitle, SectionOrder, OpenOnStart) VALUES
(@ERNotation, 'Notations and Symbols', 1, 1),
(@ERNotation, 'Crow''s Feet', 2, 0),
(@ERNotation, 'Maximum / Min:Max', 3, 0),
(@ERNotation, 'IDEF1X', 4, 0),
(@ERNotation, 'UML Class', 5, 0)

CREATE TABLE [dbo].[keysModuleIntroContent]
(
	[ModuleIntroContentID] INT IDENTITY(1,1)  PRIMARY KEY,
	[ModuleIntroSectionID] INT NOT NULL,
	[IsImage] BIT NOT NULL,
	[Content] VARCHAR(MAX) NOT NULL,
	[ContentOrder] INT NOT NULL
	FOREIGN KEY (ModuleIntroSectionID) REFERENCES dbo.keysModuleIntroSection(ModuleIntroSectionID)
)
SELECT * FROM dbo.keysModuleIntroSection WHERE ModuleID = 1