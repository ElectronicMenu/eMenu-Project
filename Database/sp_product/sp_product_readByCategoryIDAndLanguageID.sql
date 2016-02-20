USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_product_readByCategoryIDAndLanguageID]    Script Date: 2016-02-20 12:58:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [hd_emenu].[sp_product_readByCategoryIDAndLanguageID]
@category_id int,
@language_id int
AS 
BEGIN
    SELECT c.category_name,  b.product_name, b.product_description, a.product_image, a.product_is_veg,
	a.product_is_active, a.product_price, a.product_discount, a.product_final_price
    FROM [dbo].[product] a
	INNER JOIN [dbo].[category_language] c
	ON a.category_id = c.category_id
	INNER JOIN [dbo].[product_language] b
	ON a.product_id = b.product_id
	WHERE  a.category_id = @category_id AND c.language_id=@language_id
END

GO


