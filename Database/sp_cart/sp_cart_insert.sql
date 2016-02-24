USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_cart_insert]    Script Date: 2016-02-20 9:36:37 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [hd_emenu].[sp_cart_insert]
	@table_id int,
	@user_id int
AS 
BEGIN
    INSERT INTO [dbo].[cart] (table_id, user_id)
	VALUES (@table_id, @user_id)
	SELECT SCOPE_IDENTITY() AS cart_id
END



GO


