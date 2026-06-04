USE [DVLDSystemDb]
GO

/****** Object:  Table [dbo].[TestTypes]    Script Date: 6/4/2026 4:27:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestTypes](
	[TestTypeID] [int] IDENTITY(1,1) NOT NULL,
	[TestTypeTitle] [nvarchar](100) NOT NULL,
	[TestTypeDescription] [nvarchar](500) NOT NULL,
	[TestTypeFees] [smallmoney] NOT NULL,
 CONSTRAINT [PK_TestTypes] PRIMARY KEY CLUSTERED 
(
	[TestTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TestTypes] ADD  CONSTRAINT [DF_TestTypes_TestTypeFees]  DEFAULT ((0)) FOR [TestTypeFees]
GO

ALTER TABLE [dbo].[TestTypes]  WITH CHECK ADD  CONSTRAINT [CK_TestTypes_TestTypeFees] CHECK  (([TestTypeFees]>=(0)))
GO

ALTER TABLE [dbo].[TestTypes] CHECK CONSTRAINT [CK_TestTypes_TestTypeFees]
GO


