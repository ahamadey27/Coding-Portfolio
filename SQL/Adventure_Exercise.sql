USE AdventureWorks2017
GO
CREATE PROCEDURE dbo.uspGetAddress
AS
SELECT * FROM Person.Address
GO
EXEC dbo.uspGetAddress

DROP PROCEDURE IF EXISTS dbo.uspGetAddress