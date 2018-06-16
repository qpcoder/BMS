USE qpBMS
GO

--TRIGGER
CREATE TRIGGER Trig_Account_CheckOverlap
ON dbo.Accounts 
FOR INSERT, UPDATE
AS
	IF EXISTS(SELECT * FROM Inserted AS i INNER JOIN dbo.Accounts AS a ON
	a.ID = i.ID WHERE a.Email LIKE i.Email OR a.MSSV LIKE i.MSSV)
	BEGIN
		RAISERROR(N'The email and mssv fields in the table account are not duplicated!',16,1)
		ROLLBACK TRANSACTION
		RETURN
	END
GO

CREATE TRIGGER Trig_Country_CheckOverlap
ON dbo.Countries
FOR INSERT, UPDATE
AS
	IF EXISTS(SELECT * FROM Inserted AS i INNER JOIN dbo.Countries AS c ON i.ID = c.ID WHERE i.Code LIKE c.Code)
	BEGIN
		RAISERROR(N'The code field in the table countries are not duplicated!', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
    END
GO

CREATE TRIGGER Trig_Provinces_CheckOverlap
ON dbo.Provinces
FOR INSERT, UPDATE
AS
	IF EXISTS(SELECT * FROM Inserted AS i INNER JOIN dbo.Provinces AS p ON i.ID = p.ID WHERE i.Code LIKE p.Code)
	BEGIN
		RAISERROR(N'The code field in the table provinces are not duplicated!', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
    END
GO

CREATE TRIGGER Trig_Districts_CheckOverlap
ON dbo.Districts
FOR INSERT, UPDATE
AS
	IF EXISTS(SELECT * FROM Inserted AS i INNER JOIN dbo.Districts AS d ON i.ID = d.ID WHERE i.Code LIKE d.Code)
	BEGIN
		RAISERROR(N'The code field in the table districts are not duplicated!', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
    END
GO