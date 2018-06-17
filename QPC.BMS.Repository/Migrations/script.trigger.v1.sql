USE qpBMS
GO

--TRIGGER
--overlap feild mssv in table account
CREATE TRIGGER Trig_Account_CheckOverlapMSSV
ON dbo.Accounts 
FOR INSERT, UPDATE
AS
	DECLARE @total INT = 0;
	SELECT @total = (SELECT COUNT(DISTINCT i.MSSV) FROM Inserted AS i, dbo.Accounts AS a WHERE i.MSSV = a.MSSV AND i.ID <> a.ID)
	IF (@total <> 0)
		BEGIN
			RAISERROR(N'The mssv field in the table account are not duplicated!',16,1)
			ROLLBACK TRANSACTION
			RETURN
		END
GO
--DROP TRIGGER Trig_Account_CheckOverlapMSSV
GO

--overlap feild email in table account
CREATE TRIGGER Trig_Account_CheckOverlapEmail
ON dbo.Accounts 
FOR INSERT, UPDATE
AS
	DECLARE @total INT = 0;
	SELECT @total = (SELECT COUNT(DISTINCT i.Email) FROM Inserted AS i, dbo.Accounts AS a WHERE i.Email = a.Email AND i.ID <> a.ID)
	IF (@total <> 0)
		BEGIN
			RAISERROR(N'The email field in the table account are not duplicated!',16,1)
			ROLLBACK TRANSACTION
			RETURN
		END
GO
--DROP TRIGGER Trig_Account_CheckOverlapEmail
GO

-- overlap code in country
CREATE TRIGGER Trig_Country_CheckOverlap
ON dbo.Countries
FOR INSERT, UPDATE
AS
	IF EXISTS(SELECT * FROM Inserted AS i INNER JOIN dbo.Countries AS c ON i.Code = c.Code WHERE i.ID <> c.ID)
	BEGIN
		RAISERROR(N'The code field in the table countries are not duplicated!', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
    END
GO
--DROP TRIGGER Trig_Country_CheckOverlap
GO

-- overlap code in province
CREATE TRIGGER Trig_Provinces_CheckOverlap
ON dbo.Provinces
FOR INSERT, UPDATE
AS
	IF EXISTS(SELECT * FROM Inserted AS i INNER JOIN dbo.Provinces AS p ON i.Code = p.Code WHERE i.ID <> p.ID AND i.CountryID = p.CountryID)
	BEGIN
		RAISERROR(N'The code field in the table provinces are not duplicated!', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
    END
GO
--DROP TRIGGER Trig_Provinces_CheckOverlap
GO 

-- overlap code in table district
CREATE TRIGGER Trig_Districts_CheckOverlap
ON dbo.Districts
FOR INSERT, UPDATE
AS
	IF EXISTS(SELECT * FROM Inserted AS i INNER JOIN dbo.Districts AS d ON i.Code = d.Code WHERE i.ID <> d.ID AND i.ProvinceID = d.ProvinceID)
	BEGIN
		RAISERROR(N'The code field in the table districts are not duplicated!', 16, 1)
		--RAISERROR(@total, 16,1)
		ROLLBACK TRANSACTION
		RETURN
    END
GO
--DROP TRIGGER Trig_Districts_CheckOverlap
GO