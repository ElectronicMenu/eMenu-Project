USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_language_updateByID]    Script Date: 2/17/2016 1:49:55 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dhammi].[sp_language_updateByID] 
		@language_id int,
		@language_name nvarchar(50),
		@language_short_name nvarchar(50),
		@language_flag nvarchar(50),
		@language_is_active BIT
AS 
BEGIN
	UPDATE [dbo].[language] 
	SET language_name= @language_name,language_short_name= @language_short_name, language_flag= @language_flag,language_is_active= @language_is_active
	where language_id = @language_id
END


GO


