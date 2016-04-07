USE [hd_emenu]
GO

/****** Object:  StoredProcedure [dhammi].[sp_Country_readAll]    Script Date: 2016-03-13 2:59:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dhammi].[sp_Country_readAll] 
AS 
    SELECT *
    FROM [dbo].[country]


GO


