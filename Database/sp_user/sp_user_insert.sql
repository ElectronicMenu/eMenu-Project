USE [hd_emenu]
GO

/****** Object:  StoredProcedure [hd_emenu].[sp_user_insert]    Script Date: 2016-03-13 3:17:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [hd_emenu].[sp_user_insert]
	@user_username nvarchar(50),
	@user_password nvarchar(50),
	@user_first_name nvarchar(50),
	@user_last_name nvarchar(50),
	@user_gender nvarchar(50),
	@user_email nvarchar(50),
	@user_phone nvarchar(50),
	@user_verification_code nvarchar(50),
	@user_date_of_birth date,
	@country_id int
	
AS 
BEGIN
    INSERT INTO [dbo].[user] (user_username,user_password, 
	user_first_name, user_last_name, user_gender,user_email, user_phone,user_email_verified, user_verification_code, user_date_of_birth,country_id)
	VALUES (@user_username, @user_password, @user_first_name,@user_last_name,@user_gender,
	@user_email,@user_phone,0, @user_verification_code,@user_date_of_birth, @country_id)
END


GO


