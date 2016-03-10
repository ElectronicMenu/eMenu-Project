USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_cart_product_updateByCartIDAndProductID]    Script Date: 2016-03-03 12:17:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [hd_emenu].[sp_cart_product_updateByCartIDAndProductID] 
		@cart_id int,
		@product_id int,
		@quantity int
		
AS 
BEGIN
	UPDATE [dbo].[cart_product]
	SET quantity = @quantity 
	where cart_id= @cart_id AND product_id= @product_id
END


GO


