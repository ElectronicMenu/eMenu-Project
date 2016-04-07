USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_user_cart_readByUserIDAndCartID]    Script Date: 2016-03-13 3:06:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_user_cart_readByUserIDAndCartID] 
	@user_id int,
	@cart_id int
AS 
    SELECT *
    FROM [hd_emenu].[user_cart]
	WHERE user_id =@user_id
	AND cart_id = @cart_id


GO


