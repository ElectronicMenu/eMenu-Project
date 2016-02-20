USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_product_readByProductIDAndLanguageID]    Script Date: 2016-02-20 9:50:45 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [hd_emenu].[sp_product_readByProductIDAndLanguageID]
@product_id int,
@language_id int
AS 
BEGIN
    SELECT  b.product_name, b.product_description, a.product_image, a.product_is_veg,
	a.product_is_active, a.product_price, a.product_discount, a.product_final_price
    FROM [dbo].[product] a
	INNER JOIN [dbo].[product_language] b
	ON a.product_id = b.product_id
	WHERE  a.product_id = @product_id AND b.language_id=@language_id
END

GO


