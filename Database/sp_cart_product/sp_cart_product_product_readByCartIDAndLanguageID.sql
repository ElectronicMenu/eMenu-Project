USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_cart_product_product_readByCartIDAndLanguageID]    Script Date: 2016-03-13 3:09:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE [hd_emenu].[sp_cart_product_product_readByCartIDAndLanguageID]
	@cart_id int,
	@language_id int
AS 
BEGIN
    SELECT c.product_name, c.product_description, b.product_image, b.product_is_veg, b.product_is_active, b. product_price,
	b.product_discount_type, b.product_discount, b.product_final_price, a.quantity, a.total
	FROM [dbo].[cart_product] a 
	INNER JOIN [dbo].[product] b
	ON b.product_id = a.product_id
	INNER JOIN [dbo].[product_language] c
	ON b.product_id = c.product_id
	WHERE a.cart_id =@cart_id AND C.language_id = @language_id
END



GO


