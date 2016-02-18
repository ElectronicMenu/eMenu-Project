USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_category_category_language_insert]    Script Date: 2/17/2016 4:11:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_category_category_language_insert]
	@category_image nvarchar(50),
	@category_icon nvarchar(50),
	@language_id int,
	@category_name nvarchar(50)

AS 
BEGIN
DECLARE @last_inserted_id int
    INSERT 
    INTO [dbo].[category] (category_image, category_icon) 
	VALUES (@category_image, @category_icon) 
	SELECT @last_inserted_id = category_id FROM [dbo].[category] WHERE category_image= @category_image
	INSERT 
    INTO [dbo].[category_language](category_id, language_id, category_name) 
	VALUES (@last_inserted_id, @language_id, @category_name) 
END

GO


