USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_tax_readById]    Script Date: 2016-03-13 2:57:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_tax_readById] 
	@tax_id int
AS 
    SELECT *
    FROM [dbo].[tax]
	WHERE tax_id = @tax_id


GO


