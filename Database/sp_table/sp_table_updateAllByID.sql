USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_table_updateAllByID]    Script Date: 2/16/2016 10:08:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dhammi].[sp_table_updateAllByID] 
	@table_id int,
	@table_number int,
	@table_password nvarchar(50),
	@table_is_occupied bit	
AS 
BEGIN
    UPDATE [dbo].[table]
	SET table_number = @table_number, table_password = @table_password, table_is_occupied= @table_is_occupied
	WHERE table_id=@table_id
END


GO


