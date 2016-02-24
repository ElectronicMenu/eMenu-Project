USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_cart_readByTableIDAndUserID]    Script Date: 2016-02-20 9:35:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [hd_emenu].[sp_cart_readByTableIDAndUserID]
	@table_id int,
	@user_id int
AS 
BEGIN
    SELECT *
    FROM [dbo].[cart]
	WHERE table_id=@table_id AND user_id=@user_id
END
GO


