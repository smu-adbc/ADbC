USE adbc;

DROP TABLE IF EXISTS ERRelationship;

CREATE TABLE ERRelationship(
	ERRelationshipID int not null identity primary key,
	DescriptionShort varchar(10) not null,
	DescriptionLong varchar(30) not null
);

INSERT INTO ERRelationship (DescriptionShort, DescriptionLong)
	VALUES 
		('1nBinaryNI', '1-N Binary, Non-identifying'),
		('1nBinaryID', '1-N Binary, Identifying'),
		('nnBinary', 'N-N Binary'),
		('11Binary', '1-1 Binary'),
		('1nUnary', '1-N Unary'),
		('incOver', 'Incomplete, Overlapping'),
		('compDis', 'Complete, Disjoint');
