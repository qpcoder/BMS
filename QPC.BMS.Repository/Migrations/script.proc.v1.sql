USE qpBMS
GO

--PROCEDURE 
CREATE PROC Proc_Get_Countries
(
	@pageIndex INTEGER, 
	@pageSize INTEGER
)
AS
	BEGIN
		DECLARE @RowPast INTEGER = (@pageIndex - 1)*@pageSize;
		SELECT *
		FROM dbo.Countries
		ORDER BY Name
		OFFSET @RowPast ROW FETCH NEXT @pageSize ROWS ONLY;
	END
GO

--DROP PROCEDURE dbo.Proc_Get_Countries
--EXECUTE dbo.Proc_Get_Countries @pageIndex = 1, @pageSize = 10

CREATE PROC Proc_Get_Province
(
	@countryID INTEGER,
	@pageIndex INTEGER,
	@pageSize INTEGER
)
AS
	BEGIN
		DECLARE @RowPast INTEGER = (@pageIndex - 1) * @pageSize;
		SELECT * 
		FROM dbo.Provinces AS p INNER JOIN dbo.Countries AS c
			ON c.ID = p.CountryID
		ORDER BY c.Code
		OFFSET @RowPast ROW FETCH NEXT @pageSize ROWS ONLY;
	END
GO
--DROP PROC dbo.Proc_Get_Province
--EXECUTE dbo.Proc_Get_Province @countryID = 1, @pageIndex = 5,@pageSize = 5
