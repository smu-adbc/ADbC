﻿USE adbc;

DROP TABLE IF EXISTS ERNotation;

CREATE TABLE ERNotation(
	ERNotationID int not null identity primary key,
	DescriptionShort varchar(10) not null,
	DescriptionLong varchar(20) not null
);

INSERT INTO ERNotation (DescriptionShort, DescriptionLong)
	VALUES 
		('Max', 'Maximum'),
		('MinMax', 'Minimum:Maximum'),
		('CrowsFeet', 'Crow''s Feet'),
		('IDEF1X', 'IDEF1X'),
		('UMLC', 'UML Class'),
		('MO', 'Mandatory - Optional');
