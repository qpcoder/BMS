USE qpBMS
GO

--VIEW
CREATE VIEW View_GraderDetail AS 
	SELECT u.ID AS [UniversityID], u.Name AS [UniversityName], f.ID AS [FacultiesID], f.Name AS [FacultiesName], g.ID AS [GraderID], g.Name AS [GraderName]
	FROM dbo.Countries AS u 
		INNER JOIN dbo.Faculties AS f ON u.ID = f.UniversityID
		INNER JOIN dbo.Graders AS g ON f.ID = g.FacultyID

--DROP VIEW dbo.View_GraderDetail
--SELECT * FROM dbo.View_GraderDetail
GO

CREATE VIEW View_DistrictDetail AS
	SELECT c.ID AS [CountryID], c.Name AS [CountryName], c.Code AS [CountryCode], p.ID AS [ProvinceID], p.Name AS [ProvinceName], p.Code AS [ProvinceCode], d.ID AS [DistrictID], d.Name AS [DistrictName], d.Code AS [DistrictCode]
	FROM dbo.Countries AS c 
		INNER JOIN dbo.Provinces AS p ON c.ID = p.CountryID
		INNER JOIN dbo.Districts AS d ON p.ID = d.ProvinceID

--DROP View_DistrictDetail
--SELECT * FROM View_DistrictDetail
GO

CREATE VIEW View_StudentDetail AS
	SELECT a.ID AS [AccountID], a.FirstName, a.MiddleName, a.LastName, a.MSSV, a.Specialized, a.GraduationYear, g.ID AS [GraderID], g.Code, g.Name
	FROM dbo.Accounts AS a 
		INNER JOIN dbo.Graders AS g ON a.GraderID = g.ID

--DROP View_StudentDetail
--SELECT * FROM View_StudentDetail
GO