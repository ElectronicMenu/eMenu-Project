USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_country_readById]    Script Date: 2016-03-13 2:59:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_country_readById] 
	@country_id int
AS 
    SELECT *
    FROM [dbo].[country]
	WHERE country_id = @country_id


GO


