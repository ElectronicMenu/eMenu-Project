USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_language_deleteByID]    Script Date: 2/17/2016 1:47:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dhammi].[sp_language_deleteByID] 
		@language_id int
AS 
BEGIN
	 DELETE [dbo].[language]
	 WHERE language_id = @language_id

END

GO


