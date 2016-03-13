USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_user_cart_insert]    Script Date: 2016-03-13 3:06:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_user_cart_insert]
	@user_id int,
	@cart_id int
AS 
BEGIN
    INSERT INTO [hd_emenu].[user_cart](user_id, cart_id)
	VALUES (@user_id, @cart_id)
	
END


GO


