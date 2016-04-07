USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_country_readByName]    Script Date: 2016-03-13 3:00:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dhammi].[sp_country_readByName] 
	@country_name nvarchar(50)
AS 
    SELECT *
    FROM [dbo].[country]
	WHERE country_name = @country_name



GO


