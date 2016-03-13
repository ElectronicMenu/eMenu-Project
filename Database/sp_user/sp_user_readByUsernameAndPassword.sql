USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_user_readByUsernameAndPassword]    Script Date: 2016-03-13 3:18:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [hd_emenu].[sp_user_readByUsernameAndPassword]
	@user_username nvarchar(50),
	@user_password nvarchar(50)
AS 
BEGIN
    SELECT *
    FROM [dbo].[user]
	WHERE user_username=@user_username 
	AND user_password =@user_password
END

GO


