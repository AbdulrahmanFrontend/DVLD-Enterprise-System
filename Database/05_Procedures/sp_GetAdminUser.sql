USE [DVLDSystemDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetAdminUser]    Script Date: 6/11/2026 7:22:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




ALTER PROCEDURE [dbo].[sp_GetAdminUser]
AS
BEGIN
SELECT * FROM Users WHERE UserName = 'admin';
END
GO


