USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_order_details_insertByCartIDAndProductID]    Script Date: 2016-03-03 12:11:00 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [hd_emenu].[sp_order_details_insertByCartIDAndProductID]
	@cart_id int,
	@order_id int
AS 
BEGIN
	INSERT INTO [dbo].[order_details](order_id, product_id, quantity) SELECT @order_id , product_id, quantity
	FROM [dbo].[cart_product] 
	WHERE cart_id = @cart_id
	DELETE FROM [dbo].[cart_product]
	WHERE cart_id = @cart_id
END

GO


