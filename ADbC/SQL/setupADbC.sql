--Create and select database
If(db_id(N'adbc') IS NULL) CREATE DATABASE adbc;

USE adbc;

--Create user and permissions
CREATE LOGIN adbcuser WITH PASSWORD = 'adbc'
GO

EXEC sp_addrolemember N'db_datareader', N'adbcuser'
GO
