USE [hd_emenu]
 +GO
 +
 +/****** Object:  StoredProcedure [dhammi].[sp_category_category_language_readByID]    Script Date: 2/17/2016 4:12:41 PM ******/
 +SET ANSI_NULLS ON
 +GO
 +
 +SET QUOTED_IDENTIFIER ON
 +GO
 +
 +
 +
 +CREATE PROCEDURE [dhammi].[sp_language_readAllActive]

 +AS 
 +BEGIN
 +  SELECT *
   	FROM [dbo].[language]
	WHERE language_is_active = 1
 +END
 +
 +
 +GO