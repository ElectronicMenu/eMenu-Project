USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_category_category_language_deleteByID]    Script Date: 2/17/2016 4:11:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_category_category_language_deleteByID]
	@category_id int
AS 
BEGIN
	DELETE  
	[dbo].[category]
	WHERE category_id = @category_id
	DELETE  
	[dbo].[category_language]
	WHERE category_id = @category_id
	 
END


GO





