USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_language_readByID]    Script Date: 2/17/2016 1:49:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dhammi].[sp_language_readByID] 
	@language_id int
AS 
BEGIN
    SELECT *
    FROM [dbo].[language] 
	WHERE language_id=@language_id

END

GO
