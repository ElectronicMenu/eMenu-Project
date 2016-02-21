USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_cart_product_insert]    Script Date: 2016-02-20 9:36:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [hd_emenu].[sp_cart_product_insert]
	@cart_id int,
	@product_id int,
	@quantity int,
	@total float
	
AS 
BEGIN
    INSERT INTO [dbo].[cart_product] (cart_id, product_id, quantity, total)
	VALUES (@cart_id, @product_id, @quantity, @total)
END

GO


