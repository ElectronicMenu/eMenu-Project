USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_order_insert]    Script Date: 2016-03-03 12:12:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [hd_emenu].[sp_order_insert]
	@user_id int,
	@table_id int
	
AS 
BEGIN
    INSERT INTO [dbo].[order] (user_id, table_id,order_is_verified, 
	[order_is_completed], [order_total], [order_discount_type],[order_discount], [tax_id] )
	VALUES (@user_id, @table_id, 0,0,0,0,0,1)
END




GO


