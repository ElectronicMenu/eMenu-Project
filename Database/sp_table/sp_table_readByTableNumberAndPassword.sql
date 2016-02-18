USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_table_readByTableNumberAndPassword]    Script Date: 2/16/2016 10:08:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_table_readByTableNumberAndPassword] 
	@table_number int,
	@table_password nvarchar(50)
AS 
BEGIN
    SELECT *
    FROM [dbo].[table]
	WHERE table_number = @table_number 
	AND table_password= @table_password
END

GO


