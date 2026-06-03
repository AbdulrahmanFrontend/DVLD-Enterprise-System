USE [DVLD]
GO

/****** Object:  Table [dbo].[ApplicationTypes]    Script Date: 6/3/2026 3:41:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ApplicationTypes](
	[ApplicationTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ApplicationTypeTitle] [nvarchar](150) NOT NULL,
	[ApplicationFees] [smallmoney] NOT NULL,
 CONSTRAINT [PK_ApplicationTypes] PRIMARY KEY CLUSTERED 
(
	[ApplicationTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ApplicationTypes] ADD  CONSTRAINT [DF_ApplicationTypes_Fees]  DEFAULT ((0)) FOR [ApplicationFees]
GO

ALTER TABLE [dbo].[ApplicationTypes]  WITH CHECK ADD  CONSTRAINT [CK_ApplicationTypes_ApplicationFeesLargerThanOrEqualZero] CHECK  (([ApplicationFees]>=(0)))
GO

ALTER TABLE [dbo].[ApplicationTypes] CHECK CONSTRAINT [CK_ApplicationTypes_ApplicationFeesLargerThanOrEqualZero]
GO


