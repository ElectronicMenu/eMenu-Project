USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_tax_readAll]    Script Date: 2016-03-13 2:58:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_tax_readAll] 
AS 
    SELECT *
    FROM [dbo].[tax]


GO


