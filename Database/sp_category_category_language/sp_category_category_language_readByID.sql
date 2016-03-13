USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_category_category_language_readByID]    Script Date: 2/17/2016 4:12:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dhammi].[sp_category_category_language_readByCategoryID]
	@category_id int
AS 
BEGIN
    SELECT a.category_id, a.category_image, a.category_icon, b.language_id, b.category_name
    FROM [dbo].[category] a 
	INNER JOIN [dbo].[category_language] b
	ON a.category_id = b.category_id
	WHERE a.category_id =@category_id
END


GO


