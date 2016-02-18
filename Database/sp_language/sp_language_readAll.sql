USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_language_readAll]    Script Date: 2/17/2016 1:48:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_language_readAll] 
AS 
    SELECT *
    FROM [dbo].[language]

GO


