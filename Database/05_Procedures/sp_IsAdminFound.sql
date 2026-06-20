USE [DVLDSystemDb]
GO

/****** Object:  StoredProcedure [dbo].[sp_IsAdminFound]    Script Date: 6/20/2026 2:54:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





ALTER PROCEDURE [dbo].[sp_IsAdminFound]
AS
BEGIN
SELECT IsFound = 1 FROM Users WHERE UserName = 'admin';
END
GO


