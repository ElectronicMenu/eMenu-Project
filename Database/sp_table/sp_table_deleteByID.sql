USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_table_deleteByID]    Script Date: 2/16/2016 10:07:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dhammi].[sp_table_deleteByID] 
	@table_id int	
AS 
BEGIN
    DELETE [dbo].[table]
	WHERE table_id = @table_id
END
GO


