USE adbc;

DROP TABLE IF EXISTS keysERRelationship;

CREATE TABLE keysERRelationship(
	ERRelationshipID int not null identity primary key,
	DescriptionShort varchar(10) not null,
	DescriptionLong varchar(30) not null
);

INSERT INTO keysERRelationship (DescriptionShort, DescriptionLong)
	VALUES 
		('1nBinaryNI', '1-N Binary, Non-identifying'),
		('1nBinaryID', '1-N Binary, Identifying'),
		('nnBinary', 'N-N Binary'),
		('11Binary', '1-1 Binary'),
		('1nUnary', '1-N Unary'),
		('incOver', 'Incomplete, Overlapping'),
		('compDis', 'Complete, Disjoint');
