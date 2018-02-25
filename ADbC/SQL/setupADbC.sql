--Create and select database
If(db_id(N'adbc') IS NULL) CREATE DATABASE adbc;

USE adbc;

--Create user and permissions
CREATE LOGIN adbcuser WITH PASSWORD = 'adbc'
GO

EXEC sp_addrolemember N'db_datareader', N'adbcuser'
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Module] (
    [ModuleID]      INT          IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [ModuleName]    VARCHAR (50) NOT NULL,
    [HasIntroModal] BIT          NOT NULL
);
GO

SET IDENTITY_INSERT [dbo].[Module] ON
INSERT INTO [dbo].[Module] ([ModuleID], [ModuleName], [HasIntroModal]) VALUES (1, N'ER Notation', 1)
INSERT INTO [dbo].[Module] ([ModuleID], [ModuleName], [HasIntroModal]) VALUES (2, N'Scenario To ER', 1)
SET IDENTITY_INSERT [dbo].[Module] OFF
GO

CREATE TABLE [dbo].[ModuleIntroSection] (
    [ModuleIntroSectionID] INT          IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [ModuleID]             INT NOT NULL FOREIGN KEY REFERENCES dbo.Module(ModuleID) ,
    [SectionTitle]         VARCHAR (50) NOT NULL,
    [SectionOrder]         INT          NOT NULL,
    [OpenOnStart]          BIT          NOT NULL
);
GO

SET IDENTITY_INSERT [dbo].[ModuleIntroSection] ON
INSERT INTO [dbo].[ModuleIntroSection] ([ModuleIntroSectionID], [ModuleID], [SectionTitle], [SectionOrder], [OpenOnStart]) VALUES (1, 1, N'Notations and Symbols', 1, 1)
INSERT INTO [dbo].[ModuleIntroSection] ([ModuleIntroSectionID], [ModuleID], [SectionTitle], [SectionOrder], [OpenOnStart]) VALUES (2, 1, N'Crow''s Feet', 2, 0)
INSERT INTO [dbo].[ModuleIntroSection] ([ModuleIntroSectionID], [ModuleID], [SectionTitle], [SectionOrder], [OpenOnStart]) VALUES (3, 1, N'Maximum / Min:Max', 3, 0)
INSERT INTO [dbo].[ModuleIntroSection] ([ModuleIntroSectionID], [ModuleID], [SectionTitle], [SectionOrder], [OpenOnStart]) VALUES (4, 1, N'IDEF1X', 4, 0)
INSERT INTO [dbo].[ModuleIntroSection] ([ModuleIntroSectionID], [ModuleID], [SectionTitle], [SectionOrder], [OpenOnStart]) VALUES (5, 1, N'UML Class', 5, 0)
SET IDENTITY_INSERT [dbo].[ModuleIntroSection] OFF
GO

CREATE TABLE [dbo].[ModuleIntroContent] (
    [ModuleIntroContentID] INT           IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [ModuleIntroSectionID] INT FOREIGN KEY REFERENCES dbo.ModuleIntroSection(ModuleIntroSectionID) NOT NULL,
    [IsImage]              BIT           NOT NULL,
    [Content]              VARCHAR (MAX) NOT NULL,
    [ContentOrder]         INT           NOT NULL
);
GO

SET IDENTITY_INSERT [dbo].[ModuleIntroContent] ON
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (1, 1, 0, N'Every E-R diagram consists of several components: <b>entities, attributes, identifiers,</b> and <b>relationships.</b>', 1)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (2, 1, 0, N'It is possible to diagram these components using one of many methods of E-R Diagramming.', 2)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (3, 1, 0, N'Even though there is not one universal, acceptable method to E-R Diagramming, many of the <b>symbols</b> used remain consistent.', 3)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (4, 1, 0, N'<ul><li>First, <b>classes</b> are denoted by <b>rectangles</b>.</li><li><b>Lines</b> are then drawn between the classes to depict a link between two classes. Often, a <b>diamond</b> or <b>triangle</b> will be drawn on this line that tells how the two classes are related.</li><li>Finally, different diagrams use <b>unique symbols</b> to show <b>cardinality</b>. These symbols hardly ever remain consistent, and can be numbers, hash marks, diamonds, or crow''s feet.</li></ul>', 4)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (5, 2, 1, N'http://via.placeholder.com/200x100', 1)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (6, 2, 0, N'<ul><li>Uses <b>"crow''s feet"</b> to show cardinality</li><li>Shows <b>mandatory</b> (|) and <b>optional</b> (O) values</li></ul>', 2)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (8, 3, 1, N'http://via.placeholder.com/200x100', 1)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (9, 4, 1, N'http://via.placeholder.com/200x100', 1)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (10, 5, 1, N'http://via.placeholder.com/200x100', 1)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (11, 3, 0, N'<ul><li>Shows <b>numerical maximum</b>, or <b>minimum:maximum</b> on each side of a relationship</li><li>Uses the number <b>zero</b> (0) to note an <b>optional</b> relationship</li></ul>', 2)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (12, 4, 0, N'<ul><li>Used by US Government organizations</li><li>Uses the number <b>open</b> and <b>closed symbols</b> to note cardinality</li></ul>', 2)
INSERT INTO [dbo].[ModuleIntroContent] ([ModuleIntroContentID], [ModuleIntroSectionID], [IsImage], [Content], [ContentOrder]) VALUES (13, 5, 0, N'<ul><li>Cardinality is shown with Minimum to Maximum values seperated by an <b>ellispis</b></li><li>A <b>triangle</b> is used to note the <b>direction</b> of the relationship</li></ul>', 2)
SET IDENTITY_INSERT [dbo].[ModuleIntroContent] OFF

CREATE TABLE [dbo].[MCQuestion] (
    [MCQuestionID]     INT           IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [ModuleID]         INT FOREIGN KEY REFERENCES dbo.Module(ModuleID) NOT NULL,
    [Title]            VARCHAR (50)  NOT NULL,
    [DescriptionLong]  VARCHAR (MAX) NOT NULL,
    [DescriptionShort] VARCHAR (50)  NULL
);
GO

SET IDENTITY_INSERT [dbo].[MCQuestion] ON
INSERT INTO [dbo].[MCQuestion] ([MCQuestionID], [ModuleID], [Title], [DescriptionLong], [DescriptionShort]) VALUES (1, 2, N'Employee Organization', N'An employee may work on any number of projects (one, many, or none at all).  While an employee is not required to be working on a project, each project must have at least one employee allocated to it (one or many).  Furthermore, every employee must belong to one and only one department.  For a department to exist however, it must have at least two employees.', N'employees')
INSERT INTO [dbo].[MCQuestion] ([MCQuestionID], [ModuleID], [Title], [DescriptionLong], [DescriptionShort]) VALUES (2, 2, N'Auto Dealer', N'A local car dealer has contracted you to design a database system that will track car repairs made by its technicians. In the system design, a mechanic must be assigned to each car for repair as each repair is tracked via a work report. Moreover, the database system should be able to generate a report for the customer that contains a description of the work that was performed, date, time, and result.', N'dealership')
SET IDENTITY_INSERT [dbo].[MCQuestion] OFF

CREATE TABLE [dbo].[MCAnswer] (
    [MCAnswerID]       INT           IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [RelativeAnswerID] INT           NOT NULL,
    [QuestionID]       INT FOREIGN KEY REFERENCES dbo.MCQuestion(MCQuestionID) NOT NULL,
    [Correct]          BIT           NOT NULL,
    [ResponseText]     VARCHAR (MAX) NOT NULL
);
GO

SET IDENTITY_INSERT [dbo].[MCAnswer] ON
INSERT INTO [dbo].[MCAnswer] ([MCAnswerID], [RelativeAnswerID], [QuestionID], [Correct], [ResponseText]) VALUES (1, 1, 1, 0, N'The cardinality of this ER Diagram is incorrect. The scenario states that an employee is not required to be working on a project, but the cardinality of this solution''s ER Diagram incorrectly shows that an employee must work on at least one project.')
INSERT INTO [dbo].[MCAnswer] ([MCAnswerID], [RelativeAnswerID], [QuestionID], [Correct], [ResponseText]) VALUES (2, 2, 1, 1, N'Correct!  This solution correctly displays the entities, relationships, and cardinality of this scenario.')
INSERT INTO [dbo].[MCAnswer] ([MCAnswerID], [RelativeAnswerID], [QuestionID], [Correct], [ResponseText]) VALUES (3, 3, 1, 0, N'The cardinality of this ER Diagram is incorrect.  The scenario states that a project can have many employees but must have at least one employee.  According to this incorrect diagram, a Project can only have one Employee.  Moreover, the scenario states that an employee must belong one and only one department, but the cardinality of this solution incorrectly shows that an employee may not belong to a ')
INSERT INTO [dbo].[MCAnswer] ([MCAnswerID], [RelativeAnswerID], [QuestionID], [Correct], [ResponseText]) VALUES (4, 4, 1, 0, N'The cardinality of this ER Diagram is incorrect.  The scenario states that a project can have many employees but must have at least one employee.  According to this incorrect diagram, a Project can only have one Employee.  Moreover, this diagram depicts that an Employee can belong to many departments when, in this scenario, they can only belong to one.')
INSERT INTO [dbo].[MCAnswer] ([MCAnswerID], [RelativeAnswerID], [QuestionID], [Correct], [ResponseText]) VALUES (6, 1, 2, 0, N'A repair should be associated with only one car. In this diagram, the minimum cardinality shows that a repair can be associated with multiple cars.')
INSERT INTO [dbo].[MCAnswer] ([MCAnswerID], [RelativeAnswerID], [QuestionID], [Correct], [ResponseText]) VALUES (7, 2, 2, 0, N'A technician should be able to repair more than one car at a time. In this diagram, the minimum cardinality shows that a technician may only work on one car.')
INSERT INTO [dbo].[MCAnswer] ([MCAnswerID], [RelativeAnswerID], [QuestionID], [Correct], [ResponseText]) VALUES (8, 3, 2, 1, N'Correct!  This solution correctly displays the entities, relationships, and cardinality of this scenario.')
INSERT INTO [dbo].[MCAnswer] ([MCAnswerID], [RelativeAnswerID], [QuestionID], [Correct], [ResponseText]) VALUES (9, 4, 2, 0, N'A repair should be associated with only one car. In this diagram, the minimum cardinality shows that a repair can be associated with multiple cars.')
SET IDENTITY_INSERT [dbo].[MCAnswer] OFF


CREATE TABLE [dbo].[ERRelationship] (
    [ERRelationshipID] INT          IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [DescriptionShort] VARCHAR (10) NOT NULL,
    [DescriptionLong]  VARCHAR (30) NOT NULL
);
GO

CREATE TABLE [dbo].[ERNotation] (
    [ERNotationID]     INT          IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [DescriptionShort] VARCHAR (10) NOT NULL,
    [DescriptionLong]  VARCHAR (20) NOT NULL
);
GO

CREATE PROCEDURE [dbo].SelectERAnswersByQuestionID
	@ERQuestionID int
AS
	SELECT * FROM MCAnswer WHERE QuestionID = @ERQuestionID
RETURN 0
GO

CREATE PROCEDURE [dbo].SelectERQuestionsByModuleName
	@ModuleName varchar(50)
AS
	SELECT * FROM MCQuestion
	WHERE ModuleID in (SELECT ModuleID FROM Module WHERE ModuleName like @ModuleName)
RETURN 0
GO

CREATE PROCEDURE [dbo].SelectERQuestionByDescShort
	@DescriptionShort varchar(50)
AS
	SELECT * FROM MCQuestion WHERE DescriptionShort like @DescriptionShort
RETURN 0
GO

CREATE PROCEDURE [dbo].SelectERNotations
AS
	SELECT * FROM dbo.ERNotation
RETURN 0
GO

CREATE PROCEDURE [dbo].SelectERRelationships
AS
	SELECT * FROM dbo.ERRelationship
RETURN 0
GO

CREATE PROCEDURE [dbo].[SelectModuleByName]
	@ModuleName varchar(max)
AS
	SELECT * FROM dbo.Module WHERE ModuleName like @ModuleName
RETURN 0

CREATE PROCEDURE [dbo].[SelectModuleIntroSectionsByModuleID]
	@ModuleID int
AS
	SELECT * FROM dbo.ModuleIntroSection WHERE ModuleID = @ModuleID
RETURN 0
GO

CREATE PROCEDURE [dbo].[SelectModuleIntroContentByModuleID]
	@ModuleID int
AS
	SELECT * FROM dbo.ModuleIntroContent c
	WHERE c.ModuleIntroSectionID in (SELECT s.ModuleIntroSectionID FROM dbo.ModuleIntroSection s WHERE s.ModuleID = @ModuleID)
RETURN 0;
GO

