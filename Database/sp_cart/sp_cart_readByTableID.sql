USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_cart_product_readByTableID]    Script Date: 2016-02-20 9:33:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [hd_emenu].[sp_cart_readByTableID]
	@table_id int,
	@language_id int
AS 
BEGIN
    SELECT a.cart_id, d.product_name, d.product_description, c.product_image, c.product_is_veg, c.product_is_active, c. product_price,
	c.product_discount_type, c.product_discount, c.product_final_price, b.quantity, b.total
	FROM [dbo].[cart] a 
	INNER JOIN [dbo].[cart_product] b
	ON a.cart_id = b.cart_id
	INNER JOIN [dbo].[product] c
	ON b.product_id = c.product_id
	INNER JOIN [dbo].[product_language] d
	ON c.product_id = d.product_id
	WHERE a.table_id = @table_id AND language_id = @language_id
END
GO


