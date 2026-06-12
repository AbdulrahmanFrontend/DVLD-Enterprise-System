USE [DVLDSystemDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 6/12/2026 5:07:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Login]
@UserName NVARCHAR(20), @PasswordHash NVARCHAR(255)
AS
BEGIN
SELECT * FROM Users
WHERE UserName = @UserName AND PasswordHash = @PasswordHash AND IsActive = 1;
END;
GO


