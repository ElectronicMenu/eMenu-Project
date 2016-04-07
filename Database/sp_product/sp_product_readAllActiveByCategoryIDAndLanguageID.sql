USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_product_readAllActiveByCategoryIDAndLanguageID]    Script Date: 2016-03-13 3:14:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [hd_emenu].[sp_product_readAllActiveByCategoryIDAndLanguageID]
@category_id int,
@language_id int
AS 
BEGIN
    SELECT a.product_id, b.product_name, b.product_description, a.product_image, a.product_is_veg,
a.product_is_active, a.product_price, a.product_discount_type, a.product_discount, a.product_final_price 
    FROM [dbo].[product] a
INNER JOIN [dbo].[product_language] b
ON a.product_id = b.product_id
WHERE  a.category_id = @category_id AND b.language_id=@language_id AND a.product_is_active = 1
END
GO


