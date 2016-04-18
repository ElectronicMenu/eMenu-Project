USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_category_category_language_readByCategoryIDAndLanguageID]    Script Date: 2016-03-03 12:43:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [hd_emenu].[sp_category_category_language_readByCategoryIDAndLanguageID]
	@category_id int,
	@language_id int
AS 
BEGIN
    SELECT a.category_id, a.category_image, a.category_icon, b.language_id, b.category_name
    FROM [dbo].[category] a 
	INNER JOIN [dbo].[category_language] b
	ON a.category_id = b.category_id
	WHERE a.category_id =@category_id AND b.language_id = @language_id
END





GO


