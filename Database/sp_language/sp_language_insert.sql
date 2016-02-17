USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_table_insert]    Script Date: 2/16/2016 10:07:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dhammi].[sp_table_insert] 
	@table_number int,
	@table_password nvarchar(50)
AS 
BEGIN
    INSERT INTO [dbo].[table] (table_number, table_password, table_is_occupied)
	VALUES (@table_number, @table_password, 0)
	SELECT SCOPE_IDENTITY() AS table_id
END
GO


