USE [hd_emenu]
GO

/****** Object:  StoredProcedure [sp_category_category_language_readAll]    Script Date: 2/17/2016 4:12:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_category_category_language_readAllByLangguageID]
	@language_id int
AS 
BEGIN
    SELECT a.category_id, a.category_image, a.category_icon, b.language_id, b.category_name
    FROM [dbo].[category] a 
	INNER JOIN [dbo].[category_language] b
	ON a.category_id = b.category_id
	WHERE b.language_id = @language_id
END

GO



